namespace OneLogin.Responses
{
    /// <summary>
    /// Represents the response structure that includes roles and pagination information.
    /// </summary>
    public class PrivilegeUserResponse
    {
        /// <summary>
        /// The total number of roles.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// A list of User IDs.
        /// </summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }

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

}