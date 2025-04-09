
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class SmartHooksResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier for the Smart Hook.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the hook (e.g., "pre-authentication").
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the object containing NPM packages bundled with the hook.
        /// </summary>
        [JsonPropertyName("packages")]
        public Dictionary<string, string> Packages { get; set; }

        /// <summary>
        /// Gets or sets the Node.js runtime version supported for the hook.
        /// </summary>
        [JsonPropertyName("runtime")]
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets the version of the content that will be injected into the hook.
        /// </summary>
        [JsonPropertyName("context_version")]
        public string ContextVersion { get; set; }

        /// <summary>
        /// Gets or sets the number of retries if the hook function fails.
        /// </summary>
        [JsonPropertyName("retries")]
        public int Retries { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds for the hook function execution.
        /// </summary>
        [JsonPropertyName("timeout")]
        public int Timeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the hook is disabled.
        /// </summary>
        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or sets the status of the hook function (e.g., "ready", "create-queued", etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the environment variables available for the hook function.
        /// </summary>
        [JsonPropertyName("env_vars")]
        public List<EnvironmentVariable> EnvVars { get; set; }

        /// <summary>
        /// Gets or sets the conditions associated with the hook (not implemented yet).
        /// </summary>
        [JsonPropertyName("conditions")]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the configuration options for the hook.
        /// </summary>
        [JsonPropertyName("options")]
        public HookOptions Options { get; set; }

        /// <summary>
        /// Gets or sets the ISO8601 date when the hook was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the ISO8601 date when the hook was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// A Base64 encoded representation of the javascript function that will be executed when this hook fires
        /// </summary>
        [JsonPropertyName("function")]
        public string Function { get; set; }
    }

    /// <summary>
    /// Represents an environment variable available for use in the hook.
    /// </summary>
    public class EnvironmentVariable
    {
        /// <summary>
        /// The name of the environment variable.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [JsonPropertyName("value")]
        public required string Value { get; set; }
    }

    /// <summary>
    /// Represents configuration options for a Smart Hook.
    /// </summary>
    public class HookOptions
    {
        /// <summary>
        /// Gets or sets whether location is enabled in the hook context.
        /// </summary>
        [JsonPropertyName("location_enabled")]
        public bool LocationEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether risk is enabled in the hook context.
        /// </summary>
        [JsonPropertyName("risk_enabled")]
        public bool RiskEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether MFA device information is enabled in the hook context.
        /// </summary>
        [JsonPropertyName("mfa_device_info_enabled")]
        public bool MfaDeviceInfoEnabled { get; set; }
    }

    public class EnvironmentVariableValue
    {
        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [JsonPropertyName("value")]
        public required string Value { get; set; }
    }

}
