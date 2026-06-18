#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncBatchesClient
    {
        /// <summary>
        /// Retrieve batch results<br/>
        /// Use this method to retrieve the results for each item in a batch. You can call it while the batch has the `pending` or `processing` status.<br/>
        /// Each result entry has a status. For details on each status, see the [Item statuses](/v1.3/api-reference/analyze-videos/batch-analysis/the-batch-object#item-statuses) section on the **The batch object** page.<br/>
        /// Each result entry includes a task identifier in the `task_id` field. Use this value with the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint if you need the full analysis task response.<br/>
        /// You can retrieve results for 30 days after batch creation.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.BatchResultItem> ResultsAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve batch results<br/>
        /// Use this method to retrieve the results for each item in a batch. You can call it while the batch has the `pending` or `processing` status.<br/>
        /// Each result entry has a status. For details on each status, see the [Item statuses](/v1.3/api-reference/analyze-videos/batch-analysis/the-batch-object#item-statuses) section on the **The batch object** page.<br/>
        /// Each result entry includes a task identifier in the `task_id` field. Use this value with the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint if you need the full analysis task response.<br/>
        /// You can retrieve results for 30 days after batch creation.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.BatchResultItem>> ResultsAsResponseAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}