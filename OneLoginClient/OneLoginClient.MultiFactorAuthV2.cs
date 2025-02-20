using OneLogin.Responses;
using static System.Net.WebRequestMethods;

namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to return a list of authentication factors that are available for user enrollment via API.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="GetAvailableAuthenticationFactorsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<GetAvailableAuthenticationFactorsResponse>>> GetAvailableAuthenticationFactors(int userId)
        {
            return await GetResource<List<GetAvailableAuthenticationFactorsResponse>>($"{Endpoints.ONELOGIN_MFA}/{userId}/factors", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to enroll a user with a given authentication factor.
        /// If the authentication factor requires confirmation to complete, then the device will have an active state of false otherwise it will have an active state of true (corresponding to devices that are either pending confirmation or not)
        /// To change the active state of the device to true, the OTP device’s id would need to be supplied to the Activate a Factor endpoint.Then the `otp_code` would need to be sent to the Verify a Factor endpoint.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="EnrollAnAuthenticationFactorResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EnrollAnAuthenticationFactorResponse>> EnrollAnAuthenticationFactor(int userId, EnrollAnAuthenticationFactorRequest request)
        {
            return await PostResource<EnrollAnAuthenticationFactorResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/registrations", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to verify enrollment for OneLogin Voice.
        /// At this point, the enrollment of the factor should have already been requested, 
        /// and this API will allow you to verify the user has completed the verification on the required factor. 
        /// The status of the registration should be pending. If the initial registration was completed with verifed = True then this step will not be necessary.
        /// Using this method allows for your service to query the status of the pending registration to determine if the user has verified the factor using the required device. 
        /// This is required to verify OneLogin Voice where the end-user is required to type the OTP code into the phone. 
        /// For OneLogin Protect, you can verify if user has enrolled protect by using the verification_token value to manually register protect within the app.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <param name="registrationid">Set to the uuid of the registration. This was included in the response as part of the initial request in Enroll Factor.</param>
        /// <returns>Returns the serialized <see cref="VerifyFactorMFAResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<VerifyFactorMFAResponse>> VerifyEnrollmentProtectAndVoice(int userId, string registrationid)
        {
            return await GetResource<VerifyFactorMFAResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/registrations/{registrationid}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to verify enrollment for OneLogin SMS, OneLogin Email, OneLogin Protect and Authenticator authentication factors.
        ///At this point, the enrollment of the factor should have already been requested, and this API will allow you to verify the OTP code sent to or generated for the user on the provided factor. The status of the registration should be pending. If the initial registration was completed with veriifed = True then this step will not be necessary.
        ///The API supports enrollment for SMS, Email, Google Authenticator, and OneLogin Protect.Other factors can be enrolled manually by the user.Duo is supported for OTP factors, but registration isn’t supported
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <param name="registrationid">Set to the uuid of the registration. This was included in the response as part of the initial request in Enroll Factor.</param>
        /// <param name="otp"></param>
        /// <returns>Returns the serialized <see cref="VerifyFactorMFAResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<VerifyFactorMFAResponse>> VerifyEnrollmentSMSEMailProtectAuthenticator(int userId, int registrationid, int otp)
        {
            var request = new VerifyEnrollmentRequest { Otp = otp };
            return await PutResource<VerifyFactorMFAResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/registrations/{registrationid}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to return a list of authentication factors registered to a particular user for multifactor authentication (MFA). The list includes devices that are enabled (used successfully for authentication at least once) or pending enablement (registered but never used).
        /// This API is typically used in a login workflow in which MFA is required, providing the user a selection of their registered MFA devices to choose from. The returned list represents the authentication factors that have been registered by the user on their Profile page or on the OneLogin login page or custom login page.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="GetEnrolledAuthenticationFactorResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<GetEnrolledAuthenticationFactorResponse>>> GetEnrolledAuthenticationFactors(int userId)
        {
            return await GetResource<List<GetEnrolledAuthenticationFactorResponse>>($"{Endpoints.ONELOGIN_MFA}/{userId}/devices", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to return a list of authentication factors registered to a particular user for multifactor authentication (MFA). The list includes devices that are enabled (used successfully for authentication at least once) or pending enablement (registered but never used).
        /// This API is typically used in a login workflow in which MFA is required, providing the user a selection of their registered MFA devices to choose from. The returned list represents the authentication factors that have been registered by the user on their Profile page or on the OneLogin login page or custom login page.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="GetEnrolledAuthenticationFactorResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetEnrolledAuthenticationFactorResponse>> ActivateAnAuthenticationFactor(int userId, ActivateAnAuthenticationFactorRequest request)
        {
            return await PostResource<GetEnrolledAuthenticationFactorResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/verifications", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to authenticate a one-time password (OTP) code provided by a multifactor authentication (MFA) device.
        /// Use this endpoint to verify an OTP code provided by SMS, Email, or Authenticator. The verification_id parameter required by the PUT verification method is not required when the HTTP method is POST.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <returns>Returns the serialized <see cref="BaseStatusResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BaseStatusResponse>> VerifySMSEmailAuthenticatorFactorPost(int userId, string deviceId, string otp)
        {
            var request = new VerifySMSEmailAuthenticatorFactorRequest { DeviceId = deviceId, Otp = otp };
            return await PostResource<BaseStatusResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/verifications", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to authenticate a one-time password (OTP) code provided by a multifactor authentication (MFA) device.
        /// Use this endpoint to verify an OTP code provided by SMS, Email, or Authenticator.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <param name="verificationId">The verification_id is returned on activation of the factor or you can get the device_id using the Activate Factor API call.
        /// <param name="deviceId"></param>
        /// <param name="otp"></param>
        /// <returns>Returns the serialized <see cref="BaseStatusResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BaseStatusResponse>> VerifySMSEmailAuthenticatorFactor(int userId, int verificationId, string deviceId, string otp)
        {
            var request = new VerifySMSEmailAuthenticatorFactorRequest { DeviceId = deviceId, Otp = otp };
            return await PutResource<BaseStatusResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/verifications/{verificationId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to verify completion of OneLogin Push or OneLogin Voice factors, or in cases where email is used as an authentication factor via Magic Link rather than OTP.
        /// This API endpoint must be used to confirm if a user has completed their Push or Voice verification or has clicked the emailed Magic Link.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <param name="verificationId">The verification_id is returned on activation of the factor or you can get the device_id.</param>
        /// <returns>Returns the serialized <see cref="VerifyFactorMFAResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<VerifyFactorMFAResponse>> VerifyFactorProtectAndVoice(int userId, int verificationId)
        {
            return await GetResource<VerifyFactorMFAResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/verifications/{verificationId}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use to generate a temporary MFA token that can be used in place of other MFA tokens for a set time period. For example, use this token for account recovery when an MFA device has been lost.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <param name="expiresIn"></param>
        /// <param name="reusable"></param>
        /// <returns>Returns the serialized <see cref="GetEnrolledAuthenticationFactorResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GenerateMFATokenResponse>> GenerateMFAToken(int userId, int expiresIn, bool reusable)
        {
            var request = new GenerateMFATokenRequest { ExpiresIn = expiresIn, Reusable = reusable };
            return await PostResource<GenerateMFATokenResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/mfa_token", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to remove an enrolled factor from a user.
        /// </summary>
        /// <param name="userId">Set to the id of the user.</param>
        /// <param name="deviceId">Set to the device_id of the MFA device.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveAFactor(int userId, int deviceId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_MFA}/{userId}/devices/{deviceId}", Endpoints.BaseApiVersion2);
        }
    }
}
