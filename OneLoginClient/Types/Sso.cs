namespace OneLogin.Types
{
    public class Sso
    {
        [JsonPropertyName("metadata_url")]
        public string MetadataUrl { get; set; }

        [JsonPropertyName("acs_url")]
        public string AcsUrl { get; set; }

        [JsonPropertyName("sls_url")]
        public string SlsUrl { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("certificate")]
        public Certificate Certificate { get; set; }
    }
}
