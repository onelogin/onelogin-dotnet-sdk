
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class ClientAppsResponse
    {
        /// <summary>
        /// The unique identifier for the API authentication configuration.
        /// </summary>
        [JsonPropertyName("api_auth_id")]
        public int ApiAuthId { get; set; }

        /// <summary>
        /// A list of scopes associated with this authentication configuration.
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<ApiScope> Scopes { get; set; }

        /// <summary>
        /// The application ID associated with the authentication configuration.
        /// </summary>
        [JsonPropertyName("app_id")]
        public int AppId { get; set; }

        /// <summary>
        /// The name of the authentication configuration.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class ApiScope
    {
        /// <summary>
        /// A description of the scope.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The value of the scope.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Indicates whether the scope is inherited from a parent configuration.
        /// </summary>
        [JsonPropertyName("inherited")]
        public bool Inherited { get; set; }

        /// <summary>
        /// The unique identifier for the scope.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

}
