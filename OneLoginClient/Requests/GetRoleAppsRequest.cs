namespace OneLogin.Requests
{
    public class GetRoleAppsRequest
    {
        /// <summary>
        /// Optional. Defaults to true. Returns all apps not yet assigned to the role.
        /// </summary>
        [JsonPropertyName("assigned")]
        public bool Assigned { get; set; } = true;
    }
}