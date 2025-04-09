
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class ScopesResponse
    {
        /// <summary>
        /// A description of the scope.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The unique identifier for the scope.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

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
    }

}
