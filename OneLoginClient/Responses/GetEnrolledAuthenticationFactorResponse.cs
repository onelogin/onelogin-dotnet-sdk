
namespace OneLogin.Responses
{
    public class GetEnrolledAuthenticationFactorResponse 
    {
        /// <summary>
        /// The "official" authentication factor name, as it appears to administrators in OneLogin.
        /// </summary>
        [JsonPropertyName("auth_factor_name")]
        public string AuthFactorName { get; set; }

        /// <summary>
        /// Indicates if this is the user's default MFA device for OneLogin.
        /// Defaults to true if this is the user's default MFA device.
        /// </summary>
        [JsonPropertyName("default")]
        public bool IsDefault { get; set; }

        ///// <summary>
        ///// The authentication factor display name as it appears to users in OneLogin.
        ///// This is defined by admins in the administrative interface under Settings > Authentication Factors.
        ///// </summary>
        //[JsonPropertyName("display_name")]
        //public string DisplayName { get; set; }

        /// <summary>
        /// The unique identifier of the MFA device.
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// The authentication factor display name as it appears to users upon initial registration.
        /// This display name is defined by admins in the administrative interface under Settings > Authentication Factors.
        /// </summary>
        [JsonPropertyName("type_display_name")]
        public string TypeDisplayName { get; set; }

        /// <summary>
        /// The authentication factor display name assigned by the user when they register the device.
        /// </summary>
        [JsonPropertyName("user_display_name")]
        public string UserDisplayName { get; set; }
    }
}
