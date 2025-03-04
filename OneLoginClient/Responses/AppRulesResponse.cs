
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class AppRulesResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("match")]
        public string Match { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("conditions")]
        public List<Condition> Conditions { get; set; }

        [JsonPropertyName("actions")]
        public List<Actions> Actions { get; set; }
    }

    public class Condition
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Actions
    {
        [JsonPropertyName("action")]
        public string ActionName { get; set; }

        [JsonPropertyName("value")]
        public List<string> Value { get; set; }

        [JsonPropertyName("expression")]
        public string Expression { get; set; }
    }
}
