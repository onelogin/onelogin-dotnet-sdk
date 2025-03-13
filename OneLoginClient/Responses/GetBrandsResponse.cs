
namespace OneLogin.Responses
{
    public class GetBrandsResponse
    {
        /// <summary>
        /// Custom links for the brand.
        /// </summary>
        [JsonPropertyName("custom_links")]
        public List<string> CustomLinks { get; set; }

        /// <summary>
        /// Indicates if custom SMTP settings are used.
        /// </summary>
        [JsonPropertyName("use_custom_smtp_setting")]
        public bool UseCustomSmtpSetting { get; set; }

        /// <summary>
        /// Unique identifier for the branding object.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the brand.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the brand is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates if custom support is enabled.
        /// </summary>
        [JsonPropertyName("custom_support_enabled")]
        public bool CustomSupportEnabled { get; set; }

        /// <summary>
        /// The primary brand color.
        /// </summary>
        [JsonPropertyName("custom_color")]
        public string CustomColor { get; set; }

        /// <summary>
        /// The secondary brand color.
        /// </summary>
        [JsonPropertyName("custom_accent_color")]
        public string CustomAccentColor { get; set; }

        /// <summary>
        /// The color for the masking layer above the background image.
        /// </summary>
        [JsonPropertyName("custom_masking_color")]
        public string CustomMaskingColor { get; set; }

        /// <summary>
        /// The opacity for the custom masking color.
        /// </summary>
        [JsonPropertyName("custom_masking_opacity")]
        public int CustomMaskingOpacity { get; set; }

        /// <summary>
        /// Indicates if the custom Username/Email field label is enabled.
        /// </summary>
        [JsonPropertyName("enable_custom_label_for_login_screen")]
        public bool EnableCustomLabelForLoginScreen { get; set; }

        /// <summary>
        /// Custom label for the Username/Email field on the login screen.
        /// </summary>
        [JsonPropertyName("custom_label_text_for_login_screen")]
        public string CustomLabelTextForLoginScreen { get; set; }

        /// <summary>
        /// Text for the login instruction screen, styled in Markdown.
        /// </summary>
        [JsonPropertyName("login_instruction")]
        public string LoginInstruction { get; set; }

        /// <summary>
        /// Link text to show login instruction screen.
        /// </summary>
        [JsonPropertyName("login_instruction_title")]
        public string LoginInstructionTitle { get; set; }

        /// <summary>
        /// Indicates if the OneLogin footer will appear at the bottom of the login page.
        /// </summary>
        [JsonPropertyName("hide_onelogin_footer")]
        public bool HideOneloginFooter { get; set; }

        /// <summary>
        /// Message displayed for MFA enrollment.
        /// </summary>
        [JsonPropertyName("mfa_enrollment_message")]
        public string MfaEnrollmentMessage { get; set; }

        /// <summary>
        /// Indicates if this is the master brand.
        /// </summary>
        [JsonPropertyName("master")]
        public bool Master { get; set; }

        /// <summary>
        /// Background details for the brand, including image and metadata.
        /// </summary>
        [JsonPropertyName("background")]
        public Background Background { get; set; }
    }

    /// <summary>
    /// Represents the background details for a brand, including URLs and image metadata.
    /// </summary>
    public class Background
    {
        /// <summary>
        /// The file size of the background image.
        /// </summary>
        [JsonPropertyName("file_size")]
        public int FileSize { get; set; }

        /// <summary>
        /// The content type of the background image.
        /// </summary>
        [JsonPropertyName("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The timestamp when the background image was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// URLs for different versions of the background image.
        /// </summary>
        [JsonPropertyName("urls")]
        public BackgroundUrls Urls { get; set; }
    }

    /// <summary>
    /// Represents URLs for the different versions of the background image.
    /// </summary>
    public class BackgroundUrls
    {
        /// <summary>
        /// URL for the branding background image.
        /// </summary>
        [JsonPropertyName("branding")]
        public string Branding { get; set; }

        /// <summary>
        /// URL for the login background image.
        /// </summary>
        [JsonPropertyName("login")]
        public string Login { get; set; }

        /// <summary>
        /// URL for the original background image.
        /// </summary>
        [JsonPropertyName("original")]
        public string Original { get; set; }
    }
}
