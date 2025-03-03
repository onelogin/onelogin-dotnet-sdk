namespace OneLogin.Responses
{
    public class BrandingLookupMessagesResponse
    {
        /// <summary>
        /// Gets or sets the type ID for the custom error message.
        /// Acceptable values: 9
        /// </summary>
        [JsonPropertyName("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets the locale for the custom error message.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the title of the error message.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the error message.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the custom error message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}