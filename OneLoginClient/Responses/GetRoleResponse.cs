namespace OneLogin.Responses
{
    public class GetRoleResponse
    {
        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of app IDs that will be assigned to the role.
        /// Example: [234, 567, 777]
        /// </summary>
        [JsonPropertyName("apps")]
        public List<int> Apps { get; set; }

        /// <summary>
        /// Gets or sets the list of user IDs to assign to the role.
        /// </summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }

        /// <summary>
        /// Gets or sets the list of user IDs to assign as role administrators.
        /// </summary>
        [JsonPropertyName("admins")]
        public List<int> Admins { get; set; }

        /// <summary>
        /// Id of the role
        /// </summary>
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }

}