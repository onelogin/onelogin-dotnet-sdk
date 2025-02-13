namespace OneLogin.Responses
{
    public class ListAppUsersResponse
    {
        /// <summary>
        /// User's last name.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// User's username.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// User's first name.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// User's SAM account name (if any).
        /// </summary>
        [JsonPropertyName("samaccountname")]
        public string? SamAccountName { get; set; }

        /// <summary>
        /// User's email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}