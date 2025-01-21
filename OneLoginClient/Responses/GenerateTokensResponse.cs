using System.Text.Json.Serialization;

namespace OneLogin.Responses
{
    /// <summary>
    /// Serialized response to generating a token.
    /// <a href="https://developers.onelogin.com/api-docs/2/oauth20-tokens/generate-tokens">Documentation</a>
    /// </summary>
    /// 
    public class GenerateTokensResponse
    {
        /// <summary>
        /// An access token has a rate limit of 5,000 calls per hour. If an access token surpasses this limit, API calls will return an error. After the hour has passed, the count will be reset to a full 5,000 available calls.
        /// </summary>

        /// <summary>
        /// Provides the requested access token. You can use this token to call our resource APIs.
        /// </summary>
        [JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// Time at which the access token was generated.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Indicates that the generated access token expires in 36,000 seconds, 600 minutes, or 10 hours.
        /// An expired access token cannot be used to make resource API calls, but it can still be used along with its associated <a href="https://developers.onelogin.com/api-docs/2/oauth20-tokens/refresh-tokens">Refresh Token</a> to call the Refresh Tokens API.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// Provides the refresh token that is uniquely paired with the access token. You can use this token to request a refresh to its associated access token.
        /// For more information about refreshing access tokens, see <a href="https://developers.onelogin.com/api-docs/2/oauth20-tokens/refresh-tokens">Refresh Token</a>.
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Indicates that the generated access token is a bearer token.
        /// </summary>
        [JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// Account ID associated with the API credentials used to generate the token.
        /// </summary>
        [JsonPropertyName("account_id")]
        public long AccountId { get; set; }
    }
}
