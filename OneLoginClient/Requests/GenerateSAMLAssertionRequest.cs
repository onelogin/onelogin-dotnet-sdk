namespace OneLogin.Requests
{
    public class GenerateSAMLAssertionRequest
    {
        /// <summary>
        /// The username or email of the OneLogin user accessing the app for which you want to generate a SAML token.
        /// </summary>
        [JsonPropertyName("username_or_email")]
        public required string UsernameOrEmail { get; set; }

        /// <summary>
        /// The password of the OneLogin user accessing the app for which you want to generate a SAML token.
        /// </summary>
        [JsonPropertyName("password")]
        public required string Password { get; set; }

        /// <summary>
        /// The App ID of the app for which you want to generate a SAML token. This is the app ID in OneLogin.
        /// </summary>
        [JsonPropertyName("app_id")]
        public required long AppId { get; set; }

        /// <summary>
        /// The subdomain of the OneLogin user accessing the app for which you want to generate a SAML token.
        /// For example, if your OneLogin URL is splinkly.onelogin.com, enter splinkly as the subdomain value.
        /// </summary>
        [JsonPropertyName("subdomain")]
        public required string Subdomain { get; set; }

        /// <summary>
        /// The IP address of the user accessing the application. Used to determine if MFA is required or should be bypassed.
        /// This is optional and should be passed in if IP allow-listing is required by the MFA policies.
        /// </summary>
        [JsonPropertyName("ip_address")]
        public string? IpAddress { get; set; }
    }
}