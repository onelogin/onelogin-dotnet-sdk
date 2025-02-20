using System.Runtime.Serialization;

namespace OneLogin.Responses
{
    /// <summary>
    /// A list of all OneLogin event types available to the Events API, providing event type names, event type IDs, and descriptions.
    /// </summary>
    public class GetEventTypesResponse : BaseResponse<EventType>
    {
    }

    /// <summary>
    /// A type of event available in the events API.
    /// </summary>
    public class EventType
    {
        /// <summary>
        /// Event types’s unique ID in OneLogin.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Describes the meaning of the event type.  This contains user replaceable values to localize to a particular event.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Event types’s unique name in OneLogin.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
