
namespace OneLogin.Responses
{
    /// <summary>
    /// This call returns up to 50 users per page.
    /// </summary>
    /// <summary>
    /// A user of the OneLogin platform.
    /// </summary>
    public class GetUserResponse
    {
        /// <summary>
        /// Date and time at which the user’s status was set to 1 (active).
        /// </summary>
        [JsonPropertyName("activated_at")]
        public DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// Date and time at which the user was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// User’s email address, which they also use to log in to OneLogin.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// If the user’s directory is set to authenticate using a user name value, this is the value used to sign in.
        /// </summary>
        [JsonPropertyName("username")]
        public string? UserName { get; set; }

        /// <summary>
        /// User’s first name.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Group to which the user belongs.
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// User’s unique ID in OneLogin.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Number of sequential invalid login attempts the user has made.
        /// </summary>
        [JsonPropertyName("invalid_login_attempts")]
        public int? InvalidLoginAttempts { get; set; }

        /// <summary>
        /// Date and time at which an invitation to OneLogin was sent to the user.
        /// </summary>
        [JsonPropertyName("invitation_sent_at")]
        public DateTime? InvitationSentAt { get; set; }

        /// <summary>
        /// Date and time of the user’s last login.
        /// </summary>
        [JsonPropertyName("last_login")]
        public DateTime? LastLogin { get; set; }

        /// <summary>
        /// User’s last name.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string? LastName { get; set; }

        /// <summary>
        /// Date and time at which the user’s account will be unlocked.
        /// </summary>
        [JsonPropertyName("locked_until")]
        public string? LockedUntil { get; set; }

        /// <summary>
        /// Notes entered about the user.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Date and time at which the user’s password was last changed.
        /// </summary>
        [JsonPropertyName("password_changed_at")]
        public DateTime? PasswordChangedAt { get; set; }

        /// <summary>
        /// User’s phone number.
        /// </summary>
        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Determines the user’s ability to log in to OneLogin.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("status")]
        public StatusType? Status { get; set; }

        /// <summary>
        /// Date and time at which the user’s information was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("distinguished_name")]
        public string? DistinguishedName { get; set; }

        [JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        [JsonPropertyName("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [JsonPropertyName("member_of")]
        public string? MemberOf { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [JsonPropertyName("samaccountname")]
        public string? SamAccountName { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [JsonPropertyName("userprincipalname")]
        public string? UserPrincipalName { get; set; }

        /// <summary>
        /// ID of the user’s manager in Active Directory.
        /// </summary>
        [JsonPropertyName("manager_ad_id")]
        public string? ManagerAdId { get; set; }

        [JsonPropertyName("manager_user_id")]
        public string? ManagerUserId { get; set; }

        /// <summary>
        /// Role IDs to which the user is assigned.
        /// </summary>
        [JsonPropertyName("role_id")]
        public List<int>? RoleId { get; set; }

        [JsonPropertyName("company")]
        public string? Company { get; set; }

        [JsonPropertyName("department")]
        public string? Department { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("preferred_locale_code")]
        public string? PreferredLocaleCode { get; set; }

        /// <summary>
        /// Represents the user’s stage in a process (such as user account approval).
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("state")]
        public State State { get; set; }

        [JsonPropertyName("trusted_idp_id")]
        public int? TrustedIdpId { get; set; }

        /// <summary>
        /// Provides a list of custom attribute fields (also known as custom user fields).
        /// </summary>
        [JsonPropertyName("custom_attributes")]
        public Dictionary<string, string>? CustomAttributes { get; set; }
    }
}
