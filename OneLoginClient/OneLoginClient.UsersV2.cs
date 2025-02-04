namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Get all of the users registered with Onelogin filtered by the given parameters.
        /// https://developers.onelogin.com/api-docs/2/users/List-users
        /// </summary>
        /// <returns>Returns the serialized<see cref = "GetUserResponse" /> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<GetUserResponse>>> ListUsers(
            string? directoryId = null,
            string? email = null,
            string? externalId = null,
            string? firstName = null,
            string? lastName = null,
            int? roleId = null,
            string? samAccountName = null,
            DateTime? since = null,
            DateTime? until = null,
            string? userName = null,
            string? userPrincipalName = null,
            string? appId = null,
            string? userIds = null, // Comma-separated list of OneLogin User IDs
            Dictionary<string, string>? customAttributes = null, // custom attributes as a dictionary
            string? fields = null // Comma-separated list of user attributes to return
        )
        {
            try
            {
                var parameters = new Dictionary<string, string?>
                    {
                        { "directory_id", directoryId },
                        { "email", email },
                        { "external_id", externalId },
                        { "app_id", appId },
                        { "firstname", firstName },
                        { "lastname", lastName },
                        { "role_id", roleId?.ToString() },
                        { "samaccountname", samAccountName },
                        { "created_since", since?.ToString("o") },  // Use "o" format specifier for DateTime (ISO 8601)
                        { "updated_since", since?.ToString("o") },
                        { "created_until", until?.ToString("o") },
                        { "updated_until", until?.ToString("o") },
                        { "last_login_until", until?.ToString("o") },
                        { "last_login_since", since?.ToString("o") },  // Corrected to `since` for consistency
                        { "username", userName },
                        { "userprincipalname", userPrincipalName },
                        { "user_ids", userIds },  // Comma-separated list of user IDs
                        { "fields", fields }  // Comma-separated list of user attributes to return
                    };

                if (customAttributes != null)
                {
                    foreach (var attribute in customAttributes)
                    {
                        parameters[$"custom_attributes.{attribute.Key}"] = attribute.Value;
                    }
                }

                parameters = parameters.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                var queryString = string.Join("&", parameters
                    .Where(kv => !string.IsNullOrEmpty(kv.Value))
                    .Select(kv => $"{kv.Key}={kv.Value}"));

                var url = $"{Endpointsv2.ONELOGIN_USERS}{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

                return await GetResource<List<GetUserResponse>>(url);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<GetUserResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Get the Onelogin user.
        /// </summary>
        /// <param name = "userId" > the id of the user that you want to return.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetUserResponse>> GetUserById(int userId)
        {
            try
            {
                return await GetResource<GetUserResponse>($"{Endpointsv2.ONELOGIN_USERS}/{userId}");
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetUserResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Get a list of apps accessible by a user, not including personal apps.
        /// https://developers.onelogin.com/api-docs/2/users/get-apps-for-user
        /// </summary>
        /// <param name = "userId" > Set to the id of the user that you want to return.</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetUserAppsResponse>>> GetUserApps(int userId)
        {
            try
            {
                return await GetResource<List<GetUserAppsResponse>>($"{Endpointsv2.ONELOGIN_USERS}/{userId}/apps");
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<GetUserAppsResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Creates a onelogin user account.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetUserResponse>> CreateUser(CreateUserRequest request)
        {
            try
            {
                return await PostResource<GetUserResponse>(Endpointsv2.ONELOGIN_USERS, request);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetUserResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Updates a onelogin user account.
        /// </summary>
        /// <param name="userId">Set to the id of the user which you want to update.</param>
        /// <param name="byIdRequest">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetUserResponse>> UpdateUserById(int userId, UpdateUserByIdRequest byIdRequest)
        {
            try
            {
                return await PutResource<GetUserResponse>($"{Endpointsv2.ONELOGIN_USERS}/{userId}", byIdRequest);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetUserResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this call to delete a user by ID.
        /// </summary>
        /// <param name="userId">Set to the id of the user that you want to log out. </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteUserById(int userId)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpointsv2.ONELOGIN_USERS}/{userId}");
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Returns a list of all custom attribute fields(also known as custom user fields) that have been defined for your account.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetCustomAttributesResponse>>> ListCustomAttributes()
        {
            try
            {
                return await GetResource<List<GetCustomAttributesResponse>>($"{Endpointsv2.ONELOGIN_USERS}/custom_attributes");
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<GetCustomAttributesResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Returns a list of all custom attribute fields (also known as custom user fields) that have been defined for your account.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<GetCustomAttributesResponse>> GetCustomAttribute(int id)
        {
            try
            {
                return await GetResource<GetCustomAttributesResponse>($"{Endpointsv2.ONELOGIN_USERS}/custom_attributes/{id}");
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetCustomAttributesResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Creates a new custom attribute in OneLogin.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetCustomAttributesResponse>> CreateCustomAttribute(CreateCustomAttributesRequest request)
        {
            try
            {
                return await PostResource<GetCustomAttributesResponse>($"{Endpointsv2.ONELOGIN_USERS}/custom_attributes", request);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetCustomAttributesResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// update a custom attribute in OneLogin.
        /// </summary>
        /// <param name="id">Set to the id of the user for whom you want to set custom attribute values. If you don’t know the user’s id, use the Get Users API call to return all users and their id values.</param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ApiResponse<GetCustomAttributesResponse>> UpdateCustomAttributeValue(int id, CreateCustomAttributesRequest request)
        {
            try
            {
                return await PutResource<GetCustomAttributesResponse>($"{Endpointsv2.ONELOGIN_USERS}/custom_attributes/{id}", request);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetCustomAttributesResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this call to delete a Custom attribute by ID.
        /// </summary>
        /// <param name="id">Set to the id of the attribute that you want to delete </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteCustomAttributeById(int id)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpointsv2.ONELOGIN_USERS}/custom_attributes/{id}");
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
