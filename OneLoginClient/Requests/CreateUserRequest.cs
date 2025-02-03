
namespace OneLogin.Requests
{
    /// <summary>
    /// Set of fields to be sent when creating a user. https://developers.onelogin.com/api-docs/2/users/create-user
    /// </summary>
    public class CreateUserRequest
    {
        /// <summary>
        /// Gets or sets the username for the user. This field is required.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email address for the user. This field is required.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user. This field is optional.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user. This field is optional.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// Gets or sets the password for the user. This field is optional.
        /// </summary>
        [JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Gets or sets the password confirmation for the user. This field is required if the password is set.
        /// </summary>
        [JsonPropertyName("password_confirmation")]
        public string? PasswordConfirmation { get; set; }

        /// <summary>
        /// Gets or sets the password algorithm used for hashing the password. This field is optional.
        /// </summary>
        [JsonPropertyName("password_algorithm")]
        public string? PasswordAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the salt value used with the password algorithm. This field is optional.
        /// </summary>
        [JsonPropertyName("salt")]
        public string? Salt { get; set; }

        /// <summary>
        /// Gets or sets the user's job title. This field is optional.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the user's department. This field is optional.
        /// </summary>
        [JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// Gets or sets the user's company. This field is optional.
        /// </summary>
        [JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Gets or sets any free text related to the user. This field is optional.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets the group ID to which the user will be assigned in OneLogin. This field is optional.
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Gets or sets the list of OneLogin Role IDs that the user will be assigned to. This field is optional.
        /// </summary>
        [JsonPropertyName("role_ids")]
        public List<int>? RoleIds { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number in E.164 format. This field is optional.
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's state (approval status). Optional values: 0 (Unapproved), 1 (Approved), etc.
        /// </summary>
        [JsonPropertyName("state")]
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets the user's status (activation status). Optional values: 0 (Unactivated), 1 (Active), etc.
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets the OneLogin Directory ID to which the user will be assigned. This field is optional.
        /// </summary>
        [JsonPropertyName("directory_id")]
        public int? DirectoryId { get; set; }

        /// <summary>
        /// Gets or sets the OneLogin Trusted IDP ID to which the user will be assigned. This field is optional.
        /// </summary>
        [JsonPropertyName("trusted_idp_id")]
        public int? TrustedIdpId { get; set; }

        /// <summary>
        /// Gets or sets the Active Directory manager ID for the user. This field is optional.
        /// </summary>
        [JsonPropertyName("manager_ad_id")]
        public int? ManagerAdId { get; set; }

        /// <summary>
        /// Gets or sets the OneLogin User ID for the user's manager. This field is optional.
        /// </summary>
        [JsonPropertyName("manager_user_id")]
        public int? ManagerUserId { get; set; }

        /// <summary>
        /// Gets or sets the user's Active Directory username (SAMAccountName). This field is optional.
        /// </summary>
        [JsonPropertyName("samaccountname")]
        public string? Samaccountname { get; set; }

        /// <summary>
        /// Gets or sets the user's directory membership. This field is optional.
        /// </summary>
        [JsonPropertyName("member_of")]
        public string? MemberOf { get; set; }

        /// <summary>
        /// Gets or sets the principal name of the user. This field is optional.
        /// </summary>
        [JsonPropertyName("userprincipalname")]
        public string? Userprincipalname { get; set; }

        /// <summary>
        /// Gets or sets the distinguished name of the user. This field is optional.
        /// </summary>
        [JsonPropertyName("distinguished_name")]
        public string? DistinguishedName { get; set; }

        /// <summary>
        /// Gets or sets the external ID for the user in an external directory. This field is optional.
        /// </summary>
        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the OpenID name for the user. This field is optional.
        /// </summary>
        [JsonPropertyName("openid_name")]
        public string? OpenidName { get; set; }

        /// <summary>
        /// Gets or sets the number of invalid login attempts made by the user. This field is optional.
        /// </summary>
        [JsonPropertyName("invalid_login_attempts")]
        public int? InvalidLoginAttempts { get; set; }

        /// <summary>
        /// Gets or sets the 2-character language locale code for the user (e.g., "en" for English, "es" for Spanish). This field is optional.
        /// </summary>
        [JsonPropertyName("preferred_locale_code")]
        public string? PreferredLocaleCode { get; set; }

        /// <summary>
        /// Gets or sets any custom attributes configured for the user. This field is optional.
        /// </summary>
        [JsonPropertyName("custom_attributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }
    }
}
