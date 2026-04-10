#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncTasksClient
    {
        /// <summary>
        /// Retrieve analysis task status and results<br/>
        /// This method retrieves the status and results of an analysis task.<br/>
        /// **Task statuses**:<br/>
        /// - `queued`: The task is waiting to be processed.<br/>
        /// - `pending`: The task is queued and waiting to start.<br/>
        /// - `processing`: The platform is analyzing the video.<br/>
        /// - `ready`: Processing is complete. Results are available in the response.<br/>
        /// - `failed`: The task failed. No results were generated.<br/>
        /// Poll this method until `status` is `ready` or `failed`. When `status` is `ready`, use the results from the response.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeTaskResponse> RetrieveAsync(
            string taskId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}