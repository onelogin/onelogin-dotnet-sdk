namespace OneLogin.Responses
{
    public class VerifyFactorMFAResponse
    {
        /// <summary>
        /// The unique identifier for the MFA registration.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The status of the registration:
        /// - "pending" means the registration has not been completed.
        /// - "accepted" means the registration has successfully completed.
        /// - "rejected" means the user has denied the MFA attempt or incorrectly provided the OTP code.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The unique identifier for the device to be used with the "Verify the Factor" operation.
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }
    }
}