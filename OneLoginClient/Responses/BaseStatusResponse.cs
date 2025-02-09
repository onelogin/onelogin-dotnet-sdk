namespace OneLogin.Responses
{
    /// <summary>
    /// The base class for all responses that have a status element.
    /// </summary>
    public class BaseStatusResponse
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        [JsonPropertyName("status")]
        public Status Status { get; set; }
    }
}
