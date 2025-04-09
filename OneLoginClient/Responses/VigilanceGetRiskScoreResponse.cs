namespace OneLogin.Responses
{
    /// <summary>
    /// Represents an event request to track risk scores and triggers for Vigilance AI.
    /// </summary>
    public class VigilanceGetRiskScoreResponse
    {
        /// <summary>
        /// Gets or sets the risk score, a number between 0 and 100.
        /// 0 represents low risk, while 100 represents the highest risk level.
        /// </summary>
        [JsonPropertyName("score")]
        public int Score { get; set; }

        /// <summary>
        /// Gets or sets the list of triggers that contributed to the risk score.
        /// These are indicators of key items that influence the score.
        /// </summary>
        [JsonPropertyName("triggers")]
        public List<string> Triggers { get; set; }

        /// <summary>
        /// Gets or sets any messages associated with the event (optional).
        /// </summary>
        [JsonPropertyName("messages")]
        public List<string> Messages { get; set; }
    }
}