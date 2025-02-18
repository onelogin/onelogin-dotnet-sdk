using System.Runtime.Serialization;

namespace OneLogin.Responses
{
    /// <summary>
    /// A base class for Responses that are pageable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <inheritdoc cref="OneLogin.Responses.BaseResponse{T}" />
    public abstract class PaginationBaseResponse<T> : BaseResponse<T>, IPageable
    {
        /// <summary>
        /// When you call a resource API, the response message will include a pagination element like the one shown here:
        /// </summary>
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }

    /// <summary>
    /// Interface for Response that are pageable.
    /// </summary>
    public interface IPageable
    {
        /// <summary>
        /// When you call a resource API, the response message will include a pagination element like the one shown here:
        /// </summary>
        [JsonPropertyName("pagination")]
        Pagination Pagination { get; set; }
    }
}
