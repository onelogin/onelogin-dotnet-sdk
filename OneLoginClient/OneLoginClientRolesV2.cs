namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this call to get a role by ID.
        /// </summary>
        /// <param name="id">Set to the id of the role that you want to return. If you don’t know the role’s  id, use the Get Roles API call to return all roles and their id values.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetRoleResponse>> GetRole(int id)
        {
            return await GetResource<GetRoleResponse>($"{Endpointsv2.ONELOGIN_ROLES}/{id}");
        }

        /// <summary>
        /// This call returns up to 50 roles per page.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<GetRoleResponse>>> ListRoles()
        {
            return await GetResource<List<GetRoleResponse>>($"{Endpointsv2.ONELOGIN_ROLES}");
        }

        /// <summary>
        /// Creates a Role.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<CreateUpdateRoleResponse>> CreateRoles(RoleRequest request)
        {
            try
            {
                return await PostResource<CreateUpdateRoleResponse>(Endpointsv2.ONELOGIN_ROLES, request);
            }
            catch (Exception ex)
            {
                return new ApiResponse<CreateUpdateRoleResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Updates a role. Partial role updates are supported.
        /// </summary>
        /// <param name="roleId">id of the role.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<CreateUpdateRoleResponse>> UpdateRoleById(int roleId, RoleRequest request)
        {
            try
            {
                return await PutResource<CreateUpdateRoleResponse>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}", request);
            }
            catch (Exception ex)
            {
                return new ApiResponse<CreateUpdateRoleResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
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
                return await DeleteResource<EmptyResponse>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}");
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
            return await GetResource<List<GetRoleAppsResponse>>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/apps");
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
                return await PutResource<List<GetIdResponse>>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/apps",request);
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
            return await GetResource<List<GetRoleUsersAdminResponse>>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/users");
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
                return await PostResource<List<GetIdResponse>>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/users", userIds);
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
        public async Task<ApiResponse<EmptyResponse>> DeleteRoleUsers(int roleId,List<int> userIds)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/users", userIds);
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
            var url = $"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/admins";
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?" + queryString; // Append the query string if there are any parameters
            }
            return await GetResource<List<GetRoleUsersAdminResponse>>(url);
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
                return await PostResource<List<GetIdResponse>>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/admins", userIds);
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
        public async Task<ApiResponse<EmptyResponse>> DeleteRoleAdmins(int roleId,List<int> userIds)
        {
            try
            {
                return await DeleteResource<EmptyResponse>($"{Endpointsv2.ONELOGIN_ROLES}/{roleId}/admins", userIds);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
  }
 