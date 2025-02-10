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
        public const string BaseApiWithOutVersion = OneLoginApiBase;
        public const string BaseApi1 = OneLoginApiBase + API + ApiVersion1;
        public const string BaseApi2 = OneLoginApiBase + API + ApiVersion2;

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/users
        /// </summary>
        public const string ONELOGIN_USERS = "users";

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/auth/get_rate_limit
        /// </summary>
        public const string ONELOGIN_RATELIMIT = "auth/rate_limit";

    }
}
