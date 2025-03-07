namespace OneLogin.Responses
{
    public class LoginPagesCreateSessionResponse : BaseResponse<CreateSession>
    {
    }
    public class CreateSession
    {
        [JsonPropertyName("devices")]
        public List<Device> Devices { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonPropertyName("state_token")]
        public string StateToken { get; set; }

    }
}