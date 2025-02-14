namespace OneLogin
{
    /// <summary>
    /// Set of OneLogin Resource endpoints.
    /// </summary>
    public static class Endpoints
    {
        public const string OneLoginApiBase = "https://api.<us_or_eu>.onelogin.com/";
        /// <summary>
        /// https://api.<region>.onelogin.com/auth/oauth2/v2/token
        /// </summary>
        public const string Token = OneLoginApiBase + "auth/oauth2/v2/token/";
        public const string RevokeToken = OneLoginApiBase + "auth/oauth2/revoke/";
        public const string API = "api/";
        public const string ApiVersion2 = "2/";
        public const string ApiVersion1 = "1/";
        public const string BaseApi1 = OneLoginApiBase + API + ApiVersion1;
        public const string BaseApi2 = OneLoginApiBase + API + ApiVersion2;

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/users
        /// </summary>
        public const string ONELOGIN_USERS = "users";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/roles
        /// </summary>
        public const string ONELOGIN_ROLES = "roles";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/connectors
        /// </summary>
        public const string ONELOGIN_CONNECTORS = "connectors";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/apps
        /// </summary>
        public const string ONELOGIN_APPS = "apps";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/reports
        /// </summary>
        public const string ONELOGIN_REPORTS = "reports";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/saml-assertions
        /// </summary>
        public const string ONELOGIN_SAMLASSERTIONS = "saml-assertions";

    }
}
