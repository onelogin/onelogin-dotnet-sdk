
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class AuthorizationServersResponse
    {
        /// <summary>
        /// A description of the API.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// The unique identifier of the API.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Indicates if OneLogin is enabled for this API.
        /// </summary>
        [JsonPropertyName("onelogin")]
        public bool OneLogin { get; set; }
    }
    
}
