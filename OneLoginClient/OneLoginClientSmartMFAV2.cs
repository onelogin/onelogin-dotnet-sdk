
using System.Diagnostics.Metrics;

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
        public async Task<ApiResponse<GenerateSAMLAssertionResponse>> ValidateUserViaSms(GenerateSAMLAssertionRequest request)
        {
            try
            {
                return await PostResource<GenerateSAMLAssertionResponse>($"{Endpoints.ONELOGIN_SMARTMFA}", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GenerateSAMLAssertionResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
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
        public async Task<ApiResponse<VerifyFactorResponse>> ValidateUserViaEmail(VerifyFactorRequest request)
        {
            try
            {
                return await PostResource<VerifyFactorResponse>($"{Endpoints.ONELOGIN_SMARTMFA}", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<VerifyFactorResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Verify a one-time password (OTP) value, provided for a second factor, when multi-factor authentication (MFA) is required for SAML authentication.
        /// This API is used in close conjunction with the Generate SAML Assertion API when MFA is required
        /// https://developers.onelogin.com/api-docs/2/saml-assertions/verify-factor
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<VerifyFactorResponse>> VerifyToken(VerifyFactorRequest request)
        {
            try
            {
                return await PostResource<VerifyFactorResponse>($"{Endpoints.ONELOGIN_SMARTMFA}/verify", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<VerifyFactorResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
