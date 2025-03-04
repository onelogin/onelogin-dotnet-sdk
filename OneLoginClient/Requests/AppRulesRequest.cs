
namespace OneLogin.Requests
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class AppRulesRequest
    {

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("match")]
        public required string Match { get; set; }

        [JsonPropertyName("enabled")]
        public required bool Enabled { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("conditions")]
        public required List<Condition> Conditions { get; set; }

        [JsonPropertyName("actions")]
        public required List<Actions> Actions { get; set; }
    }
    
}
