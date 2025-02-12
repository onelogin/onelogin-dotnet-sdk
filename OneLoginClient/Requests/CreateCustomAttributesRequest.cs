
namespace OneLogin.Requests
{
    /// <summary>
    /// Set of fields to be sent when creating and updating custom attributes.
    /// https://developers.onelogin.com/api-docs/2/users/create-custom-attribute
    /// https://developers.onelogin.com/api-docs/2/users/update-custom-attribute
    /// </summary>
    public class CreateUpdateCustomAttributesRequest
    {
        /// <summary>
        /// Gets or sets the user field details.
        /// </summary>
        [JsonPropertyName("user_field")]
        public required UserField UserField { get; set; }
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
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name of the custom field.
        /// </summary>
        [JsonPropertyName("shortname")]
        public required string Shortname { get; set; }
    }
}
