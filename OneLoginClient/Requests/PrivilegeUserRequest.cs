namespace OneLogin.Requests
{
    public class PrivilegeUserRequest
    {

        /// <summary>
        /// Array of user_ids to which the privilege will be assigned
        /// </summary>
        [JsonPropertyName("users")]
        public required List<int> Users { get; set; }
        
    }
}