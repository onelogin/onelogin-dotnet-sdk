
namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to generate a session login token in scenarios in which MFA may or may not be required. Both scenarios are supported. 
        /// A session login token expires two minutes after creation
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<LoginPagesCreateSessionResponse> CreateSessionLoginToken(LoginPagesCreateSessionRequest request)
        {
            return await PostResourceV1<LoginPagesCreateSessionResponse>($"{Endpoints.ONELOGIN_LOGINPAGES}/auth", request, Endpoints.BaseApiVersion1);
        }

        /// <summary>
        /// Verify a one-time password (OTP) value, provided for a second factor, when multi-factor authentication (MFA) is required.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<LoginPagesVerifyFactorResponse> VerifyLoginFactor(LoginPagesVerifyFactorRequest request)
        {
            return await PostResourceV1<LoginPagesVerifyFactorResponse>($"{Endpoints.ONELOGIN_LOGINPAGES}/verify_factor", request, Endpoints.BaseApiVersion1);
        }


    }
}
