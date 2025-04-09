namespace OneLogin.Requests
{
    public class VerifyMFATokenRequest
    {
        /// <summary>
        /// The state token that is used for verifying the OTP in the next step of the verification process.
        /// This state token is received when the OTP is initially sent.
        /// </summary>
        [JsonPropertyName("state_token")]
        public required string StateToken { get; set; }

        /// <summary>
        /// The one-time passcode (OTP) sent to the user for multi-factor authentication.
        /// This token is provided by the user to verify the authentication process.
        /// </summary>
        [JsonPropertyName("otp_token")]
        public required string OtpToken { get; set; }
    }
}