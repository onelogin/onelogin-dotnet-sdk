
namespace OneLogin.Requests
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class AuthorizationServersRequest
    {
        /// <summary>
        /// A description of the API.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The name of the API.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The configuration settings for the API.
        /// </summary>
        [JsonPropertyName("configuration")]
        public ApiConfigurationDetails Configuration { get; set; }

        /// <summary>
        /// Indicates if OneLogin is enabled for this API.
        /// </summary>
        [JsonPropertyName("onelogin")]
        public bool OneLogin { get; set; }
    }

    public class ApiConfigurationDetails
    {
        /// <summary>
        /// List of audiences for the API, which are URLs allowed to access the API.
        /// </summary>
        [JsonPropertyName("audiences")]
        public List<string> Audiences { get; set; }

        /// <summary>
        /// The resource identifier for the API.
        /// </summary>
        [JsonPropertyName("resource_identifier")]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Expiration time for the refresh token in minutes.
        /// </summary>
        [JsonPropertyName("refresh_token_expiration_minutes")]
        public int RefreshTokenExpirationMinutes { get; set; }

        /// <summary>
        /// Expiration time for the access token in minutes.
        /// </summary>
        [JsonPropertyName("access_token_expiration_minutes")]
        public int AccessTokenExpirationMinutes { get; set; }
    }
}
