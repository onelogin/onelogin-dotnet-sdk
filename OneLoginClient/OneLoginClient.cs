
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
            return await ExecuteTokenRequest<GenerateTokensResponse>(Endpoints.Token, new { grant_type = "client_credentials" });
        }

        /// <summary>
        /// Revoke an access token and refresh token pair..
        /// <a href="https://developers.onelogin.com/api-docs/2/oauth20-tokens/revoke-tokens">Documentation</a>.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<RevokeTokenReponse>> RevokeToken()
        {
            var token = await GenerateTokens();
            if (token?.Data?.AccessToken == null)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }
            return await ExecuteTokenRequest<RevokeTokenReponse>(Endpoints.RevokeToken, new { access_token = token.Data.AccessToken });
        }

        private async Task<ApiResponse<T>> ExecuteTokenRequest<T>(string endpoint, object contentObject)
        {
            try
            {
                var client = new HttpClient();

                var credentials = $"{_clientId}:{_clientSecret}";
                var base64EncodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedCredentials);

                var content = new StringContent(JsonSerializer.Serialize(contentObject));
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(_api_domain + endpoint),
                    Content = content
                };

                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = client.SendAsync(request);
                return await ParseHttpResponse<T>(response);
            }
            catch (Exception ex)
            {
                return new ApiResponse<T>(new BaseErrorResponse { Message = ex.Message });
            }
        }

        #region Private methods for Version 2 API output
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
            return await SendResourceRequest<T>(url, request, baseApiVersion, HttpMethod.Post);
        }

        private async Task<ApiResponse<T>> PutResource<T>(string url, object request, string baseApiVersion)
        {
            return await SendResourceRequest<T>(url, request, baseApiVersion, HttpMethod.Put);
        }

        private async Task<ApiResponse<T>> DeleteResource<T>(string url, string baseApiVersion, object? request = null)
        {
            return await SendResourceRequest<T>(url, request, baseApiVersion, HttpMethod.Delete);
        }

        private async Task<ApiResponse<T>> SendResourceRequest<T>(string url, object? request, string baseApiVersion, HttpMethod method)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }
                var fullUrl = _api_domain + baseApiVersion + url;

                var content = request != null ? new StringContent(JsonSerializer.Serialize(request, options: new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                })) : null;

                var httpRequest = new HttpRequestMessage
                {
                    Method = method,
                    RequestUri = new Uri(fullUrl, UriKind.Absolute),
                    Content = content
                };

                if (content != null)
                {
                    httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                }

                var client = await GetClient(baseApiVersion);
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
                else if (response.IsSuccessStatusCode)
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
        #endregion Private Methods for Version 2 API output

        #region Private methods for Version 1 API output
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pages"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<List<T>> GetNextPages<T>(T source, int? pages = null) where T : IPageable
        {
            var results = new List<T>();
            var isTrue = Uri.IsWellFormedUriString(source.Pagination.NextLink, UriKind.Absolute);
            var pageCount = 1;
            var nextLink = source.Pagination.NextLink;
            while (isTrue && pageCount <= pages)
            {
                var result = await GetResourceV1<T>(nextLink, Endpoints.BaseApiVersion1);
                results.Add(result);
                nextLink = result.Pagination.NextLink;
                isTrue = Uri.IsWellFormedUriString(nextLink, UriKind.Absolute);
                pageCount++;
            }

            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pages"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<List<T>> GetPreviousPages<T>(T source, int? pages = null) where T : IPageable
        {
            var results = new List<T>();
            var isTrue = Uri.IsWellFormedUriString(source.Pagination.PreviousLink, UriKind.Absolute);
            var pageCount = 1;
            while (isTrue && pageCount <= pages)
            {
                var result = await GetResourceV1<T>(source.Pagination.PreviousLink, Endpoints.BaseApiVersion1);
                results.Add(result);
                isTrue = Uri.IsWellFormedUriString(result.Pagination.PreviousLink, UriKind.Absolute);
                pageCount++;
            }

            return results;
        }

        private async Task<T> GetResourceV1<T>(string url, string baseApiVersion)
        {
            if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }
            var fullUrl = _api_domain + baseApiVersion + url;
            var client = await GetClient(baseApiVersion);
            return await ParseHttpResponseV1<T>(client.GetAsync(fullUrl));
        }

        private async Task<T> PostResourceV1<T>(string url, object request, string baseApiVersion)
        {
            return await SendResourceRequestV1<T>(url, request, baseApiVersion, HttpMethod.Post);
        }

        private async Task<T> PutResourceV1<T>(string url, object request, string baseApiVersion)
        {
            return await SendResourceRequestV1<T>(url, request, baseApiVersion, HttpMethod.Put);
        }

        private async Task<T> DeleteResourceV1<T>(string url, string baseApiVersion)
        {
            return await SendResourceRequestV1<T>(url, null, baseApiVersion, HttpMethod.Delete);
        }

        private async Task<T> SendResourceRequestV1<T>(string url, object? request, string baseApiVersion, HttpMethod method)
        {
            if (string.IsNullOrWhiteSpace(url)) { throw new ArgumentException(nameof(url)); }
            var fullUrl = _api_domain + baseApiVersion + url;

            var content = request != null ? new StringContent(JsonSerializer.Serialize(request, options: new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            })) : null;

            var httpRequest = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(fullUrl, UriKind.Absolute),
                Content = content
            };

            if (content != null)
            {
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            var client = await GetClient(baseApiVersion);
            var response = client.SendAsync(httpRequest);
            return await ParseHttpResponseV1<T>(response);
        }

        private async Task<T> ParseHttpResponseV1<T>(Task<HttpResponseMessage> taskResponse)
        {
            var response = await taskResponse;
            var responseBody = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(responseBody))
            {
                throw new JsonException("No message to deserialize.");
            }
            return JsonSerializer.Deserialize<T>(responseBody);
        }
        #endregion Private methods for Version 1 API output

        private async Task<string> GetResourceAPIS<T>(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException(nameof(url));
            }

            var token = await GenerateTokens();
            if (token?.Data?.AccessToken == null)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            using var client = new HttpClient { BaseAddress = new Uri(_api_domain) };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Data.AccessToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

            var fullUrl = _api_domain + url;
            var response = await client.GetAsync(fullUrl);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
