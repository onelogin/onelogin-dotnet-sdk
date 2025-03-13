namespace OneLogin.Requests
{
    public class BrandingMessageTemplateRequest
    {
        /// <summary>
        /// Gets or sets the account identifier associated with the template configuration.
        /// </summary>
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        /// Gets or sets the locale for the template configuration (e.g., "es" for Spanish).
        /// </summary>
        [JsonPropertyName("locale")]
        public required string Locale { get; set; }

        /// <summary>
        /// Gets or sets the type of email template, such as "email_forgot_password".
        /// </summary>
        [JsonPropertyName("type")]
        public required string Type { get; set; }

        /// <summary>
        /// Gets or sets the class of the template (e.g., "email_template").
        /// </summary>
        [JsonPropertyName("template_class")]
        public string TemplateClass { get; set; }

        /// <summary>
        /// Gets or sets the actual email template containing both HTML and plain text versions.
        /// </summary>
        [JsonPropertyName("template")]
        public required Template Template { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the last update for this template configuration.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this template is the default.
        /// </summary>
        [JsonPropertyName("default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the brand identifier associated with this email template configuration.
        /// </summary>
        [JsonPropertyName("brand_id")]
        public int BrandId { get; set; }
    }

}