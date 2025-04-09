namespace OneLogin.Requests
{
    public class PrivilegeRequest
    {
        /// <summary>
        /// The name of the privilege.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the privilege.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The privilege details, including version and statements.
        /// </summary>
        [JsonPropertyName("privilege")]
        public required PrivilegeDetails PrivilegeDetails { get; set; }
    }

    /// <summary>
    /// Details of the privilege, including version and associated statements.
    /// </summary>
    public class PrivilegeDetails
    {
        /// <summary>
        /// The version of the privilege schema.
        /// </summary>
        [JsonPropertyName("Version")]
        public required string Version { get; set; }

        /// <summary>
        /// List of statements that define the actions and scope of the privilege.
        /// </summary>
        [JsonPropertyName("Statement")]
        public required List<Statement> Statements { get; set; }
    }

    /// <summary>
    /// Represents a statement detailing the effect, actions, and scope of the privilege.
    /// </summary>
    public class Statement
    {
        /// <summary>
        /// The effect of the action. Set to "Allow" by default.
        /// </summary>
        [JsonPropertyName("Effect")]
        public required string Effect { get; set; }

        /// <summary>
        /// List of actions permitted by this privilege.
        /// </summary>
        [JsonPropertyName("Action")]
        public required List<string> Action { get; set; }

        /// <summary>
        /// List of resources targeted by the actions.
        /// </summary>
        [JsonPropertyName("Scope")]
        public required List<string> Scope { get; set; }
    }
}