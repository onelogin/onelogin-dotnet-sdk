namespace OneLogin.Responses
{
    public class VigilanceAIRulesResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier for the geoblock rule.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the geoblock rule.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the geoblock rule.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the rule (e.g., blacklist).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the target field to apply the rule (e.g., location address).
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the source information for the geoblock rule (if applicable).
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the list of country ISO codes to block.
        /// </summary>
        [JsonPropertyName("filters")]
        public List<string> Filters { get; set; }
    }
}