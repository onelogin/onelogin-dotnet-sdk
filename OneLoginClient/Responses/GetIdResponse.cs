namespace OneLogin.Responses
{
    public class GetIdResponse
    {
        [JsonPropertyName("id")]
        public List<int> Id { get; set; }

    }
}