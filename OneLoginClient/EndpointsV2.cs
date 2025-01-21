namespace OneLogin
{
    /// <summary>
    /// Set of OneLogin Resource endpoints.
    /// </summary>
    public static class Endpointsv2
    {
        public const string OneLoginApiBase = "https://api.<us_or_eu>.onelogin.com/";
        /// <summary>
        /// https://api.<region>.onelogin.com/auth/oauth2/v2/token
        /// </summary>
        public const string Token = OneLoginApiBase + "auth/oauth2/v2/token/";
        public const string API = "api/";
        public const string ApiVersion = "2/";
        public const string BaseApi = OneLoginApiBase + API + ApiVersion;

        /// <summary>
        /// https://api.<us_or_eu>.onelogin.com/api/2/users
        /// </summary>
        public const string ONELOGIN_USERS = "users";

    }
}
