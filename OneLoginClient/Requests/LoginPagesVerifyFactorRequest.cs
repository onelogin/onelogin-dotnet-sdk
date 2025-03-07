namespace OneLogin.Requests
{
    public class LoginPagesVerifyFactorRequest
    {
        /// <summary>
        /// Provide the MFA device_id you are submitting for verification. The device_id is supplied by the Create Session Login Token API
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Provide the state_token associated with the MFA device_id you are submitting for verification. 
        /// The state_token is supplied by the Create Session Login Token API. 
        /// </summary>
        [JsonPropertyName("state_token")]
        public string StateToken { get; set; }

        /// <summary>
        /// Provide the OTP value for the MFA factor you are submitting for verification.
        /// </summary>
        [JsonPropertyName("otp_token")]
        public string? OtpToken { get; set; }

        /// <summary>
        /// When verifying MFA via Protect Push, set this to true to stop additional push notifications being sent to the OneLogin Protect device.
        /// </summary>
        [JsonPropertyName("do_not_notify")]
        public bool DoNotNotify { get; set; }
    }
}