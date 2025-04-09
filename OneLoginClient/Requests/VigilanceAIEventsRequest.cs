namespace OneLogin.Requests
{
    public class VigilanceAIEventsRequest
    {
        /// <summary>
        /// Verbs are used to distinguish between different types of events.
        /// </summary>
        [JsonPropertyName("verb")]
        public required string Verb { get; set; }

        /// <summary>
        /// The IP address of the User’s request.
        /// </summary>
        [JsonPropertyName("ip")]
        public required string Ip { get; set; }

        /// <summary>
        /// The user agent of the User’s request.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public required string UserAgent { get; set; }

        /// <summary>
        /// An Object containing User details.
        /// </summary>
        [JsonPropertyName("user")]
        public required UserDetails User { get; set; }

        /// <summary>
        /// This field can be used for targeting custom rules based on a group of people, customers, accounts, or even a single user.
        /// </summary>
        [JsonPropertyName("source")]
        public SourceDetails Source { get; set; }

        /// <summary>
        /// A dictionary of extra information that provides useful context about the session, such as the session ID or some cookie information.
        /// </summary>
        [JsonPropertyName("session")]
        public DeviceSessionDetails Session { get; set; }

        /// <summary>
        /// Information about the device being used.
        /// </summary>
        [JsonPropertyName("device")]
        public DeviceSessionDetails Device { get; set; }

        /// <summary>
        /// Set to the value of the __tdli_fp cookie.
        /// </summary>
        [JsonPropertyName("fp")]
        public string Fp { get; set; }

        /// <summary>
        /// Date and time of the event in ISO8601 format. Useful for preloading old events.
        /// </summary>
        [JsonPropertyName("published")]
        public string Published { get; set; }
    }

    public class UserDetails
    {
        /// <summary>
        /// A unique identifier for the user.
        /// </summary>
        [JsonPropertyName("id")]
        public required string Id { get; set; }

        /// <summary>
        /// A name for the user.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A boolean value indicating if the metadata supplied in this event should be considered as trusted for the user.
        /// </summary>
        [JsonPropertyName("authenticated")]
        public bool Authenticated { get; set; }
    }

    public class SourceDetails
    {
        /// <summary>
        /// A unique id that represents the source of the event.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the source.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class DeviceSessionDetails
    {
        /// <summary>
        /// This device’s unique identifier.
        /// If you use a database to track sessions, you can send us the session ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
       
    }
}