
namespace OneLogin.Requests
{
    /// <summary>
    /// Request to authenticate a one-time password (OTP) code provided by a multifactor authentication (MFA) device.
    /// If this is the first time that the OTP device has been confirmed, then the device will be updated to have a state of enabled.
    /// </summary>
    public class UpdateUserByIdRequest
    {
        /// <summary>
        /// A username for the user.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// A valid email address for the user.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// The user's last name.
        /// </summary>
        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// The password to set for the user.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Required if the password is being set. Confirms the password.
        /// </summary>
        [JsonPropertyName("password_confirmation")]
        public string PasswordConfirmation { get; set; }

        /// <summary>
        /// The password algorithm used for hashing the password.
        /// Supported values: "salt+sha256", "sha256+salt", "bcrypt".
        /// </summary>
        [JsonPropertyName("password_algorithm")]
        public string PasswordAlgorithm { get; set; }

        /// <summary>
        /// The salt value that was used with the password algorithm (optional).
        /// </summary>
        [JsonPropertyName("salt")]
        public string Salt { get; set; }

        /// <summary>
        /// The user's job title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The user's department.
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }

        /// <summary>
        /// The company the user belongs to.
        /// </summary>
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Free text related to the user (e.g., notes or comments).
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the group in OneLogin to which the user will be assigned.
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// A list of OneLogin Role IDs that the user will be assigned to.
        /// </summary>
        [JsonPropertyName("role_ids")]
        public List<int> RoleIds { get; set; }

        /// <summary>
        /// The user's phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The user's approval status. 
        /// 0: Unapproved, 1: Approved, 2: Rejected, 3: Unlicensed.
        /// </summary>
        [JsonPropertyName("state")]
        public int? State { get; set; }

        /// <summary>
        /// The user's activation status.
        /// 0: Unactivated, 1: Active, 2: Suspended, 3: Locked, 4: Password expired,
        /// 5: Awaiting password reset, 7: Password Pending, 8: Security questions required.
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// The ID of the OneLogin Directory to which the user will be assigned.
        /// </summary>
        [JsonPropertyName("directory_id")]
        public int? DirectoryId { get; set; }

        /// <summary>
        /// The ID of the OneLogin Trusted IDP to which the user will be assigned.
        /// </summary>
        [JsonPropertyName("trusted_idp_id")]
        public int? TrustedIdpId { get; set; }

        /// <summary>
        /// The ID of the user's manager in Active Directory.
        /// </summary>
        [JsonPropertyName("manager_ad_id")]
        public int? ManagerAdId { get; set; }

        /// <summary>
        /// The OneLogin User ID for the user's manager.
        /// </summary>
        [JsonPropertyName("manager_user_id")]
        public int? ManagerUserId { get; set; }

        /// <summary>
        /// The user's Active Directory username (SAMAccountName).
        /// </summary>
        [JsonPropertyName("samaccountname")]
        public string Samaccountname { get; set; }

        /// <summary>
        /// The user's directory membership.
        /// </summary>
        [JsonPropertyName("member_of")]
        public string MemberOf { get; set; }

        /// <summary>
        /// The user's principal name (UPN).
        /// </summary>
        [JsonPropertyName("userprincipalname")]
        public string Userprincipalname { get; set; }

        /// <summary>
        /// The distinguished name of the user in the directory.
        /// </summary>
        [JsonPropertyName("distinguished_name")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// The external ID of the user in an external directory.
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The name configured for use in other applications that accept OpenID for sign-in.
        /// </summary>
        [JsonPropertyName("openid_name")]
        public string OpenidName { get; set; }

        /// <summary>
        /// The number of invalid login attempts made by the user.
        /// </summary>
        [JsonPropertyName("invalid_login_attempts")]
        public int? InvalidLoginAttempts { get; set; }

        /// <summary>
        /// The 2-character language locale for the user, such as "en" for English or "es" for Spanish.
        /// </summary>
        [JsonPropertyName("preferred_locale_code")]
        public string PreferredLocaleCode { get; set; }

        /// <summary>
        /// Custom attributes configured for the user.
        /// </summary>
        [JsonPropertyName("custom_attributes")]
        public Dictionary<string, object> CustomAttributes { get; set; }
    }
}
