#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncBatchesClient
    {
        /// <summary>
        /// Retrieve batch status<br/>
        /// Use this method to monitor a batch. The response includes the current batch status and counts for queued, processing, ready, failed, and canceled items.<br/>
        /// Poll this method until the batch reaches the `completed`, `canceled`, or `expired` status. To retrieve the results, call the [`GET`](/v1.3/api-reference/analyze-videos/batch-analysis/retrieve-batch-results) method of the `/analyze/batches/{batch_id}/results` endpoint.<br/>
        /// Do not treat the `completed` status as a success signal. It means processing has finished for every item, not that every analysis succeeded. To see how many items succeeded, failed, or were canceled, check the `ready_items`, `failed_items`, and `canceled_items` fields. A batch never has the `failed` status.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeBatchStatusResponse> RetrieveAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve batch status<br/>
        /// Use this method to monitor a batch. The response includes the current batch status and counts for queued, processing, ready, failed, and canceled items.<br/>
        /// Poll this method until the batch reaches the `completed`, `canceled`, or `expired` status. To retrieve the results, call the [`GET`](/v1.3/api-reference/analyze-videos/batch-analysis/retrieve-batch-results) method of the `/analyze/batches/{batch_id}/results` endpoint.<br/>
        /// Do not treat the `completed` status as a success signal. It means processing has finished for every item, not that every analysis succeeded. To see how many items succeeded, failed, or were canceled, check the `ready_items`, `failed_items`, and `canceled_items` fields. A batch never has the `failed` status.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeBatchStatusResponse>> RetrieveAsResponseAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}