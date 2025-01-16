using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OneLogin.Types;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OneLogin.Responses
{
    public class CreateUserResponsev2 : BaseResponse<UserResponse>
    {
        /// <summary>
        /// Date and time at which the user was created.
        /// </summary>
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// User’s email address, which he also uses to log in to OneLogin.
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// If the user’s directory is set to authenticate using a user name value, this is the value used to sign in.
        /// </summary>
        [DataMember(Name = "username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// User’s first name.
        /// </summary>
        [DataMember(Name = "firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "company")]
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "comment")]
        public string comment { get; set; }

        /// <summary>
        /// The Department the user belongs to.
        /// </summary>
        [DataMember(Name = "department")]
        public string Department { get; set; }

        /// <summary>
        /// Group to which the user belongs.
        /// </summary>
        [DataMember(Name = "group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Role IDs to which the user is assigned.
        /// </summary>
        [DataMember(Name = "role_id")]
        public List<int> RoleId { get; set; }

        /// <summary>
        /// Number of sequential invalid login attempts the user has made that is less than or equal to the Maximum invalid login attempts value defined on the Session page in OneLogin.
        /// When this number reaches this value, the user account will be locked for the amount of time defined by the Lock effective period field on the Session page and this value will be reset to 0.
        /// </summary>
        [DataMember(Name = "invalid_login_attempts")]
        public int? InvalidLoginAttempts { get; set; }

        /// <summary>
        /// User’s last name.
        /// </summary>
        [DataMember(Name = "lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// OpenID URL that can be configured in other applications that accept OpenID for sign-in.
        /// </summary>
        [DataMember(Name = "openid_name")]
        public string OpenIdName { get; set; }

        /// <summary>
        /// Represents a geographical, political, or cultural region. Some features may use the locale value to tailor the display of information, such as numbers, for the user based on locale-specific customs and conventions.
        /// </summary>
        [DataMember(Name = "locale_code")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// User’s phone number.
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Represents the user’s stage in a process (such as user account approval). User state determines the possible statuses a user account can be in.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "state")]
        public State State { get; set; }

        /// <summary>
        /// Determines the user’s ability to log in to OneLogin.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "status")]
        public StatusType? Status { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [DataMember(Name = "distinguished_name")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// External ID that can be used to uniquely identify the user in another system.
        /// </summary>
        [DataMember(Name = "external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// ID of the directory (Active Directory, LDAP, for example) from which the user was created.
        /// </summary>
        [DataMember(Name = "directory_id")]
        public int? DirectoryId { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [DataMember(Name = "member_of")]
        public string MemberOf { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [DataMember(Name = "samaccountname")]
        public string SamAccountName { get; set; }

        /// <summary>
        /// Synchronized from Active Directory.
        /// </summary>
        [DataMember(Name = "userprincipalname")]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// ID of the user’s manager in Active Directory.
        /// </summary>
        [DataMember(Name = "manager_ad_id")]
        public string ManagerAdId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "manager_user_id")]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// Password of the user’s manager in Active Directory.
        /// </summary>
        [DataMember(Name = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Required if the password is being set.
        /// </summary>
        [DataMember(Name = "password_confirmation")]
        public string PasswordConfirmation { get; set; }

        /// <summary>
        /// Use this when importing a password that’s already hashed.
        /// </summary>
        [DataMember(Name = "password_algorithm")]
        public string PasswordAlgorithm { get; set; }

        /// <summary>
        /// The salt value used with the password_algorithm.
        /// </summary>
        [DataMember(Name = "salt")]
        public string Salt { get; set; }


        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "trusted_idp_id")]
        public string TrustedIdpId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "preferred_locale_code")]
        public string PreferredLocaleCode { get; set; }


        /// <summary>
        /// Provides a list of custom attribute fields (also known as custom user fields) that are available for your account.
        /// The values returned correspond to the values you provided in the Shortname field when you defined the custom user field.
        /// </summary>
        [DataMember(Name = "custom_attributes")]
        public Dictionary<string, string> CustomAttributes { get; set; }

        /// <summary>
        /// User’s unique ID in OneLogin.
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }
        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "last_login")]
        public int LastLogin { get; set; }

        /// <summary>
        /// Date and time at which the user’s password was last changed.
        /// </summary>
        [DataMember(Name = "password_changed_at")]
        public DateTime? PasswordChangedAt { get; set; }

        /// <summary>
        /// Date and time at which the user’s information was last updated.
        /// </summary>
        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Date and time at which the user’s status was set to 1 (active).
        /// </summary>
        [DataMember(Name = "activated_at")]
        public DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// Date and time at which an invitation to OneLogin was sent to the user.
        /// </summary>
        [DataMember(Name = "invitation_sent_at")]
        public DateTime? InvitationSentAt { get; set; }

        /// <summary>
        /// Date and time at which the user’s account will be unlocked.
        /// </summary>
        [DataMember(Name = "locked_until")]
        public string LockedUntil { get; set; }




    }
}
