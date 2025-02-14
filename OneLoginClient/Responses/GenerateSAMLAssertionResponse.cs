
namespace OneLogin.Responses
{
    /// <summary>
    /// https://developers.onelogin.com/api-docs/2/saml-assertions/generate-saml-assertion
    /// </summary>
    public class GenerateSAMLAssertionResponse
    {
        /// <summary>
        /// Provides the SAML assertion. Returned only when MFA is not required.
        /// </summary>
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Plain text description describing the outcome of the response.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Provides the state_token value that must be submitted with each Verify Factor API call until the SAML assertion has been issued.
        /// Returned only when MFA is required.
        /// </summary>
        [JsonPropertyName("state_token")]
        public string? StateToken { get; set; }

        /// <summary>
        /// Provides information about the user that will be logged in via the SAML assertion.
        /// </summary>
        [JsonPropertyName("user")]
        public User? User { get; set; }

        /// <summary>
        /// Provides device values that must be submitted with the Verify Factor API call.
        /// </summary>
        [JsonPropertyName("devices")]
        public List<Device>? Devices { get; set; }

        /// <summary>
        /// Provides the Verify Factor API endpoint to which the device_id, state_token, app_id, and otp_token must be sent for verification.
        /// Returned only when MFA is required.
        /// </summary>
        [JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }
    }
    public class User
    {
        /// <summary>
        /// The last name of the user to be logged in via the SAML assertion.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// The username of the user to be logged in via the SAML assertion.
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The email of the user to be logged in via the SAML assertion.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The first name of the user to be logged in via the SAML assertion.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// The unique ID of the user to be logged in via the SAML assertion.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }

    public class Device
    {
        /// <summary>
        /// Lists an available MFA device type, such as OneLogin OTP SMS or Google Authenticator.
        /// </summary>
        [JsonPropertyName("device_type")]
        public string? DeviceType { get; set; }

        /// <summary>
        /// Lists an ID for the device type that must be submitted with the Verify Factor API call.
        /// </summary>
        [JsonPropertyName("device_id")]
        public long? DeviceId { get; set; }
    }
}
