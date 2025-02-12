using OneLogin.Types;

namespace OneLogin.Responses
{
    /// <summary>
    /// get a list of apps that are assigned to a given user.
    /// https://developers.onelogin.com/api-docs/2/users/get-user-apps
    /// </summary>
    public class GetUserAppsResponse
    { 
        /// <summary>
        /// ID of the app that can be accessed by the user.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the application.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL to the app’s icon.
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string? Iconurl { get; set; }

        /// <summary>
        /// The user status like enabled.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("provisioning_status")]
        public ProvisioningStatus? ProvisioningStatus { get; set; }

        /// <summary>
        /// The state of the user.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("provisioning_state")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Indicates whether the app requires the OneLogin browser extension to login.
        /// </summary>
        [JsonPropertyName("extension")]
        public bool Extension { get; set; }

        /// <summary>
        /// User’s ID in the app. For example, in one app the user’s ID may be  georgia.wong@company.com, but in another it may be georgia.wong.
        /// </summary>
        [JsonPropertyName("login_id")]
        public long LoginId { get; set; }

        /// <summary>
        /// Indicates whether the app is a user’s provisioning enabled app.
        /// </summary>
        [JsonPropertyName("provisioning_enabled")]
        public bool Provisioning_enabled { get; set; }
    }
}