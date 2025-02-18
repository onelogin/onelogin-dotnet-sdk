﻿
namespace OneLogin
{
    /// <summary>
    /// A client class to access the onelogin API /2
    /// https://developers.onelogin.com/api-docs/2/getting-started/dev-overview
    /// </summary>
    public partial class OneLoginClient
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly string _api_domain;
        private static HttpClient? _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneLoginClient"/> class.
        /// </summary>
        /// <param name="clientId">The client id to connect with.</param>
        /// <param name="clientSecret">The client secret to connect with.</param>
        /// <param name="api_domain"></param>
        public OneLoginClient(string clientId, string clientSecret, string api_domain)
        {
            if (string.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException(nameof(clientSecret));
            if (string.IsNullOrWhiteSpace(clientSecret)) throw new ArgumentNullException(nameof(clientSecret));
            if (string.IsNullOrWhiteSpace(api_domain)) throw new ArgumentNullException(nameof(api_domain));
            _clientId = clientId;
            _clientSecret = clientSecret;
            _api_domain = "https://" + api_domain;
        }

        /// <summary>
        /// Generate an access token and refresh token that you can use to call our resource APIs.
        /// For an overview of the authorization flow, see Authorizing Resource API Calls.
        /// Once generated, an access token is valid for 10 hours.
        /// <a href="https://developers.onelogin.com/api-docs/2/oauth20-tokens/generate-tokens-2">Documentation</a>.
        /// </summary>
        /// <returns>Returns the serialized <see cref="GenerateTokensResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GenerateTokensResponse>> GenerateTokens()
        {
            try
            {
                var client = new HttpClient();

                var credentials = $"{_clientId}:{_clientSecret}";
                var base64EncodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedCredentials);

                var content = new StringContent(JsonSerializer.Serialize(new { grant_type = "client_credentials" }));
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(_api_domain + Endpoints.Token),
                    Content = content
                };

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = client.SendAsync(request);
                return await ParseHttpResponse<GenerateTokensResponse>(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GenerateTokensResponse>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        /// <summary>
        /// Revoke an access token and refresh token pair..
        /// <a href="https://developers.onelogin.com/api-docs/2/oauth20-tokens/revoke-tokens">Documentation</a>.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<RevokeTokenReponse>> RevokeToken()
        {
            try
            {
                var client = new HttpClient();

                var credentials = $"{_clientId}:{_clientSecret}";
                var base64EncodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedCredentials);

                var token = await GenerateTokens();
                if (token?.Data?.AccessToken == null)
                {
                    throw new UnauthorizedAccessException("Unauthorized");
                }
                var content = new StringContent(JsonSerializer.Serialize(new { access_token = $"{token.Data.AccessToken}" }));
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(_api_domain + Endpoints.RevokeToken),
                    Content = content
                };

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = client.SendAsync(request);
                return await ParseHttpResponse<RevokeTokenReponse>(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse<RevokeTokenReponse>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        #region Private methods 
        private async Task<ApiResponse<T>> GetResource<T>(string url, string baseApiVersion)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }

                var client = await GetClient(baseApiVersion);
                var fullUrl = _api_domain + baseApiVersion + url;
                return await ParseHttpResponse<T>(client.GetAsync(fullUrl));
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        private async Task<HttpClient> GetClient(string baseApiVersion)
        {
            if (_client != null && baseApiVersion.Contains(_client.BaseAddress.AbsolutePath))
            {
                return _client;
            }

            var token = await GenerateTokens();
            if (token?.Data?.AccessToken == null)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            var client = new HttpClient { BaseAddress = new Uri(_api_domain + baseApiVersion) };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Data.AccessToken);
            return _client = client;
        }

        private async Task<ApiResponse<T>> PostResource<T>(string url, object request, string baseApiVersion)
        {
            try
            {
                if (request == null) throw new ArgumentNullException(nameof(request));
                if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }
                var fullUrl = _api_domain + baseApiVersion + url;

                var content = new StringContent(JsonSerializer.Serialize(request, options: new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                }));
                var httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(fullUrl, UriKind.Absolute),
                    Content = content
                };
                //We add the Content-Type Header like this because otherwise dotnet
                //adds the utf-8 charset extension to it which is not compatible with OneLogin
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var client = await GetClient(baseApiVersion);
                var response = client.SendAsync(httpRequest);
                return await ParseHttpResponse<T>(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        private async Task<ApiResponse<T>> PutResource<T>(string url, object request, string baseApiVersion)
        {
            try
            {
                if (request == null) throw new ArgumentNullException(nameof(request));
                if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }
                var fullUrl = _api_domain + baseApiVersion + url;

                var content = new StringContent(JsonSerializer.Serialize(request, options: new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                }));

                var httpRequest = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri(fullUrl, UriKind.Absolute),
                    Content = content
                };

                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var client = await GetClient(baseApiVersion);
                var response = client.SendAsync(httpRequest);
                return await ParseHttpResponse<T>(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        private async Task<ApiResponse<T>> DeleteResource<T>(string url, string baseApiVersion, object? request = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }

                var client = await GetClient(baseApiVersion);
                HttpRequestMessage httpRequest;
                var fullUrl = _api_domain + baseApiVersion + url;

                if (request != null)
                {
                    var content = new StringContent(JsonSerializer.Serialize(request, options: new JsonSerializerOptions
                    {
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                    }));

                    httpRequest = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(fullUrl, UriKind.Absolute),
                        Content = content
                    };

                    httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                }
                else
                {
                    httpRequest = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(url, UriKind.Relative)
                    };
                }

                var response = client.SendAsync(httpRequest);
                return await ParseHttpResponse<T>(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        private static async Task<ApiResponse<T>> ParseHttpResponse<T>(Task<HttpResponseMessage> taskResponse)
        {
            try
            {
                var response = await taskResponse;
                var responseBody = await response.Content.ReadAsStringAsync();


                if (string.IsNullOrWhiteSpace(responseBody))
                {
                    return new ApiResponse<T>();
                }
                else
                if (response.IsSuccessStatusCode)
                {
                    // Assuming the response body contains data when it's a 200 status code.
                    T? data = JsonSerializer.Deserialize<T>(responseBody);
                    return new ApiResponse<T>(data);
                }
                else
                {
                    var options = new JsonSerializerOptions
                    {
                        Converters = { new BaseErrorResponseConverter() }
                    };
                    // Handle error responses like 400.
                    var status = JsonSerializer.Deserialize<BaseErrorResponse>(responseBody, options);
                    return new ApiResponse<T>(status);
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        #endregion Private Methods
    }
}
