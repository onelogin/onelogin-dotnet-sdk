
namespace OneLogin.Requests
{
    /// <summary>
    /// Request to authenticate a one-time password (OTP) code provided by a multifactor authentication (MFA) device.
    /// If this is the first time that the OTP device has been confirmed, then the device will be updated to have a state of enabled.
    /// </summary>
    public class VerifySMSEmailAuthenticatorFactorRequest
    {
        /// <summary>
        /// The state_token is returned after a successful request to Enroll a Factor or Activate a Factor.
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// OTP code provided by the device or SMS message sent to user.
        /// </summary>
        [JsonPropertyName("otp")]
        public required string Otp { get; set; }
    }
}
