
namespace OneLogin.Responses
{
    /// <summary>
    /// Response message containing the status of the request.
    /// </summary>
    public class ApiResponse<T>
    {
        public BaseErrorResponse? Status { get; set; }
        public T? Data { get; set; }

        public ApiResponse( T? data = default, BaseErrorResponse? status = null)
        {
            Data = data;
            Status = status;
        }

        public ApiResponse(BaseErrorResponse? status)
        {
            Status = status;
        }
    }
}
