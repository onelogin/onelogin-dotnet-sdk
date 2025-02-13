
namespace OneLogin.Responses
{
    /// <summary>
    /// The Apps API can be used to list, create, update and manage apps in onelogin account.
    /// </summary>
    public class ListAppResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("connector_id")]
        public long ConnectorId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("auth_method_description")]
        public string Auth_Method_Description { get; set; }

        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        [JsonPropertyName("auth_method")]
        public int AuthMethod { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
