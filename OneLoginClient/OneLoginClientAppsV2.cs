
namespace OneLogin
{
    /// <summary>
    /// The Apps API can be used to list, create, update and manage apps.
    /// Often this set of APIs is used to backup the configuration of an app so that changes can be restored to a previous state.
    /// It’s also common to use this API in a DevOps scenario where you might update an app configuration on a sandbox account before applying it to a production account
    /// </summary>
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to return a list of connectors.
        /// Connectors are used as a template for creating apps in a OneLogin account.
        /// https://developers.onelogin.com/api-docs/2/connectors/list-connectors
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<ConnectorResponse>>> ListConnectors(
            string? name = null,
            int? authMethod = null,
            int? limit = null
        )
        {
            try
            {
                // Create a dictionary to hold parameters
                var parameters = new Dictionary<string, string?>
                    {
                        { "name", name },
                        { "auth_method", authMethod?.ToString() },
                        { "limit", limit?.ToString() }
                    };

                // Remove any parameters with null values
                parameters = parameters.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                // Build the query string from the parameters
                var queryString = string.Join("&", parameters
                    .Where(kv => !string.IsNullOrEmpty(kv.Value))
                    .Select(kv => $"{kv.Key}={kv.Value}"));

                // Construct the URL with the query string
                var url = $"{Endpoints.ONELOGIN_CONNECTORS}{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

                // Make the request to the API
                return await GetResource<List<ConnectorResponse>>(url, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return new ApiResponse<List<ConnectorResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of all Apps in a OneLogin account.
        /// https://developers.onelogin.com/api-docs/2/apps/list-apps
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<ListAppResponse>>> ListApps(
            string? name = null,
            int? authMethod = null,
            int? connector_id = null,
            int? limit = null
        )
        {
            try
            {
                // Create a dictionary to hold parameters
                var parameters = new Dictionary<string, string?>
                    {
                        { "name", name },
                        { "auth_method", authMethod?.ToString() },
                        { "connector_id", connector_id?.ToString() },
                        { "limit", limit?.ToString() }
                    };

                // Remove any parameters with null values
                parameters = parameters.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                // Build the query string from the parameters
                var queryString = string.Join("&", parameters
                    .Where(kv => !string.IsNullOrEmpty(kv.Value))
                    .Select(kv => $"{kv.Key}={kv.Value}"));

                // Construct the URL with the query string
                var url = $"{Endpoints.ONELOGIN_APPS}{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

                // Make the request to the API
                return await GetResource<List<ListAppResponse>>(url, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return new ApiResponse<List<ListAppResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to get the configuration settings of an app. This is useful for backing up app configuration or cloning apps..
        /// https://developers.onelogin.com/api-docs/2/apps/get-app
        /// </summary>
        /// <param name="appId">id of the app.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetAppResponse>> GetApp(int appId)
        {
            try
            {
                return await GetResource<GetAppResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetAppResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of users that are assigned to an App.
        /// https://developers.onelogin.com/api-docs/2/apps/list-users
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<GetAppResponse>> ListAppUsers(int appId)
        {
            try
            {
                return await GetResource<GetAppResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}/users", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetAppResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Create a new app based off a OneLogin connector
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> CreateApp(GetAppResponse request)
        {
            try
            {
                return await PostResource<GetIdResponse>(Endpoints.ONELOGIN_APPS, request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Updates attributes and add parameters to an existing app.
        /// </summary>
        /// <param name="appId">id of the app.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateApp(int appId, GetAppResponse request)
        {
            try
            {
                return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this call to delete an app.
        /// </summary>
        /// <param name="appId">Set to the id of the app that you want to update </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteApp(int appId)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to delete a custom parameter from an app.
        ///Note that you can not delete a parameter that is defined on the apps underlying connector.
        /// </summary>
        /// <param name="appId">Set to the id of the app that you want to update </param>
        /// <param name="parameter_id">Set to the id of the parameter that you want to delete </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteAppParameter(int appId, int parameter_id)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}/parameters/{parameter_id}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
