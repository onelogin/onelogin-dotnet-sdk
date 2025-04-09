namespace OneLogin.Responses
{
    public class GetRoleAppsResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

    }
}