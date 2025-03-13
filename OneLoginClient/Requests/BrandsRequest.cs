namespace OneLogin.Requests
{
    public class BrandsRequest
    {
        /// <summary>
        /// The name of the brand (for humans). This isn't related to subdomains.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the brand is the primary master brand.
        /// </summary>
        [JsonPropertyName("master")]
        public bool Master { get; set; }

        /// <summary>
        /// Indicates if the brand is enabled or not. Default is false.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = false; // Default is false

        /// <summary>
        /// Indicates if the custom support is enabled. If enabled, the login page includes support request functionality.
        /// </summary>
        [JsonPropertyName("custom_support_enabled")]
        public bool CustomSupportEnabled { get; set; }

        /// <summary>
        /// The primary brand color in hexadecimal format.
        /// </summary>
        [JsonPropertyName("custom_color")]
        public string CustomColor { get; set; }

        /// <summary>
        /// The secondary brand color in hexadecimal format.
        /// </summary>
        [JsonPropertyName("custom_accent_color")]
        public string CustomAccentColor { get; set; }

        /// <summary>
        /// The color used for the masking layer above the background image on the login screen.
        /// </summary>
        [JsonPropertyName("custom_masking_color")]
        public string CustomMaskingColor { get; set; }

        /// <summary>
        /// The opacity for the custom masking color.
        /// </summary>
        [JsonPropertyName("custom_masking_opacity")]
        public int CustomMaskingOpacity { get; set; }

        /// <summary>
        /// Indicates if a custom Username/Email field label is enabled on the login screen.
        /// </summary>
        [JsonPropertyName("enable_custom_label_for_login_screen")]
        public bool EnableCustomLabelForLoginScreen { get; set; }

        /// <summary>
        /// Custom label text for the Username/Email field on the login screen.
        /// </summary>
        [JsonPropertyName("custom_label_text_for_login_screen")]
        public string CustomLabelTextForLoginScreen { get; set; }

        /// <summary>
        /// The link text to show the login instruction screen.
        /// </summary>
        [JsonPropertyName("login_instruction_title")]
        public string LoginInstructionTitle { get; set; }

        /// <summary>
        /// The text for the login instruction screen, styled in Markdown.
        /// </summary>
        [JsonPropertyName("login_instruction")]
        public string LoginInstruction { get; set; }

        /// <summary>
        /// Indicates if the OneLogin footer will appear at the bottom of the login page.
        /// </summary>
        [JsonPropertyName("hide_onelogin_footer")]
        public bool HideOneloginFooter { get; set; }

        /// <summary>
        /// Custom message for MFA enrollment.
        /// </summary>
        [JsonPropertyName("mfa_enrollment_message")]
        public string MfaEnrollmentMessage { get; set; }

        /// <summary>
        /// Base64 encoded image data for the background image (JPG/PNG, <5MB).
        /// </summary>
        [JsonPropertyName("background")]
        public string Background { get; set; }

        /// <summary>
        /// Base64 encoded image data for the logo (PNG, <1MB).
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}