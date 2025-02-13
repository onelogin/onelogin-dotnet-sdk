
namespace OneLogin
{
    public partial class OneLoginClient
    {
        /// <summary>
        /// Use this API to return a list of reports
        /// https://developers.onelogin.com/api-docs/2/reports/list-reports
        /// </summary>
        /// <returns></returns>
        /// TODO : This api throws error on the server.
        //public async Task<ApiResponse<List<>>> ListReports()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions and return an error response
        //    }
        //}


        /// <summary>
        /// Use this API to run a given report on the spot
        /// https://developers.onelogin.com/api-docs/2/reports/run-report
        /// </summary>
        /// <param name="Id">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<ReportResponse>> RunReport(int Id, EmptyResponse request)
        {
            try
            {
                return await PostResource<ReportResponse>($"{Endpoints.ONELOGIN_REPORTS}/{Id}/run", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<ReportResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }

        /// <summary>
        /// Use this API to run a given report in the background and return its results in CSV format to a specified email address.
        /// https://developers.onelogin.com/api-docs/2/reports/run-report-in-background
        /// </summary>
        /// <param name="Id">id of the app.</param>
        /// <param name="request">The request object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<BackgroundReportResponse>> RunReportInBackground(int Id, BackgroundReportRequest request)
        {
            try
            {
                return await PostResource<BackgroundReportResponse>($"{Endpoints.ONELOGIN_REPORTS}/{Id}/run_background", request, Endpoints.BaseApi2);
            }
            catch (Exception ex)
            {
                return new ApiResponse<BackgroundReportResponse>(status: new BaseErrorResponse { Message = ex.Message, StatusCode = 500 });
            }
        }
    }
}
