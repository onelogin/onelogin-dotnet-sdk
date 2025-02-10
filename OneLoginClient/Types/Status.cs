namespace OneLogin.Types
{
    /// <summary>
    /// Represents the user’s stage in a process (such as user account approval).
    /// User state determines the possible statuses a user account can be in.
    /// </summary>
    public class Status
    {
        [JsonPropertyName("error")]
        public bool Error { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}