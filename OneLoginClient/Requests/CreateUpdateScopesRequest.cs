
namespace OneLogin.Requests
{
    /// <summary>
    /// Set of fields to be sent when creating a Scope. 
    /// </summary>
    public class CreateUpdateScopesRequest
    {
        /// <summary>
        /// A value representing the API scope that will be authorized.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// A description of what access the scope enables.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
