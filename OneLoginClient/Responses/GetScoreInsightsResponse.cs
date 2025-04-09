namespace OneLogin.Responses
{
    public class GetScoreInsightsResponse
    {
        /// <summary>
        /// Gets or sets the scores for different levels of risk.
        /// </summary>
        public RiskScores Scores { get; set; }

        /// <summary>
        /// Gets or sets the total score.
        /// </summary>
        public int Total { get; set; }
    }
    /// <summary>
    /// Represents the risk scores for different levels and the total risk score.
    /// </summary>
    public class RiskScores
    {
        /// <summary>
        /// Gets or sets the minimal risk score level.
        /// </summary>
        public int Minimal { get; set; }

        /// <summary>
        /// Gets or sets the low risk score level.
        /// </summary>
        public int Low { get; set; }

        /// <summary>
        /// Gets or sets the medium risk score level.
        /// </summary>
        public int Medium { get; set; }

        /// <summary>
        /// Gets or sets the high risk score level.
        /// </summary>
        public int High { get; set; }

        /// <summary>
        /// Gets or sets the very high risk score level.
        /// </summary>
        public int VeryHigh { get; set; }

        
    }
}