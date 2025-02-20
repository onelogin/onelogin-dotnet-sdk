
namespace OneLogin
{
    /// <summary>
    /// This collection of APIs lets you configure OneLogin as an Authorization Server.
    /// The purpose of the Authorization Server is to authenticate a user and return an Access Token for authorizing access to downstream APIs.
    /// These APIs could be self hosted or provided via an API gateway.
    /// </summary>
    public partial class OneLoginClient
    {
        #region Authorization Server
        /// <summary>
        /// Use this API to return a list of authorization servers.
        /// </summary>
        /// <param name="name">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="AuthorizationServersResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<AuthorizationServersResponse>>> ListAuthorizationServers(string? name = null)
        {
            try
            {
                // Create a dictionary to hold parameters
                var parameters = new Dictionary<string, string?>
                    {
                        { "name", name }
                    };

                parameters = parameters.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                var queryString = string.Join("&", parameters
                    .Where(kv => !string.IsNullOrEmpty(kv.Value))
                    .Select(kv => $"{kv.Key}={kv.Value}"));

                var url = $"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

                return await GetResource<List<AuthorizationServersResponse>>(url, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return new ApiResponse<List<AuthorizationServersResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return an API authorization configuration
        /// </summary>
        /// <param name="id">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="AuthorizationServersResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<AuthorizationServersResponse>> GetAuthorizationServer(int id)
        {
            return await GetResource<AuthorizationServersResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{id}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to create an Authorization Server.
        /// Then further configure the Authorization Server to customize Scopes, Claims and Client Apps.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetIdResponse>> CreateAuthorizationServer(AuthorizationServersRequest request)
        {
            return await PostResource<GetIdResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to update an Authorization Server.
        /// </summary>
        /// <param name="id">Set to the id of the user.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateAuthorizationServer(int id, AuthorizationServersRequest request)
        {
            return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{id}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete an Authorization Server.
        /// <param name="id">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveAuthorizationServer(int id)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{id}", Endpoints.BaseApiVersion2);
        }
        #endregion Authorization Server

        #region Client Apps
        /// <summary>
        /// List all of the OpenId Connect client apps that can generate Access Tokens via this Authorization Server.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <returns>Returns the serialized <see cref="ClientAppsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<ClientAppsResponse>>> ListClientApps(int apiAuthId)
        {
            return await GetResource<List<ClientAppsResponse>>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/clients", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Grant access to an OpenId Connect app to generate Access Tokens via the Authorization Server.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="CreateUpdateClientAppsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<CreateUpdateClientAppsResponse>> CreateClientApps(int apiAuthId, CreateClientAppsRequest request)
        {
            return await PostResource<CreateUpdateClientAppsResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/clients", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Update the scopes available to this OpenId Connect client app..
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="clientAppId">The id of the client app.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="CreateUpdateClientAppsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<CreateUpdateClientAppsResponse>> UpdateClientApps(int apiAuthId, int clientAppId, UpdateClientAppsRequest request)
        {
            return await PutResource<CreateUpdateClientAppsResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/clients/{clientAppId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Remove a OpenId Connect client app from being able to generate Access Tokens via the Authorization Server.
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="clientAppId">The id of the client app.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveClientApps(int apiAuthId, int clientAppId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/clients/{clientAppId}", Endpoints.BaseApiVersion2);
        }
        #endregion Client Apps

        #region Scopes
        /// <summary>
        /// Get a list of scopes available on the Authorization Server.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <returns>Returns the serialized <see cref="ScopesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<ScopesResponse>>> ListScopes(int apiAuthId)
        {
            return await GetResource<List<ScopesResponse>>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/scopes", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Add a scope to the Authorization Server..
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetIdResponse>> CreateScopes(int apiAuthId, CreateUpdateScopesRequest request)
        {
            return await PostResource<GetIdResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/scopes", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Update an Authorization Server scope.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="scopeId">The id of the scope.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateScopes(int apiAuthId, int scopeId, CreateUpdateScopesRequest request)
        {
            return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/scopes/{scopeId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Delete a scope from the Authorization Server.
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="scopeId">The id of the scope.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveScopes(int apiAuthId, int scopeId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/scopes/{scopeId}", Endpoints.BaseApiVersion2);
        }
        #endregion Scopes

        #region Claims
        /// <summary>
        /// List all of the custom claims that get returned in Access Tokens generated by the Authorization Server.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <returns>Returns the serialized <see cref="ClaimsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<ClaimsResponse>>> ListClaims(int apiAuthId)
        {
            return await GetResource<List<ClaimsResponse>>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/claims", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Add a custom claim to the Access Tokens that get generated by the Authorization Server.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetIdResponse>> CreateClaims(int apiAuthId, CreateUpdateClaimsRequest request)
        {
            return await PostResource<GetIdResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/claims", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Update the attributes of an Access Token Claim.
        /// </summary>
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="claimId">The id of the claim.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateClaims(int apiAuthId, int claimId, CreateUpdateClaimsRequest request)
        {
            return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/claims/{claimId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Delete a claim from the Access Tokens generated by the Authorization Server.
        /// <param name="apiAuthId">The id of the authorization server.</param>
        /// <param name="claimId">The id of the claim.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveClaims(int apiAuthId, int claimId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APIAUTHORIZATIONS}/{apiAuthId}/claims/{claimId}", Endpoints.BaseApiVersion2);
        }
        #endregion Claims

    }
}
