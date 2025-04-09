
namespace OneLogin
{
    /// <summary>
    /// OneLogin Client for Vigilance AI V2
    /// </summary>
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to train Vigilance AI and help it improve the accuracy of contextual risk scores.
        /// For example you can send user, browser, and device information when a successful login event has occurred. Vigilance AI will build up a profile of typical behavior for this type event for each user.
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> TrackEvent(VigilanceAIEventsRequest request)
        {
            try
            {
                return await PostResource<EmptyResponse>($"{Endpoints.ONELOGIN_VIGILANCEAI}/events", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to get a real-time risk score for a user before completing a critical task or action.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<VigilanceGetRiskScoreResponse>> GetRiskScore(VigilanceAIEventsRequest request)
        {
            try
            {
                return await PostResource<VigilanceGetRiskScoreResponse>($"{Endpoints.ONELOGIN_VIGILANCEAI}/verify", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<VigilanceGetRiskScoreResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to get a count of log-in events grouped by their risk score bucket. 
        /// You can use the results of this API to determine the risk level of the majority of users which can be useful when deciding the Smart Factor risk level to set.
        /// </summary>
        /// <param name="before">Optional ISO8601 formatted date string. Defaults to current date. Maximum date is 90 days ago.</param>
        /// <param name="after">Optional ISO8601 formatted date string. Defaults to 30 days ago. Maximum date is 90 days ago.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetScoreInsightsResponse>> GetScoreInsights(string? before=null, string? after=null)
        {
            var parameters = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(before))
            {
                parameters.Add("before", before);
            }
            if (!string.IsNullOrWhiteSpace(after))
            {
                parameters.Add("after", after);
            }
            var queryString = string.Join("&", parameters.Select(kv => $"{kv.Key}={kv.Value}"));
            var url = $"{Endpoints.ONELOGIN_VIGILANCEAI}/scores";
            if (!string.IsNullOrEmpty(queryString))
            {
                url += "?" + queryString; // Append the query string if there are any parameters
            }
            return await GetResource<GetScoreInsightsResponse>(url, Endpoints.BaseApiVersion2);
        }

        #region Rules
        /// <summary>
        /// Use this API to return all of the rules that have been created in the Risk Sevice.
        /// </summary>
        /// <returns>Returns the serialized <see cref="VigilanceAIRulesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<VigilanceAIRulesResponse>>> ListVigilanceAIRules()
        {
            return await GetResource<List<VigilanceAIRulesResponse>>($"{Endpoints.ONELOGIN_VIGILANCEAI_RULES}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Create a custom rule to gain more control over the risk scoring of events.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="VigilanceAIRulesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<VigilanceAIRulesResponse>> CreateVigilanceAIRules(VigilanceAIRulesRequest request)
        {
            return await PostResource<VigilanceAIRulesResponse>($"{Endpoints.ONELOGIN_VIGILANCEAI_RULES}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to perform a full or partial update on a rule that has been created in the Risk Sevice.
        /// </summary>
        /// <param name="rulesId">The ID of the rule to retrieve.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="VigilanceAIRulesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<VigilanceAIRulesResponse>> UpdateVigilanceAIRules(long rulesId, VigilanceAIRulesRequest request)
        {
            return await PutResource<VigilanceAIRulesResponse>($"{Endpoints.ONELOGIN_VIGILANCEAI_RULES}/{rulesId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete a single rule that has been created in the Vigilance AI service.
        /// <param name="rulesId">The ID of the rule to retrieve.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveVigilanceAIRules(long rulesId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_VIGILANCEAI_RULES}/{rulesId}", Endpoints.BaseApiVersion2);
        }
        #endregion Rules

    }
}
