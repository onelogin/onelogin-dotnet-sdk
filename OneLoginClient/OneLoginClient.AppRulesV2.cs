
namespace OneLogin
{
    /// <summary>
    /// The App Rules API can be used to list, create, update, re-order, and delete mapping rules for a OneLogin application.
    /// App Rules in OneLogin enable you to automate changes to parameters, 
    /// user attributes, and application entitlements based on conditions that you define.For example, 
    /// you might use rules to map roles with their equivalent entitlement in a application that is accessed via SSO.
    /// </summary>
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to return a list of rules that been defined for an application. 
        /// A powerful set of filters can be used to return mappings that contain specific conditions or actions.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<AppRulesResponse>>> ListAppRules(
            long appId,
            string? has_condition = null,
            string? has_condition_type = null,
            string? has_action = null,
            string? has_action_type = null
        )
        {
            try
            {
                // Create a dictionary to hold parameters
                var parameters = new Dictionary<string, string?>
                    {
                        { "has_condition", has_condition },
                        { "has_condition_type", has_condition_type },
                        { "has_action", has_action },
                        { "has_action_type", has_action_type }
                    };

                // Remove any parameters with null values
                parameters = parameters.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                // Build the query string from the parameters
                var queryString = string.Join("&", parameters
                    .Where(kv => !string.IsNullOrEmpty(kv.Value))
                    .Select(kv => $"{kv.Key}={kv.Value}"));

                // Construct the URL with the query string
                var url = $"{Endpoints.ONELOGIN_APPS}/{appId}/rules/{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

                // Make the request to the API
                return await GetResource<List<AppRulesResponse>>(url, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return new ApiResponse<List<AppRulesResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a single app rule configuration.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply.</param>
        /// <param name="id">The id of the app rule to locate.</param>
        /// <returns></returns>
        public async Task<ApiResponse<AppRulesResponse>> GetAppRule(long appId, long id)
        {
            try
            {
                return await GetResource<AppRulesResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/{id}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<AppRulesResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to create an a new App Rule.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> CreateAppRule(long appId, AppRulesRequest request)
        {
            try
            {
                return await PostResource<GetIdResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to update an existing App Rule.
        /// </summary>
        /// <param name="appId">id of the app.</param>
        /// <param name="id">The id of the app rule to locate.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateAppRule(long appId, long id, AppRulesRequest request)
        {
            try
            {
                return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/{id}", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to delete a App Rule.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply. </param>
        /// <param name="id">The id of the app rule to locate.</param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteAppRule(long appId, long id)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/{id}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of the condition types that can be used to match users when app rules are run.
        /// Use the Condition Value when creating or updating App Rules.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply.</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListConditions(long appId)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/conditions", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of possible operators for a given condition value.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply.</param>
        /// <param name="conditionValue">The value for the selected condition</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListConditionOperators(long appId, string? conditionValue)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/conditions/{conditionValue}/operators", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of possible values to compare to a condition type.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply.</param>
        /// <param name="conditionValue">The value for the selected condition</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListConditionValues(long appId, string? conditionValue)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/conditions/{conditionValue}/values", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of the actions that can be applied when an App Rule runs.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply.</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListActions(long appId)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/actions", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of possible values to set using a given action.
        /// </summary>
        /// <param name="appId">The id of the application that where the rules apply.</param>
        /// <param name="actionValue">The value for the selected action. For a complete list of possible action values see List</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListActionValues(long appId, string actionValue)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/actions/{actionValue}/values", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Rules can be reordered individually by setting the position attribute when performing an Update App Rule request.
        /// However if you need to update a lot of rules then this could result in a lot of requests so you should consider using this Bulk Sort endpoint instead.
        /// </summary>
        /// <param name="appId">id of the app.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<long>>> BulkSortAppRules(long appId, List<long> request)
        {
            try
            {
                return await PutResource<List<long>>($"{Endpoints.ONELOGIN_APPS}/{appId}/rules/sort", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<long>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
