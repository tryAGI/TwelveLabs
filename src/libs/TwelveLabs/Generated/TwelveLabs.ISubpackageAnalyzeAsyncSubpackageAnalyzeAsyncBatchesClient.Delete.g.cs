#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncBatchesClient
    {
        /// <summary>
        /// Delete a batch<br/>
        /// Use this method to delete a batch and all the tasks associated with it. You can only delete batches with status `completed`, `canceled`, or `expired`.<br/>
        /// Deleting a batch does not affect billing. You are billed for every completed analysis regardless of whether you delete the batch afterward.<br/>
        /// To stop a batch with the `pending` or `processing` status, use the [`POST`](/v1.3/api-reference/analyze-videos/batch-analysis/cancel-batch) method of the `/analyze/batches/{batch_id}/cancel` endpoint.<br/>
        /// Batches are deleted 30 days after creation.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeAsyncBatchesDeleteResponse204> DeleteAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a batch<br/>
        /// Use this method to delete a batch and all the tasks associated with it. You can only delete batches with status `completed`, `canceled`, or `expired`.<br/>
        /// Deleting a batch does not affect billing. You are billed for every completed analysis regardless of whether you delete the batch afterward.<br/>
        /// To stop a batch with the `pending` or `processing` status, use the [`POST`](/v1.3/api-reference/analyze-videos/batch-analysis/cancel-batch) method of the `/analyze/batches/{batch_id}/cancel` endpoint.<br/>
        /// Batches are deleted 30 days after creation.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeAsyncBatchesDeleteResponse204>> DeleteAsResponseAsync(
            string batchId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}