namespace OneLogin
{
    /// <summary>
    /// Set of OneLogin Resource endpoints.
    /// </summary>
    public static class Endpoints
    {
        /// <summary>
        /// https://api_domain/auth/oauth2/v2/token
        /// </summary>
        public const string Token = "/auth/oauth2/v2/token/";
        public const string RevokeToken = "/auth/oauth2/revoke/";
        public const string BaseApiVersion2 = "/api/2/";
        public const string BaseApiVersion1 = "/api/1/";

        /// <summary>
        /// https://api_domain/api/2/users
        /// </summary>
        public const string ONELOGIN_USERS = "users";

        /// <summary>
        /// https://api_domain/api/2/roles
        /// </summary>
        public const string ONELOGIN_ROLES = "roles";

        /// <summary>
        /// https://api_domain/api/2/connectors
        /// </summary>
        public const string ONELOGIN_CONNECTORS = "connectors";

        /// <summary>
        /// https://api_domain/api/2/apps
        /// </summary>
        public const string ONELOGIN_APPS = "apps";

        /// <summary>
        /// https://api_domain/api/2/reports
        /// </summary>
        public const string ONELOGIN_REPORTS = "reports";

        /// <summary>
        /// https://api_domain/api/2/saml-assertions
        /// </summary>
        public const string ONELOGIN_SAMLASSERTIONS = "saml-assertions";

        /// <summary>
        /// https://api_domain/api/2/smart-mfa
        /// </summary>
        public const string ONELOGIN_SMARTMFA = "smart-mfa";

        /// <summary>
        /// https://developers.onelogin.com/api-docs/1/events/get-events
        /// </summary>
        public const string ONELOGIN_EVENTS = "events";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/1/invites/get_invite_link
        /// </summary>
        public const string ONELOGIN_INVITES = "invites";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/1/groups
        /// </summary>
        public const string ONELOGIN_GROUPS = "groups";

    }
}
