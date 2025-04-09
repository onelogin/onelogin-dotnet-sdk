﻿using System;
using System.Runtime.Serialization;

namespace OneLogin.Responses
{
    /// <summary>
    /// The response with a set of events.
    /// </summary>
    public class GetEventsResponse : PaginationBaseResponse<Event>
    {
    }

    /// <summary>
    /// An onelogin event.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Event’s unique ID in OneLogin. Autogenerated by OneLogin.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Time and date at which the event was created. This value is autogenerated by OneLogin.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Account that triggered the event.
        /// </summary>
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        /// ID of the user that was acted upon to trigger the event.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Type of event triggered.
        /// </summary>
        [JsonPropertyName("event_type_id")]
        public int EventTypeId { get; set; }

        /// <summary>
        /// More details about the event.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// IP address of the machine used to trigger the event.
        /// </summary>
        [JsonPropertyName("ipaddr")]
        public string IpAddress { get; set; }

        /// <summary>
        /// ID of the user whose action triggered the event.
        /// </summary>
        [JsonPropertyName("actor_user_id")]
        public int? ActorUserId { get; set; }

        /// <summary>
        /// Name of the user who assumed the role of the acting user to trigger the event, if applicable.
        /// </summary>
        [JsonPropertyName("assuming_acting_user_id")]
        public int? assuming_acting_user_id { get; set; }

        /// <summary>
        /// ID of a role involved in the event.
        /// </summary>
        [JsonPropertyName("role_id")]
        public int? role_id { get; set; }

        /// <summary>
        /// ID of the app involved in the event, if applicable.
        /// </summary>
        [JsonPropertyName("app_id")]
        public int? app_id { get; set; }

        /// <summary>
        /// ID of a group involved in the event.
        /// </summary>
        [JsonPropertyName("group_id")]
        public string group_id { get; set; }

        /// <summary>
        /// ID of a device involved in the event.
        /// </summary>
        [JsonPropertyName("otp_device_id")]
        public string otp_device_id { get; set; }

        /// <summary>
        /// ID of the policy involved in the event.
        /// </summary>
        [JsonPropertyName("policy_id")]
        public long? policy_id { get; set; }

        /// <summary>
        /// Acting system that triggered the event when the actor is not a user.
        /// </summary>
        [JsonPropertyName("actor_system")]
        public string actor_system { get; set; }

        /// <summary>
        /// More details about the event.
        /// </summary>
        [JsonPropertyName("custom_message")]
        public string custom_message { get; set; }

        /// <summary>
        /// Name of a role involved in the event.
        /// </summary>
        [JsonPropertyName("role_name")]
        public string role_name { get; set; }

        /// <summary>
        /// Name of the app involved in the event, if applicable.
        /// </summary>
        [JsonPropertyName("app_name")]
        public string app_name { get; set; }

        /// <summary>
        /// Name of a group involved in the event.
        /// </summary>
        [JsonPropertyName("group_name")]
        public string group_name { get; set; }

        /// <summary>
        /// First and last name of the user whose action triggered the event.
        /// </summary>
        [JsonPropertyName("actor_user_name")]
        public string actor_user_name { get; set; }

        /// <summary>
        /// Name of the user that was acted upon to trigger the event.
        /// </summary>
        [JsonPropertyName("user_name")]
        public string user_name { get; set; }

        /// <summary>
        /// Name of the policy involved in the event.
        /// </summary>
        [JsonPropertyName("policy_name")]
        public string policy_name { get; set; }

        /// <summary>
        /// Name of a device involved in the event.
        /// </summary>
        [JsonPropertyName("otp_device_name")]
        public string otp_device_name { get; set; }

        /// <summary>
        /// Name of operation involved in the event.
        /// </summary>
        [JsonPropertyName("operation_name")]
        public string operation_name { get; set; }

        /// <summary>
        /// Directory sync run ID.
        /// </summary>
        [JsonPropertyName("directory_sync_run_id")]
        public string directory_sync_run_id { get; set; }

        /// <summary>
        /// Event’s unique ID in OneLogin. Autogenerated by OneLogin.
        /// </summary>
        [JsonPropertyName("directory_id")]
        public string directory_id { get; set; }

        /// <summary>
        /// Event’s unique ID in OneLogin. Autogenerated by OneLogin.
        /// </summary>
        [JsonPropertyName("resolution")]
        public string resolution { get; set; }

        /// <summary>
        /// Client ID used to generate the access token that made the API call that generated the event.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string client_id { get; set; }

        /// <summary>
        /// ID of the resource (user, role, group, and so forth) associated with the event.
        /// </summary>
        [JsonPropertyName("resource_type_id")]
        public int? resource_type_id { get; set; }

        /// <summary>
        /// Provisioning error details, if applicable.
        /// </summary>
        [JsonPropertyName("error_description")]
        public string error_description { get; set; }

        /// <summary>
        /// Event’s unique ID in OneLogin. Autogenerated by OneLogin.
        /// </summary>
        [JsonPropertyName("proxy_ip")]
        public string proxy_ip { get; set; }
    }
}
