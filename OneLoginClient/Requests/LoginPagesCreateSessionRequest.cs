namespace OneLogin.Requests
{
    public class LoginPagesCreateSessionRequest
    {
        /// <summary>
        /// Set to the username or email of the user that you want to log in.
        /// </summary>
        [JsonPropertyName("username_or_email")]
        public required string UsernameOrEmail { get; set; }

        /// <summary>
        /// Set to the password of the user that you want to log in.
        /// </summary>
        [JsonPropertyName("password")]
        public required string Password { get; set; }

        /// <summary>
        /// Set to the subdomain of the user that you want to log in.
        /// For example, if your OneLogin URL is splinkly.onelogin.com, enter splinkly as the subdomain value.
        /// </summary>
        [JsonPropertyName("subdomain")]
        public required string Subdomain { get; set; }

        /// <summary>
        /// Optional. A comma separated list of user fields to return.
        /// If this attribute is ommitted then by default the users id, firstname, lastname, email, and username will be returned.
        /// </summary>
        [JsonPropertyName("fields")]
        public string? fields { get; set; }

    }
}