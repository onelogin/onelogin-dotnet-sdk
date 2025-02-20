namespace OneLogin.Requests
{
    public class GenerateMFATokenRequest
    {
        /// <summary>
        /// The duration of the token in seconds.
        /// Token expiration defaults to 259200 seconds (72 hours). 72 hours is the maximum value.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; } = 259200; // Default to 259200 seconds (72 hours)

        /// <summary>
        /// Defines whether the token is reusable multiple times within the expiry window.
        /// The default value is false. If set to true, the token can be used multiple times until it expires.
        /// </summary>
        [JsonPropertyName("reusable")]
        public bool Reusable { get; set; } = false; // Default to false
    }
}