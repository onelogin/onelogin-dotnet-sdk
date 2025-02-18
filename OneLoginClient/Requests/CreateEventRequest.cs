using System.Runtime.Serialization;

namespace OneLogin.Requests
{
    /// <summary>
    /// Create an event in the OneLogin event log.
    /// </summary>
    public class CreateEventRequest
    {
        /// <summary>
        /// Set to the ID of the event type you want to create. For a list of valid event type IDs, see Event Resource and Types.
        /// </summary>
        [JsonPropertyName("event_type_id")]
        public int EventTypeId { get; set; }

        /// <summary>
        /// Set to your account ID.
        /// </summary>
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("actor_system")]
        public string ActorSystem { get; set; }

        /// <summary>
        /// Value must exist in OneLogin.
        /// </summary>
        [JsonPropertyName("actor_user_id")]
        public string ActorUserId { get; set; }

        [JsonPropertyName("app_id")]
        public long AppId { get; set; }

        [JsonPropertyName("assuming_acting_user_id")]
        public string AssumingActingUserId { get; set; }

        [JsonPropertyName("custom_message")]
        public string CustomMessage { get; set; }

        [JsonPropertyName("directory_sync_run_id")]
        public string DirectorySyncRunId { get; set; }

        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        [JsonPropertyName("ipaddr")]
        public string IpAddress { get; set; }

        [JsonPropertyName("otp_device_id")]
        public string OtpDeviceId { get; set; }

        [JsonPropertyName("otp_device_name")]
        public string OtpDeviceName { get; set; }

        [JsonPropertyName("policy_id")]
        public string PolicyId { get; set; }

        [JsonPropertyName("policy_name")]
        public string PolicyName { get; set; }

        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }

        [JsonPropertyName("user_id")]
        public long UserId { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
