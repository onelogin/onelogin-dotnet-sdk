
namespace OneLogin.Responses
{
    public class BaseErrorResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
    }
}