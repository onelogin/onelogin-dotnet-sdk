
namespace OneLogin.Requests
{
    public class ActivateAnAuthenticationFactorRequest 
    {
        /// <summary>
        /// The unique identifier of the MFA device that is to be verified.
        /// </summary>
        [JsonPropertyName("device_id")]
        public int DeviceId { get; set; }

        /// <summary>
        /// The window of time (in seconds) within which the factor must be verified.
        /// This is optional and defaults to 120 seconds (2 minutes), with a maximum of 900 seconds (15 minutes).
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; } = 120; // Default to 120 seconds

        /// <summary>
        /// The URL to which the user will be redirected after the MagicLink success page, 
        /// but only applicable for the Email MagicLink factor.
        /// </summary>
        [JsonPropertyName("redirect_to")]
        public string? RedirectTo { get; set; }

        /// <summary>
        /// A message template to be sent via SMS.
        /// This is optional and only applies to the SMS factor.
        /// The maximum length of the message, after inserting template variables, is 160 characters, including the OTP code.
        /// </summary>
        [JsonPropertyName("custom_message")]
        public string? CustomMessage { get; set; }

    }
}
