
namespace OneLogin.Requests
{
    /// <summary>
    /// Set of fields to be sent when creating and updating a Client App. 
    /// </summary>
    public class UpdateClientAppsRequest
    {
        /// <summary>
        /// A list of scope IDs associated with this authentication configuration.
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<int> Scopes { get; set; }
    }
}
