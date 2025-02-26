namespace OneLogin.Requests
{
    public class PrivilegeRoleRequest
    {

        /// <summary>
        /// Array of role_ids to which the privilege will be assigned
        /// </summary>
        [JsonPropertyName("roles")]
        public required List<int> Roles { get; set; }
        
    }
}