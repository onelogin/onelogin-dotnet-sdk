namespace OneLogin.Requests
{
    public class SmartMFARequest
    {
        /// <summary>
        /// A unique identifier for the user, which can be a user ID, email address, or username.
        /// Must be unique to the user.
        /// </summary>
        [JsonPropertyName("user_identifier")]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// The phone number in E.164 format for sending the MFA token.
        /// This is required if SMS-based MFA is being used. The same phone number must be used for a given user_identifier.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Context object containing information about the user's current device, location, and session.
        /// </summary>
        [JsonPropertyName("context")]
        public ContextInfo Context { get; set; }

        /// <summary>
        /// The risk threshold level that triggers the sending of an MFA token.
        /// If the risk score is greater than or equal to this value, an MFA token is sent.
        /// Defaults to 50.
        /// </summary>
        [JsonPropertyName("risk_threshold")]
        public int RiskThreshold { get; set; } = 50;

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// Optional. The time window (in seconds) within which the MFA token must be verified.
        /// Defaults to 480 seconds (8 minutes), with a maximum of 900 seconds (15 minutes).
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; } = 480;
    }

    public class SmartMFAEmailRequest
    {
        /// <summary>
        /// A unique identifier for the user, which can be a user ID, email address, or username.
        /// Must be unique to the user.
        /// </summary>
        [JsonPropertyName("user_identifier")]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// The email address for sending the MFA token. 
        /// This is required if email-based MFA is being used. The same email must be used for a given user_identifier.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Context object containing information about the user's current device, location, and session.
        /// </summary>
        [JsonPropertyName("context")]
        public ContextInfo Context { get; set; }

        /// <summary>
        /// The risk threshold level that triggers the sending of an MFA token.
        /// If the risk score is greater than or equal to this value, an MFA token is sent.
        /// Defaults to 50.
        /// </summary>
        [JsonPropertyName("risk_threshold")]
        public int RiskThreshold { get; set; } = 50;

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// Optional. The time window (in seconds) within which the MFA token must be verified.
        /// Defaults to 480 seconds (8 minutes), with a maximum of 900 seconds (15 minutes).
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; } = 480;
    }
    public class ContextInfo
    {
        /// <summary>
        /// The user-agent of the browser making the request.
        /// This is required to identify the browser.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// The IP address of the user making the request.
        /// This is required to verify the user's location.
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// A persistent session identifier for the user.
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// A unique identifier for the device (e.g., mobile device ID or other unique device identifiers).
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// A unique device fingerprint for the user's web browser.
        /// This helps identify the user's browser across sessions.
        /// </summary>
        [JsonPropertyName("device_fingerprint")]
        public string DeviceFingerprint { get; set; }
    }
}