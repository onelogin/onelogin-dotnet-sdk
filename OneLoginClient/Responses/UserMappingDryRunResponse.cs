
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class UserMappingDryRunResponse
    {
        [JsonPropertyName("user")]
        public UserMappingUser User { get; set; }

        [JsonPropertyName("mapped")]
        public bool Mapped { get; set; }
    }

    public class UserMappingUser
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
