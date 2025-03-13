namespace OneLogin.Requests
{
    public class BrandsTemplateTypeRequest
    {
        /// <summary>
        /// Gets or sets the actual email template containing both HTML and plain text versions.
        /// </summary>
        [JsonPropertyName("template")]
        public Template Template { get; set; }
    }
}