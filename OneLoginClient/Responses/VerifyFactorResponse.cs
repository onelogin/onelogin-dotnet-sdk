namespace OneLogin.Response
{
    public class VerifyFactorResponse
    {
        /// <summary>
        /// Provides the SAML assertion.
        /// This field is returned only when MFA is not required.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// A plain text description describing the outcome of the response.
        /// This is typically a status or error message explaining the result of the request.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}