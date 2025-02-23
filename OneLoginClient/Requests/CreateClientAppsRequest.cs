
namespace OneLogin.Requests
{
    /// <summary>
    /// Set of fields to be sent when creating a Client App. 
    /// </summary>
    public class CreateClientAppsRequest
    {
        /// <summary>
        /// The application ID associated with the authentication configuration.
        /// </summary>
        [JsonPropertyName("app_id")]
        public int AppId { get; set; }

        /// <summary>
        /// A list of scope IDs associated with this authentication configuration.
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<int> Scopes { get; set; }
    }
}
