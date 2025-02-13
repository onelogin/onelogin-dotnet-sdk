namespace OneLogin
{
    /// <summary>
    /// OneLogin Client for Roles V2
    /// </summary>
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this call to get a role by ID.
        /// </summary>
        /// <param name="id">Set to the id of the role that you want to return. If you don’t know the role’s  id, use the Get Roles API call to return all roles and their id values.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetRoleResponse>> GetRole(int id)
        {
            return await GetResource<GetRoleResponse>($"{Endpoints.ONELOGIN_ROLES}/{id}", Endpoints.BaseApi2);
        }

        /// <summary>
        /// This call returns up to 50 roles per page.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetRoleResponse>>> ListRoles()
        {
            return await GetResource<List<GetRoleResponse>>($"{Endpoints.ONELOGIN_ROLES}", Endpoints.BaseApi2);
        }

        /// <summary>
        /// Creates a Role.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> CreateRoles(RoleRequest request)
        {
            try
            {
                return await PostResource<GetIdResponse>(Endpoints.ONELOGIN_ROLES, request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Updates a role. Partial role updates are supported.
        /// </summary>
        /// <param name="roleId">id of the role.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetIdResponse>> UpdateRoleById(int roleId, RoleRequest request)
        {
            try
            {
                return await PutResource<GetIdResponse>($"{Endpoints.ONELOGIN_ROLES}/{roleId}", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GetIdResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this call to delete a Role by ID.
        /// </summary>
        /// <param name="roleId">Set to the id of the user that you want to log out. </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteRoleById(int roleId)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_ROLES}/{roleId}", Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// This call returns applications assigned to a role.
        /// </summary>
        /// <param name="roleId">Set to the id of the role that you want to return</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetRoleAppsResponse>>> ListRoleApps(int roleId, GetRoleAppsRequest request)
        {
            return await GetResource<List<GetRoleAppsResponse>>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/apps", Endpoints.BaseApi2);
        }

        /// <summary>
        /// This call is used to assign applications to a role.
        /// </summary>
        /// <param name="roleId">Set to the id of the role that you want to return</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetIdResponse>>> SetRoleApps(int roleId, List<int> request)
        {
            try
            {
                return await PutResource<List<GetIdResponse>>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/apps", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<GetIdResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// This call returns a list of users assigned to a specific role and can include users who aren’t currently assigned to the role..
        /// </summary>
        /// <param name="roleId">Set to the id of the role that you want to return</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetRoleUsersAdminResponse>>> ListRoleUsers(int roleId)
        {
            return await GetResource<List<GetRoleUsersAdminResponse>>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/users", Endpoints.BaseApi2);
        }

        /// <summary>
        /// Add users to a role.
        /// </summary>
        /// <param name="roleId">Set to the id of the role that you want to return</param>
        /// <param name="userIds">Set user_id values in array, for example: [123, 456, 678].</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetIdResponse>>> AddRoleUsers(int roleId, List<int> userIds)
        {
            try
            {
                return await PostResource<List<GetIdResponse>>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/users", userIds, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<GetIdResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this call to remove users from a role.
        /// </summary>
        /// <param name="roleId">Set to the id of the user that you want to log out. </param>
        /// <param name="userIds">Set user_id values in array, for example: [123, 456, 678] </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteRoleUsers(int roleId, List<int> userIds)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/users", Endpoints.BaseApi2, userIds);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// This call returns a list of role administrator.
        /// </summary>
        /// <param name="roleId">Set to the id of the role that you want to return</param>
        /// <param name="name">Filters on first name, last name, username, and email address.</param>
        /// <param name="include_unassigned">Optional. Include admins that aren’t assigned to the role</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetRoleUsersAdminResponse>>> ListRoleAdmins(int roleId, string name, bool include_unassigned = false)
        {
            var parameters = new Dictionary<string, string>
                {
                    {"name", name},
                    {"include_unassigned", include_unassigned.ToString().ToLower()}
                }
                .Where(kv => !string.IsNullOrWhiteSpace(kv.Value)) // Remove parameters with empty values
                .Select(kv => $"{kv.Key}={kv.Value}") // Format each parameter as key=value
                .ToList();
            var queryString = string.Join("&", parameters);
            var url = $"{Endpoints.ONELOGIN_ROLES}/{roleId}/admins";
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?" + queryString; // Append the query string if there are any parameters
            }
            return await GetResource<List<GetRoleUsersAdminResponse>>(url, Endpoints.BaseApi2);
        }

        /// <summary>
        /// Add users to a role.
        /// </summary>
        /// <param name="roleId">Set to the id of the role that you want to return</param>
        /// <param name="userIds">Set user_id values in array, for example: [123, 456, 678].</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetIdResponse>>> AddRoleAdmins(int roleId, List<int> userIds)
        {
            try
            {
                return await PostResource<List<GetIdResponse>>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/admins", userIds, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<GetIdResponse>>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this call to remove users from a role.
        /// </summary>
        /// <param name="roleId">Set to the id of the user that you want to log out. </param>
        /// <param name="userIds">Set user_id values in array, for example: [123, 456, 678] </param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> DeleteRoleAdmins(int roleId, List<int> userIds)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_ROLES}/{roleId}/admins", Endpoints.BaseApi2, userIds);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
