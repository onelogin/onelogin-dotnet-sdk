namespace OneLogin.Request
{
    public class VerifyFactorRequest
    {
        /// <summary>
        /// The App ID of the app for which you want to generate a SAML token. 
        /// This is the app ID in OneLogin.
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// The MFA device_id you are submitting for verification. 
        /// The device_id is supplied by the Generate SAML Assertion API.
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// The state_token associated with the MFA device_id you are submitting for verification. 
        /// The state_token is supplied by the Generate SAML Assertion API.
        /// </summary>
        [JsonPropertyName("state_token")]
        public string StateToken { get; set; }

        /// <summary>
        /// The OTP (One-Time Password) value for the MFA factor you are submitting for verification.
        /// For some MFA factors (e.g., OneLogin OTP SMS), the OTP is provided by the user separately.
        /// If not included, a 200 OK - Pending result is returned, and a subsequent call is needed with the OTP value.
        /// In the case of other MFA factors (e.g., Google Authenticator, Yubikey), the OTP value is required immediately.
        /// </summary>
        [JsonPropertyName("otp_token")]
        public string? OtpToken { get; set; }

        /// <summary>
        /// When verifying MFA via Protect Push, set this to true to stop additional push notifications 
        /// being sent to the OneLogin Protect device.
        /// Set to false in the first request to trigger a notification requesting MFA. 
        /// In subsequent requests, set this to true while polling for the user’s approve/deny response.
        /// </summary>
        [JsonPropertyName("do_not_notify")]
        public bool DoNotNotify { get; set; }
    }
}