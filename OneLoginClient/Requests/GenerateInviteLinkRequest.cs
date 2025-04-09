using System.Runtime.Serialization;

namespace OneLogin.Requests
{
    /// <summary>
    /// Generate an invite link for a user that you have already created in your OneLogin account.
    /// </summary>
    public class GenerateInviteLinkRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
