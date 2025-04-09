namespace OneLogin.Types
{
    /// <summary>
    /// </summary>
    public class Parameter
    {
        [JsonPropertyName("values")]
        public string? Values { get; set; }

        [JsonPropertyName("user_attribute_mappings")]
        public string? UserAttributeMappings { get; set; }

        [JsonPropertyName("provisioned_entitlements")]
        public bool ProvisionedEntitlements { get; set; }

        [JsonPropertyName("skip_if_blank")]
        public bool SkipIfBlank { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("default_values")]
        public string? DefaultValues { get; set; }

        [JsonPropertyName("attributes_transformations")]
        public string? AttributesTransformations { get; set; }

        [JsonPropertyName("safe_entitlements_enabled")]
        public bool SafeEntitlementsEnabled { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("user_attribute_macros")]
        public string? UserAttributeMacros { get; set; }
    }
}
