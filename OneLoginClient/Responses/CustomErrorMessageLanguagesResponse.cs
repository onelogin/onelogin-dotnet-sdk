
namespace OneLogin.Responses
{
    /// <summary>
    /// Represents the language and default status for a given configuration.
    /// </summary>
    public class CustomErrorMessageLanguagesResponse
    {
        /// <summary>
        /// Gets or sets the language code, e.g., "vi-VN" for Vietnamese (Vietnam).
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this language is the default language.
        /// </summary>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

    }
}
