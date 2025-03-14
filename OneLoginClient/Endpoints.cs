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
        /// https://api_domain/api/1/invites/get_invite_link
        /// </summary>
        public const string ONELOGIN_INVITES = "invites";

        /// <summary>
        /// https://api_domain/api/1/groups
        /// </summary>
        public const string ONELOGIN_GROUPS = "groups";

        /// <summary>
        /// https://developers.onelogin.com/api-docs/2/multi-factor-authentication/overview
        /// </summary>
        public const string ONELOGIN_MFA = "mfa/" + ONELOGIN_USERS;

        /// <summary>
        /// https://<api_domain>/api/2/api_authorizations
        /// </summary>
        public const string ONELOGIN_APIAUTHORIZATIONS = "api_authorizations";

        /// <summary>
        /// https://<api_domain>/api/2/risk
        /// </summary>
        public const string ONELOGIN_VIGILANCEAI = "risk";

        /// <summary>
        /// https://<api_domain>/api/2/risk/rules
        /// </summary>
        public const string ONELOGIN_VIGILANCEAI_RULES = "risk/rules";

        /// <summary>
        /// https://<api_domain>/api/2/hooks
        /// </summary>
        public const string ONELOGIN_SMARTHOOKS = "hooks";

        /// <summary>
        /// https://<api_domain>/api/2/hooks/envs
        /// </summary>
        public const string ONELOGIN_SMARTHOOKSENVS = ONELOGIN_SMARTHOOKS + "/envs";

        /// <summary>
        /// https://<api_domain>/api/1/privileges
        /// </summary>
        public const string ONELOGIN_PRIVILEGES = "privileges";

        /// <summary>
        /// https://<api_domain>/api/2/branding/brands
        /// </summary>
        public const string ONELOGIN_BRANDING = "branding/brands";

        /// <summary>
        /// https://<api_domain>/api/2/branding/custom_error_messages
        /// </summary>
        public const string ONELOGIN_CUSTOM_ERROR_MESSAGES = "custom_error_messages";

        /// <summary>
        /// https://<api_domain>/api/2/mappings
        /// </summary>
        public const string ONELOGIN_MAPPINGS = "mappings";

        /// <summary>
        /// https://<api_domain>/client/apps/embed2
        /// </summary>
        public const string ONELOGIN_EMBEDAPPS = "/client/apps/embed2";

        /// <summary>
        /// https://<api_domain>/api/1/login
        /// </summary>
        public const string ONELOGIN_LOGINPAGES = "login";

    }
}
