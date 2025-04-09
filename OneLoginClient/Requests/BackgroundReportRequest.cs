namespace OneLogin.Requests
{
    public class BackgroundReportRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}