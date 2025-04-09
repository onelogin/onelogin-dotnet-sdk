namespace OneLogin.Responses
{
    public class BrandingMessageTemplateTypeResponse
    {
        /// <summary>
        /// Gets or sets the locale for the template configuration (e.g., "es" for Spanish).
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the type of email template, such as "email_forgot_password".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the class of the template (e.g., "email_template").
        /// </summary>
        [JsonPropertyName("template_class")]
        public string TemplateClass { get; set; }

        /// <summary>
        /// Gets or sets the actual email template containing both HTML and plain text versions.
        /// </summary>
        [JsonPropertyName("template")]
        public Template Template { get; set; }

    }

}