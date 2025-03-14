namespace OneLogin.Responses
{
    public class LoginPagesVerifyFactorResponse : BaseResponse<VerifyFactor>
    {
    }
    public class VerifyFactor
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonPropertyName("return_to_url")]
        public string? ReturnToUrl { get; set; }

        [JsonPropertyName("session_token")]
        public string SessionToken { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}