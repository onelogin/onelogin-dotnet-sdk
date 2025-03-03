namespace OneLogin.Responses
{
    public class BrandingLookupMessagesRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the application (optional).
        /// </summary>
        [JsonPropertyName("app_id")]
        public int? AppId { get; set; }

        /// <summary>
        /// Gets or sets the type ID for the custom error message (optional).
        /// Acceptable values: 9
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; set; }

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
    }
}