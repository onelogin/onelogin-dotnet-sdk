
namespace OneLogin.Requests
{
    /// <summary>
    /// Set of fields to be sent when creating a Claim. 
    /// </summary>
    public class CreateUpdateClaimsRequest
    {
        /// <summary>
        /// The attribute name for the claim when it is returned in an Access Token.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A user attribute to map values from. For custom attributes, prefix the name of the attribute with "custom_attribute_".
        /// </summary>
        [JsonPropertyName("user_attribute_mappings")]
        public string UserAttributeMappings { get; set; }

        /// <summary>
        /// When user_attribute_mappings is set to "_macro_", this macro will be used to assign the claim's value.
        /// </summary>
        [JsonPropertyName("user_attribute_macros")]
        public string UserAttributeMacros { get; set; }
    }
}
