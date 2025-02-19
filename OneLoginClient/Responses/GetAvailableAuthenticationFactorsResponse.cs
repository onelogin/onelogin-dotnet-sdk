namespace OneLogin.Responses
{
    /// <summary>
    /// Use this API to return a list of authentication factors that are available for user enrollment via API.
    /// </summary>
    public class GetAvailableAuthenticationFactorsResponse 
    {
        /// <summary>
        /// "Official" authentication factor name, as it appears to administrators in OneLogin.
        /// </summary>
        /// <value>The name.</value>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Identifier for the factor which will be used for user enrollmen
        /// </summary>
        /// <value>The factor identifier.</value>
        [JsonPropertyName("factor_id")]
        public int FactorId { get; set; }

        /// <summary>
        /// Internal use only
        /// </summary>
        [JsonPropertyName("auth_factor_name")]
        public string AuthFactorName { get; set; }
    }
}
