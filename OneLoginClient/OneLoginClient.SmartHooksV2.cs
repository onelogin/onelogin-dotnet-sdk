
namespace OneLogin
{
    /// <summary>
    /// Smart Hooks offers a new way to extend OneLogin in ways never possible before. 
    /// From creating conditional access login flows to augmenting user lifecycle events we can’t wait to see what you build.
    /// </summary>
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to return a list of all Smart Hooks that have been created in a OneLogin account.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<SmartHooksResponse>>> ListHooks()
        {
            return await GetResource<List<SmartHooksResponse>>($"{Endpoints.ONELOGIN_SMARTHOOKS}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to get back the configuration object for a given hook.
        /// </summary>
        /// <param name="hookId">Set to the id of the Hook that you want to return.</param>
        /// <returns>Returns the serialized <see cref="SmartHooksResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SmartHooksResponse>> GetAHook(string hookId)
        {
            return await GetResource<SmartHooksResponse>($"{Endpoints.ONELOGIN_SMARTHOOKS}/{hookId}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to get back the execution output logs for a given hook.
        /// </summary>
        /// <param name="hookId">Set to the id of the Hook that you want to return.</param>
        /// <returns>Returns the serialized <see cref="SmartHooksLogsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<SmartHooksLogsResponse>>> GetHookLogs(string hookId)
        {
            return await GetResource<List<SmartHooksLogsResponse>>($"{Endpoints.ONELOGIN_SMARTHOOKS}/{hookId}/logs", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to create a Hook function to extend a OneLogin workflow..
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="SmartHooksResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SmartHooksResponse>> CreateAHook(SmartHooksRequest request)
        {
            return await PostResource<SmartHooksResponse>($"{Endpoints.ONELOGIN_SMARTHOOKS}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to update a Hook function.
        /// </summary>
        /// <param name="hookId">The ID of the rule to retrieve.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="SmartHooksResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SmartHooksResponse>> UpdateAHook(string hookId, SmartHooksRequest request)
        {
            return await PutResource<SmartHooksResponse>($"{Endpoints.ONELOGIN_SMARTHOOKS}/{hookId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete a Hook function.
        /// <param name="hookId">The ID of the rule to retrieve.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveAHook(string hookId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_SMARTHOOKS}/{hookId}", Endpoints.BaseApiVersion2);
        }

        #region Environment variables
        /// <summary>
        /// Use this API to return a list of all Hook Environment Variables that have been defined in a OneLogin account.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<List<SmartHooksEnvironmentVariableResponse>>> ListEnvironmentVariables()
        {
            return await GetResource<List<SmartHooksEnvironmentVariableResponse>>($"{Endpoints.ONELOGIN_SMARTHOOKSENVS}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to return a single Smart Hook Environment Variable.
        /// </summary>
        /// <param name="envId">Set to the id of the Hook Environment Variable that you want to fetch.</param>
        /// <returns>Returns the serialized <see cref="SmartHooksEnvironmentVariableResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SmartHooksEnvironmentVariableResponse>> GetEnvironmentVariable(string envId)
        {
            return await GetResource<SmartHooksEnvironmentVariableResponse>($"{Endpoints.ONELOGIN_SMARTHOOKSENVS}/{envId}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to create a new Hook Environment Variable and define its value.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="SmartHooksEnvironmentVariableResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SmartHooksEnvironmentVariableResponse>> CreateEnvironmentVariables(EnvironmentVariable request)
        {
            return await PostResource<SmartHooksEnvironmentVariableResponse>($"{Endpoints.ONELOGIN_SMARTHOOKSENVS}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to update an existing Hook Environment Variable and define its value.
        /// </summary>
        /// <param name="envId">The ID of the rule to retrieve.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="SmartHooksEnvironmentVariableResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<SmartHooksEnvironmentVariableResponse>> UpdateEnvironmentVariables(string envId, EnvironmentVariableValue request)
        {
            return await PutResource<SmartHooksEnvironmentVariableResponse>($"{Endpoints.ONELOGIN_SMARTHOOKSENVS}/{envId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete a Hook Environment Variable.
        /// <param name="envId">The ID of the rule to retrieve.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveEnvironmentVariables(string envId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_SMARTHOOKSENVS}/{envId}", Endpoints.BaseApiVersion2);
        }
        #endregion Environment variables
    }
}
