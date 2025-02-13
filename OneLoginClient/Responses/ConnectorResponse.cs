namespace OneLogin.Responses
{
    public class ConnectorResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }  // Assuming the ID is a string. Change it to an appropriate type if necessary.

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("auth_method")]
        public int AuthMethod { get; set; }  // Assuming auth_method is an integer ID. Adjust if necessary.

        [JsonPropertyName("allows_new_parameters")]
        public bool AllowsNewParameters { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }
    }
}
