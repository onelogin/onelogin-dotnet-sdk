namespace OneLogin.Types
{
    public class Certificate
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
