namespace OneLogin.Responses
{
    /// <summary>
    /// If the authentication factor requires confirmation to complete, then the device will have an active state of false otherwise it will have an active state of true (corresponding to devices that are either pending confirmation or not)
    /// OneLogin provides a series of API endpoints that let you manage MFA for your users. You can enroll multi-factor devices, trigger the sending of One-Time Password (OTP) codes via SMS or Push notification and, Verify codes to authenticate users.
    /// </summary>
    public class EnrollAnAuthenticationFactorResponse
    {
        /// <summary>
        /// Indicates the verification status of the factor. 
        /// Possible values are "accepted" (factor is verified) or "pending" (registered but not verified).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        ///// <summary>
        ///// Indicates whether this factor is the user's default MFA device for OneLogin.
        ///// Defaults to true if this is the user's default device.
        ///// </summary>
        //[JsonPropertyName("default")]
        //public bool IsDefault { get; set; }

        /// <summary>
        /// Expiration time for the verification token, which expires based on the `expires_in` parameter.
        /// This property holds the timestamp of when the token expires.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// The "official" authentication factor name as it appears to administrators in OneLogin.
        /// </summary>
        [JsonPropertyName("auth_factor_name")]
        public string AuthFactorName { get; set; }

        /// <summary>
        /// The authentication factor display name as it appears to users upon initial registration.
        /// This is defined by admins in the OneLogin settings.
        /// </summary>
        [JsonPropertyName("type_display_name")]
        public string TypeDisplayName { get; set; }

        /// <summary>
        /// The user-defined authentication factor display name assigned by users when they enroll the device.
        /// </summary>
        [JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// The unique MFA device identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Factor-specific properties (like the token or TOTP code) required for the MFA device.
        /// </summary>
        [JsonPropertyName("factor_data")]
        public FactorData FactorData { get; set; }
    }
    /// <summary>
    /// Represents the factor-specific data (verification token and TOTP URL).
    /// </summary>
    public class FactorData
    {
        /// <summary>
        /// The token used to verify the factor registration.
        /// </summary>
        [JsonPropertyName("verification_token")]
        public string VerificationToken { get; set; }

        /// <summary>
        /// OTP URL for authenticators that support the key URI format.
        /// This URL can be used to display a QR code for streamlined end-user registration with an OTP app.
        /// </summary>
        [JsonPropertyName("totp_url")]
        public string TotpUrl { get; set; }
    }
}
