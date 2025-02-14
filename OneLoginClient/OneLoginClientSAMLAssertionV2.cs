
using OneLogin.Request;
using OneLogin.Response;

namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to generate a SAML assertion.
        /// If multi-factor authentication(MFA) is enabled, 
        /// this API works in close conjunction with the Verify Factor API to provide and verify the second factor.
        /// https://developers.onelogin.com/api-docs/2/saml-assertions/generate-saml-assertion
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GenerateSAMLAssertionResponse>> GenerateSAMLAssertion(GenerateSAMLAssertionRequest request)
        {
            try
            {
                return await PostResource<GenerateSAMLAssertionResponse>($"{Endpoints.ONELOGIN_SAMLASSERTIONS}", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<GenerateSAMLAssertionResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Verify a one-time password (OTP) value, provided for a second factor, when multi-factor authentication (MFA) is required for SAML authentication.
        /// This API is used in close conjunction with the Generate SAML Assertion API when MFA is required
        /// https://developers.onelogin.com/api-docs/2/saml-assertions/verify-factor
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<VerifyFactorResponse>> VerifyFactor(VerifyFactorRequest request)
        {
            try
            {
                return await PostResource<VerifyFactorResponse>($"{Endpoints.ONELOGIN_SAMLASSERTIONS}/verify_factor", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<VerifyFactorResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
