
namespace OneLogin.Responses
{
    /// <summary>
    /// Use this API to return a list of account branding configuration objects.
    /// </summary>
    public class ListBrandsResponse
    {
        /// <summary>
        /// The unique ID of the brand.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Indicates whether the brand is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The name of the brand.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates if the brand is the master brand.
        /// </summary>
        [JsonPropertyName("master")]
        public bool Master { get; set; }

        /// <summary>
        /// The domain name associated with the brand.
        /// </summary>
        [JsonPropertyName("domain_name")]
        public string DomainName { get; set; }

    }
}
