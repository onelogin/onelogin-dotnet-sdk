namespace OneLogin.Responses
{
    public class GenerateMFATokenResponse
    {
        /// <summary>
        /// A temporary MFA token that can be used to authenticate any app when valid.
        /// </summary>
        [JsonPropertyName("mfa_token")]
        public string MFA_Token { get; set; }

        /// <summary>
        /// Indicates whether the MFA token can be used multiple times until it expires.
        /// If set to false, the token is invalid after a single use or once it expires.
        /// Defaults to false.
        /// </summary>
        [JsonPropertyName("reusable")]
        public bool Reusable { get; set; } = false; // Default to false (one-time use)

        /// <summary>
        /// Defines the expiration time and date for the token in UTC time format.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// A unique identifier for the temporary OTP device that has been created for this token.
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}