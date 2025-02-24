
namespace OneLogin.Requests
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class SmartHooksRequest
    {
        /// <summary>
        /// Gets or sets the type of the hook (e.g., "pre-authentication").
        /// </summary>
        [JsonPropertyName("type")]
        public required string Type { get; set; }

        /// <summary>
        /// Gets or sets the object containing NPM packages bundled with the hook.
        /// </summary>
        [JsonPropertyName("packages")]
        public required Dictionary<string, string> Packages { get; set; }

        /// <summary>
        /// Gets or sets the Node.js runtime version supported for the hook.
        /// </summary>
        [JsonPropertyName("runtime")]
        public required string Runtime { get; set; }

        /// <summary>
        /// Gets or sets the version of the content that will be injected into the hook.
        /// </summary>
        [JsonPropertyName("context_version")]
        public string ContextVersion { get; set; }

        /// <summary>
        /// Gets or sets the number of retries if the hook function fails.
        /// </summary>
        [JsonPropertyName("retries")]
        public required int Retries { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds for the hook function execution.
        /// </summary>
        [JsonPropertyName("timeout")]
        public required int Timeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the hook is disabled.
        /// </summary>
        [JsonPropertyName("disabled")]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Gets or sets the status of the hook function (e.g., "ready", "create-queued", etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the environment variables available for the hook function.
        /// </summary>
        [JsonPropertyName("env_vars")]
        public required List<EnvironmentVariable> EnvVars { get; set; }

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
        /// A Base64 encoded representation of the javascript function that will be executed when this hook fires
        /// </summary>
        [JsonPropertyName("function")]
        public required string Function { get; set; }
    }

}
