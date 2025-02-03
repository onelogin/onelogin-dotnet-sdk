
namespace OneLogin.Requests
{
    /// <summary>
    /// Returns a list of all custom attribute fields (also known as custom user fields) that have been defined for your account.
    /// https://developers.onelogin.com/api-docs/2/users/create-custom-attribute
    /// </summary>
    public class CreateCustomAttributesRequest
    {
        /// <summary>
        /// Gets or sets the user field details.
        /// </summary>
        [JsonPropertyName("user_field")]
        public UserField UserField { get; set; }
    }
    /// <summary>
    /// Represents the details of a user field, such as the name and shortname.
    /// </summary>
    public class UserField
    {
        /// <summary>
        /// Gets or sets the name of the custom field.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name of the custom field.
        /// </summary>
        [JsonPropertyName("shortname")]
        public string Shortname { get; set; }
    }
}
