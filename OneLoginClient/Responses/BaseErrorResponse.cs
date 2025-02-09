

namespace OneLogin.Responses
{
    public class BaseErrorResponse
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("field")]
        public string? Field { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

    }

    public class BaseErrorResponseConverter : JsonConverter<BaseErrorResponse>
    {
        public override BaseErrorResponse? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var jsonElement = doc.RootElement;
            var myClass = new BaseErrorResponse();

            // Manually deserialize the JSON properties
            foreach (var property in jsonElement.EnumerateObject())
            {
                switch (property.Name)
                {
                    case "error":
                        myClass.Name = property.Value.GetString();
                        break;
                    case "description":  // Apply the condition here
                        myClass.Message = property.Value.GetString();
                        break;
                    case "status":
                        myClass.StatusCode = property.Value.GetInt32();
                        break;
                }
            }

            return myClass;
        }

        public override void Write(Utf8JsonWriter writer, BaseErrorResponse value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}