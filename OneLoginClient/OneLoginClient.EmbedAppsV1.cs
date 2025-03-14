
namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Lists apps accessible by a OneLogin user.
        /// Use the response message to embed users’ OneLogin apps in their views of your company intranet, for example.
        /// </summary>
        /// <param name="email">Provide the email of the user for which you want to return a list of embeddable apps.</param>
        /// <param name="token">Provide your embedding token. To get your embedding token, go to OneLogin and navigate to Settings > Embedding.</param>
        /// <returns>Returns the serialized<see cref = "string" /> as an asynchronous operation.</returns>
        public async Task<string> ListAppsToEmbedForUser(
            string token,
            string email
        )
        {
            var parameters = new Dictionary<string, string?>
                    {
                        { "token", token },
                        { "email", email }
                    };

            parameters = parameters.Where(kvp => kvp.Value != null).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            var queryString = string.Join("&", parameters
                .Where(kv => !string.IsNullOrEmpty(kv.Value))
                .Select(kv => $"{kv.Key}={kv.Value}"));

            var url = $"{Endpoints.ONELOGIN_EMBEDAPPS}{(string.IsNullOrEmpty(queryString) ? "" : "?" + queryString)}";

            return await GetResourceAPIS<string>(url);
        }
    }
}
