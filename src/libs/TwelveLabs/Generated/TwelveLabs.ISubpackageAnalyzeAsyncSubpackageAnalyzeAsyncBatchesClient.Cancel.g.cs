#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncBatchesClient
    {
        /// <summary>
        /// Cancel a batch<br/>
        /// Use this method to request cancellation for a batch with the `pending` or `processing` status.<br/>
        /// When you invoke this method, the platform performs the following steps:<br/>
        /// - Cancels the items in the `queued` status.<br/>
        /// - Finishes the analysis for the items in the `processing` status.<br/>
        /// The batch status changes to `canceling` immediately, and to `canceled` after every item reaches `ready`, `failed`, or `canceled`. You are not billed for canceled or failed items.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeBatchStatusResponse> CancelAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a batch<br/>
        /// Use this method to request cancellation for a batch with the `pending` or `processing` status.<br/>
        /// When you invoke this method, the platform performs the following steps:<br/>
        /// - Cancels the items in the `queued` status.<br/>
        /// - Finishes the analysis for the items in the `processing` status.<br/>
        /// The batch status changes to `canceling` immediately, and to `canceled` after every item reaches `ready`, `failed`, or `canceled`. You are not billed for canceled or failed items.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeBatchStatusResponse>> CancelAsResponseAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}