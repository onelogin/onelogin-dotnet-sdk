namespace OneLogin.Responses
{
    public class GetAppResponse
    {
        /// <summary>
        /// Apps unique ID in OneLogin.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID of the app's underlying connector.
        /// </summary>
        [JsonPropertyName("connector_id")]
        public required long ConnectorId { get; set; }

        /// <summary>
        /// App name.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Freeform description of the app.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Freeform notes about the app.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The security policy assigned to the app.
        /// </summary>
        [JsonPropertyName("policy_id")]
        public int? PolicyId { get; set; }

        /// <summary>
        /// The custom login page branding to use for this app.
        /// </summary>
        [JsonPropertyName("brand_id")]
        public int? BrandId { get; set; }

        /// <summary>
        /// A link to the app's icon URL.
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Indicates if the app is visible in the OneLogin portal.
        /// </summary>
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// An ID indicating the type of app authentication method.
        /// </summary>
        [JsonPropertyName("auth_method")]
        public int AuthMethod { get; set; }

        /// <summary>
        /// ID of the OneLogin portal tab that the app is assigned to.
        /// </summary>
        [JsonPropertyName("tab_id")]
        public int? TabId { get; set; }

        /// <summary>
        /// The date the app was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date the app was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// List of Role IDs that are assigned to the app.
        /// </summary>
        [JsonPropertyName("role_ids")]
        public List<int>? RoleIds { get; set; }

        /// <summary>
        /// Indicates whether or not administrators can access the app as a user that they have assumed control over.
        /// </summary>
        [JsonPropertyName("allow_assumed_signin")]
        public bool AllowAssumedSignin { get; set; }

        /// <summary>
        /// Provisioning object for app attributes.
        /// </summary>
        [JsonPropertyName("provisioning")]
        public Provisioning Provisioning { get; set; }

        /// <summary>
        /// SSO object for app attributes.
        /// </summary>
        [JsonPropertyName("sso")]
        public Sso Sso { get; set; }

        [JsonPropertyName("configuration")]
        public Configuration Configuration { get; set; }

        [JsonPropertyName("parameters")]
        public Dictionary<string, Parameter> Parameters { get; set; }
    }
}