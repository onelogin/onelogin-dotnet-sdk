namespace OneLogin.Requests
{
    public class RoleRequest
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("apps")]
        public List<int>? Apps { get; set; }

        [JsonPropertyName("users")]
        public List<int>? Users { get; set; }

        [JsonPropertyName("admins")]
        public List<int>? Admins { get; set; }
    }
}