#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncTasksClient
    {
        /// <summary>
        /// List async analysis tasks<br/>
        /// This method returns a list of the analysis tasks in your account. The platform returns your analysis tasks sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="status">
        /// The current status of the analysis task.
        /// </param>
        /// <param name="videoUrl"></param>
        /// <param name="assetId"></param>
        /// <param name="videoId"></param>
        /// <param name="analysisMode"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeAsyncTasksListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AnalyzeTaskStatus? status = default,
            string? videoUrl = default,
            string? assetId = default,
            string? videoId = default,
            global::TwelveLabs.AnalyzeTasksGetParametersAnalysisMode? analysisMode = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}