namespace OneLogin.Responses
{
    public class PrivilegeResponse
    {
        /// <summary>
        /// The unique identifier for the scope.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the privilege.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description of the privilege.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The privilege details, including version and statements.
        /// </summary>
        [JsonPropertyName("privilege")]
        public PrivilegeDetails PrivilegeDetails { get; set; }
    }
}