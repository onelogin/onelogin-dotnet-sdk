
namespace OneLogin
{
    /// <summary>
    /// OneLogin Client for Privileges V1
    /// </summary>
    public partial class OneLoginClient
    {
        #region Privileges
        /// <summary>
        /// Use this API to list the Privileges created in an account..
        /// </summary>
        /// <returns>Returns the serialized <see cref="PrivilegeResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<PrivilegeResponse>>> ListPrivileges()
        {
            return await GetResource<List<PrivilegeResponse>>($"{Endpoints.ONELOGIN_PRIVILEGES}", Endpoints.BaseApiVersion1);
        }

        /// <summary>
        /// Use this API to return a single privilege.
        /// </summary>
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <returns></returns>
        public async Task<ApiResponse<PrivilegeResponse>> GetPrivileges(string privilegeId)
        {
            return await GetResource<PrivilegeResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}", Endpoints.BaseApiVersion1);

        }

        /// <summary>
        /// Use this API to create a new privilege object.
        /// A privilege defines a set of actions that can be performed on particular resources in OneLogin.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetStringIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetStringIdResponse>> CreatePrivileges(PrivilegeRequest request)
        {
            return await PostResource<GetStringIdResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}", request, Endpoints.BaseApiVersion1);
        }

        /// <summary>
        /// Use this API to update an existing privilege object.
        /// </summary>
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetStringIdResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetStringIdResponse>> UpdatePrivileges(string privilegeId, PrivilegeRequest request)
        {
            return await PutResource<GetStringIdResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}", request, Endpoints.BaseApiVersion1);
        }

        /// <summary>
        /// Use this API to delete a single privilege.
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemovePrivileges(string privilegeId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}", Endpoints.BaseApiVersion1);
        }
        #endregion Privileges

        #region Roles Privileges

        /// <summary>
        /// Use this API to list the roles assigned to a privilege.
        /// </summary>
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <returns></returns>
        public async Task<ApiResponse<PrivilegeRoleResponse>> GetPrivilegesRoles(string privilegeId)
        {
            return await GetResource<PrivilegeRoleResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}/roles", Endpoints.BaseApiVersion1);

        }

        /// <summary>
        /// Use this API to assign a privilege to one or more roles.
        /// </summary>
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="SuccessResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SuccessResponse>> CreatePrivilegesRoles(string privilegeId, PrivilegeRoleRequest request)
        {
            return await PostResource<SuccessResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}/roles", request, Endpoints.BaseApiVersion1);
        }

        /// <summary>
        /// Use this API to remove a single role from a privilege.
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <param name="roleId">Set to the id of the role you want to remove.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemovePrivilegesRoles(string privilegeId,long roleId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}/roles/{roleId}", Endpoints.BaseApiVersion1);
        }
        #endregion Roles Privileges

        #region Users Privileges

        /// <summary>
        /// Use this API to list the users assigned to a privilege.
        /// </summary>
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <returns></returns>
        public async Task<ApiResponse<PrivilegeUserResponse>> GetPrivilegesUsers(string privilegeId)
        {
            return await GetResource<PrivilegeUserResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}/users", Endpoints.BaseApiVersion1);

        }

        /// <summary>
        /// Use this API to assign a privilege to one or more roles.
        /// </summary>
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="SuccessResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SuccessResponse>> CreatePrivilegesUsers(string privilegeId, PrivilegeUserRequest request)
        {
            return await PostResource<SuccessResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}/users", request, Endpoints.BaseApiVersion1);
        }

        /// <summary>
        /// Use this API to remove a single role from a privilege.
        /// <param name="privilegeId">Set to the id of the privilege you want to retrieve..</param>
        /// <param name="userId">Set to the id of the user you want to remove.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemovePrivilegesUsers(string privilegeId, long userId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_PRIVILEGES}/{privilegeId}/users/{userId}", Endpoints.BaseApiVersion1);
        }
        #endregion Roles Privileges

    }
}
