namespace OneLogin.Requests
{
    public class BrandingUpdateLookupMessagesRequest
    {
        /// <summary>
        /// Gets or sets the type ID for the custom error message (optional).
        /// Acceptable values: 9
        /// </summary>
        [JsonPropertyName("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets the type name for the custom error message (optional).
        /// Acceptable values: MESSAGE_TYPE_NO_ACCESS_APP
        /// </summary>
        [JsonPropertyName("type_name")]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the locale for the custom error message (optional).
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the title of the custom error message (optional).
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the custom error message (optional).
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the actual custom error message (optional).
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

}