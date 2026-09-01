#nullable enable

namespace TwelveLabs
{
    public partial interface IAnalyzeAsyncTasksClient
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
        /// - `canceled`: The task was canceled. The task cannot become `ready`, and no result is available.<br/>
        /// Poll this method until `status` is `ready`, `failed`, or `canceled`. When `status` is `ready`, use the results from the response. The platform does not emit an `analyze.task.canceled` webhook. For an individual task without a terminal task webhook, poll this method with exponential backoff and jitter until the task reaches a terminal status. For a batch-owned task, prefer the parent batch's `analyze.batch.canceled` or `analyze.batch.expired` webhook and retrieve the batch status and results instead of polling every item.
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
        /// <summary>
        /// Retrieve analysis task status and results<br/>
        /// This method retrieves the status and results of an analysis task.<br/>
        /// **Task statuses**:<br/>
        /// - `queued`: The task is waiting to be processed.<br/>
        /// - `pending`: The task is queued and waiting to start.<br/>
        /// - `processing`: The platform is analyzing the video.<br/>
        /// - `ready`: Processing is complete. Results are available in the response.<br/>
        /// - `failed`: The task failed. No results were generated.<br/>
        /// - `canceled`: The task was canceled. The task cannot become `ready`, and no result is available.<br/>
        /// Poll this method until `status` is `ready`, `failed`, or `canceled`. When `status` is `ready`, use the results from the response. The platform does not emit an `analyze.task.canceled` webhook. For an individual task without a terminal task webhook, poll this method with exponential backoff and jitter until the task reaches a terminal status. For a batch-owned task, prefer the parent batch's `analyze.batch.canceled` or `analyze.batch.expired` webhook and retrieve the batch status and results instead of polling every item.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeTaskResponse>> RetrieveAsResponseAsync(
            string taskId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}