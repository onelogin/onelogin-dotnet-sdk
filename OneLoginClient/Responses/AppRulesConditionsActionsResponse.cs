namespace OneLogin.Responses
{
    public class AppRulesConditionsActionsResponse
    {
        /// <summary>
        /// The name of the environment variable.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}