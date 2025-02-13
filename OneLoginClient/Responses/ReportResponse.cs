
namespace OneLogin.Responses
{
    /// <summary>
    /// https://developers.onelogin.com/api-docs/2/reports/run-report
    /// </summary>
    public class ReportResponse
    {
        /// <summary>
        /// Gets or sets the report details.
        /// </summary>
        [JsonPropertyName("report")]
        public List<Report> report { get; set; }
    }
    /// <summary>
    /// Represents the details of a report
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Gets or sets the description of report.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the report.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}
