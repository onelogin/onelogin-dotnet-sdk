namespace OneLogin.Responses
{
    public class SmartMFAResponse
    {
        /// <summary>
        /// A unique identifier assigned to the user by OneLogin.
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// The risk level associated with the user for the request.
        /// </summary>
        [JsonPropertyName("risk")]
        public RiskDetails Risk { get; set; }

        /// <summary>
        /// Multi-factor authentication (MFA) details, indicating if a token has been sent and the state token for verification.
        /// </summary>
        [JsonPropertyName("mfa")]
        public MfaDetails Mfa { get; set; }
    }
    public class RiskDetails
    {
        /// <summary>
        /// A risk score ranging from 0 (low risk) to 100 (high risk), indicating the level of risk for the request.
        /// </summary>
        [JsonPropertyName("score")]
        public int Score { get; set; }

        /// <summary>
        /// A list of reasons that explain why the risk score was determined as it is.
        /// </summary>
        [JsonPropertyName("reasons")]
        public List<string> Reasons { get; set; }
    }

    public class MfaDetails
    {
        /// <summary>
        /// A boolean indicating whether a one-time passcode (OTP) has been sent for multi-factor authentication.
        /// </summary>
        [JsonPropertyName("otp_sent")]
        public bool OtpSent { get; set; }

        /// <summary>
        /// A state token that can be used in a subsequent API call to verify the OTP token.
        /// This is required when an OTP has been sent.
        /// </summary>
        [JsonPropertyName("state_token")]
        public string StateToken { get; set; }
    }
}