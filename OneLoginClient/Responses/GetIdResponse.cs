namespace OneLogin.Responses
{
    public class GetIdResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

    }
    public class GetStringIdResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

    }
}