
namespace OneLogin
{
    /// <summary>
    /// The User Mappings API can be used to list, create, update, re-order, and delete user mappings.
    /// Mappings in OneLogin enable you to automate changes to user attributes, roles, and groups, based on conditions that you define. 
    /// Typically, you use mappings to grant application access based on user attributes stored in third-party directories.
    /// </summary>
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to return a list of user mappings.
        /// By default this endpoint only returns the mappings that are currently enabled. To return disabled mappings set the enabled query parameter to false
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<UserMappingResponse>>> ListUserMappings(
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
                var url = $"{Endpoints.ONELOGIN_MAPPINGS}/{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

                // Make the request to the API
                return await GetResource<List<UserMappingResponse>>(url, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                // Handle exceptions and return an error response
                return new ApiResponse<List<UserMappingResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a single User Mapping configuration.
        /// </summary>
        /// <param name="id">The id of the user mapping to locate.</param>
        /// <returns></returns>
        public async Task<ApiResponse<UserMappingResponse>> GetUserMapping(long id)
        {
            try
            {
                return await GetResource<UserMappingResponse>($"{Endpoints.ONELOGIN_MAPPINGS}/{id}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<UserMappingResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to create an a new User Mapping.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> CreateUserMapping(UserMappingRequest request)
        {
            try
            {
                return await PostResource<GetIdResponse>($"{Endpoints.ONELOGIN_MAPPINGS}", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to create an a new User Mapping.
        /// </summary>
        /// <param name="id">The id of the user mapping to locate.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<UserMappingDryRunResponse>>> DryRunUserMapping(long id,List<int> request)
        {
            try
            {
                return await PostResource<List<UserMappingDryRunResponse>>($"{Endpoints.ONELOGIN_MAPPINGS}/{id}/dryrun", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<UserMappingDryRunResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to update an existing User Mapping.
        /// </summary>
        /// <param name="id">The id of the user mapping to locate.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateUserMapping(long id, UserMappingRequest request)
        {
            try
            {
                return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_MAPPINGS}/{id}", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to delete a User Mapping.
        /// </summary>
        /// <param name="id">The id of the user mapping to locate.</param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteUserMapping(long id)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_MAPPINGS}/{id}", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of the condition types that can be used to match users when mappings are run.
        /// Use the Condition Value when creating or updating User Mappings.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListUserMappingConditions()
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_MAPPINGS}/conditions", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of possible operators for a given condition value.
        /// </summary>
        /// <param name="conditionValue">The value for the selected condition</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListUserMappingConditionOperators(string? conditionValue)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_MAPPINGS}/conditions/{conditionValue}/operators", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of possible values to compare to a condition type.
        /// </summary>
        /// <param name="conditionValue">The value for the selected condition</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListUserMappingConditionValues(string? conditionValue)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_MAPPINGS}/conditions/{conditionValue}/values", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of the actions that can be applied when a mapping runs.
        /// Use the Action Value when creating or updating User Mappings.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListUserMappingActions(long appId)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_MAPPINGS}/actions", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to return a list of possible values to set using a given action.
        /// </summary>
        /// <param name="actionValue">The value for the selected action. For a complete list of possible action values see List</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<NameValueResponse>>> ListUserMappingActionValues( string actionValue)
        {
            try
            {
                return await GetResource<List<NameValueResponse>>($"{Endpoints.ONELOGIN_MAPPINGS}/actions/{actionValue}/values", Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<NameValueResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Mappings can be reordered individually by setting the position attribute when performing an Update Mapping request.
        /// However if you need to update a lot of mappings then this could result in a lot of requests so you should consider using this Bulk Sort endpoint instead.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<long>>> BulkSortUserMappings(List<long> request)
        {
            try
            {
                return await PutResource<List<long>>($"{Endpoints.ONELOGIN_MAPPINGS}/sort", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<long>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
