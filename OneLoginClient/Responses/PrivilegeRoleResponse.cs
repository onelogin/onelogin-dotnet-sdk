namespace OneLogin.Responses
{
    /// <summary>
    /// Represents the response structure that includes roles and pagination information.
    /// </summary>
    public class PrivilegeRoleResponse
    {
        /// <summary>
        /// The total number of roles.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// A list of role IDs.
        /// </summary>
        [JsonPropertyName("roles")]
        public List<int> Roles { get; set; }

        /// <summary>
        /// The cursor before the current page of data (for pagination).
        /// </summary>
        [JsonPropertyName("beforeCursor")]
        public string BeforeCursor { get; set; }

        /// <summary>
        /// The previous link for pagination (if applicable).
        /// </summary>
        [JsonPropertyName("previousLink")]
        public string PreviousLink { get; set; }

        /// <summary>
        /// The cursor after the current page of data (for pagination).
        /// </summary>
        [JsonPropertyName("afterCursor")]
        public string AfterCursor { get; set; }

        /// <summary>
        /// The next link for pagination (if applicable).
        /// </summary>
        [JsonPropertyName("nextLink")]
        public string NextLink { get; set; }
    }

    public class SuccessResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        
    }
}