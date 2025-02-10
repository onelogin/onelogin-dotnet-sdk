
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class GetRateLimitResponse
    {
        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("data")]
        public RateLimit? Data { get; set; }
    }
    public class RateLimit
    {
        [JsonPropertyName("X-RateLimit-Limit")]
        public int XRateLimitLimit { get; set; }

        [JsonPropertyName("X-RateLimit-Remaining")]
        public int XRateLimitRemaining { get; set; }

        [JsonPropertyName("X-RateLimit-Reset")]
        public int XRateLimitReset { get; set; }
    }
}
