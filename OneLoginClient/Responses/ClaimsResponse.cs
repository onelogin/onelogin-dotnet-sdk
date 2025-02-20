
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class ClaimsResponse
    {
        /// <summary>
        /// The unique ID of the claim.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The UI label for the claim.
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// A user attribute to map values from.
        /// </summary>
        [JsonPropertyName("user_attribute_mappings")]
        public string? UserAttributeMappings { get; set; }

        /// <summary>
        /// When user_attribute_mappings is set to "_macro_", this macro will be used to assign the claim's value.
        /// </summary>
        [JsonPropertyName("user_attribute_macros")]
        public string? UserAttributeMacros { get; set; }

        /// <summary>
        /// The type of transformation to perform on multi-valued attributes.
        /// </summary>
        [JsonPropertyName("attributes_transformations")]
        public string? AttributesTransformations { get; set; }

        /// <summary>
        /// Not used. A flag to skip if the value is blank.
        /// </summary>
        [JsonPropertyName("skip_if_blank")]
        public bool? SkipIfBlank { get; set; }

        /// <summary>
        /// Relates to Rules/Entitlements. Not supported yet.
        /// </summary>
        [JsonPropertyName("values")]
        public List<string>? Values { get; set; }

        /// <summary>
        /// Relates to Rules/Entitlements. Not supported yet.
        /// </summary>
        [JsonPropertyName("default_values")]
        public string? DefaultValues { get; set; }

        /// <summary>
        /// Relates to Rules/Entitlements. Not supported yet.
        /// </summary>
        [JsonPropertyName("provisioned_entitlements")]
        public bool? ProvisionedEntitlements { get; set; }

        /// <summary>
        /// Relates to Rules/Entitlements. Not supported yet.
        /// </summary>
        [JsonPropertyName("safe_entitlements_enabled")]
        public bool? SafeEntitlementsEnabled { get; set; }
    }

}
