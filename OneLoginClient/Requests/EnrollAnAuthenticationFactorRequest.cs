using System.Runtime.Serialization;

namespace OneLogin.Requests
{
    /// <summary>
    /// A request to enroll a user with a given authentication factor.
    /// </summary>
    public class EnrollAnAuthenticationFactorRequest
    {
        /// <summary>
        /// The identifier of the factor to enroll the user with
        /// </summary>
        [JsonPropertyName("factor_id")]
        public required int FactorId { get; set; }

        /// <summary>
        /// The name for the user's device
        /// </summary>
        [JsonPropertyName("display_name")]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The expiration time in seconds for the OTP or registration
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; } = "120";

        /// <summary>
        /// Whether the factor is verified. Defaults to false
        /// </summary>
        [JsonPropertyName("verified")]
        public bool Verified { get; set; } = false;

        /// <summary>
        /// Optional. Only applies to Email MagicLink factor.
        /// </summary>
        [JsonPropertyName("redirect_to")]
        public string? RedirectTo { get; set; }

        /// <summary>
        /// Optional. Only applies to SMS factor.
        /// </summary>
        [JsonPropertyName("custom_message")]
        public string? CustomMessage { get; set; }
    }
}
