
namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to validate a users risk and send an MFA token via Email or SMS when the risk is above an acceptable threshold.
        ///This API takes care of registering new users as well as validating returning users.
        ///It is recommended that you use this flow immediately after you have succesfully authenticated a users password but before you create a session and let them into your application.
        /// https://developers.onelogin.com/api-docs/2/smart-mfa/validate-user
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<SmartMFAResponse>> ValidateUserViaSms(SmartMFARequest request)
        {
            try
            {
                return await PostResource<SmartMFAResponse>($"{Endpoints.ONELOGIN_SMARTMFA}", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<SmartMFAResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to validate a users risk and send an MFA token via Email or SMS when the risk is above an acceptable threshold.
        ///This API takes care of registering new users as well as validating returning users.
        ///It is recommended that you use this flow immediately after you have succesfully authenticated a users password but before you create a session and let them into your application.
        /// https://developers.onelogin.com/api-docs/2/smart-mfa/validate-user
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<SmartMFAResponse>> ValidateUserViaEmail(SmartMFAEmailRequest request)
        {
            try
            {
                return await PostResource<SmartMFAResponse>($"{Endpoints.ONELOGIN_SMARTMFA}", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<SmartMFAResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to verify a MFA token that has been sent to a user as a result of the Validate a User request
        /// https://developers.onelogin.com/api-docs/2/smart-mfa/verify-token
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<EmptyResponse>> VerifyToken(VerifyMFATokenRequest request)
        {
            try
            {
                return await PostResource<EmptyResponse>($"{Endpoints.ONELOGIN_SMARTMFA}/verify", request, Endpoints.BaseApiVersion2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<EmptyResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
