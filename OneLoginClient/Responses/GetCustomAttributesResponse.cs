using System.Text.Json.Serialization;

namespace OneLogin.Responses
{
    /// <summary>
    /// Returns a list of all custom attribute fields (also known as custom user fields) that have been defined for your account.
    /// https://developers.onelogin.com/api-docs/2/users/list-custom-attributes
    /// </summary>
    public class GetCustomAttributesResponse
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("shortname")]
        public string? Shortname { get; set; }
    }
}
