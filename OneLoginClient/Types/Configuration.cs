namespace OneLogin.Types
{
    public class Configuration
    {
        [JsonPropertyName("provider_arn")]
        public string? ProviderArn { get; set; }

        [JsonPropertyName("signature_algorithm")]
        public string SignatureAlgorithm { get; set; }
    }
}
