#nullable enable

namespace TwelveLabs
{
    public partial interface IAnalyzeAsyncTasksClient
    {
        /// <summary>
        /// Cancel an async analysis task<br/>
        /// Use this method to cancel an asynchronous analysis task in your account. To cancel a task created as part of a batch, use the [`POST`](/v1.3/api-reference/analyze-videos/batch-analysis/cancel-batch) method of the `/analyze/batches/{batch_id}/cancel` endpoint.<br/>
        /// You can cancel a task with the `queued`, `pending`, or `processing` status. This action cannot be undone.<br/>
        /// Processing that has already started can continue briefly after cancellation.<br/>
        /// When you cancel a task, the platform can send an `analyze.task.canceled` webhook. Delivery is best-effort: a `200` response is not a delivery guarantee. When you receive the event, retrieve the task for its current state.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.CancelAnalyzeTaskResponse> CancelAsync(
            string taskId,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel an async analysis task<br/>
        /// Use this method to cancel an asynchronous analysis task in your account. To cancel a task created as part of a batch, use the [`POST`](/v1.3/api-reference/analyze-videos/batch-analysis/cancel-batch) method of the `/analyze/batches/{batch_id}/cancel` endpoint.<br/>
        /// You can cancel a task with the `queued`, `pending`, or `processing` status. This action cannot be undone.<br/>
        /// Processing that has already started can continue briefly after cancellation.<br/>
        /// When you cancel a task, the platform can send an `analyze.task.canceled` webhook. Delivery is best-effort: a `200` response is not a delivery guarantee. When you receive the event, retrieve the task for its current state.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.CancelAnalyzeTaskResponse>> CancelAsResponseAsync(
            string taskId,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}