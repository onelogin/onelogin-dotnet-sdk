using System.Collections.Generic;
namespace OneLogin.Responses
{
    /// <summary>
    /// A base class for all responses that have returnable data.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <inheritdoc cref="BaseStatusResponse" />
    public abstract class BaseResponse<T> //: BaseStatusResponse
    {
        /// <summary>
        /// Collection of data returned by the API service.
        /// </summary>
        [JsonPropertyName("data")]
        public List<T> Data { get; set; }
    }
}
