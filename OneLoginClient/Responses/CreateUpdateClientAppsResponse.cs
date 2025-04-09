
namespace OneLogin.Responses
{
    /// <summary>
    /// Set of fields to be sent when creating a Client App. 
    /// </summary>
    public class CreateUpdateClientAppsResponse
    {
        /// <summary>
        /// The unique identifier for the API authentication configuration.
        /// </summary>
        [JsonPropertyName("api_auth_id")]
        public int ApiAuthId { get; set; }

        /// <summary>
        /// The application ID associated with the authentication configuration.
        /// </summary>
        [JsonPropertyName("app_id")]
        public int AppId { get; set; }
    }
}
