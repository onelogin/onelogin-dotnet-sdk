namespace OneLogin.Types
{
    /// <summary>
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