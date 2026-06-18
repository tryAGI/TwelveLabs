#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncBatchesClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Use this method to submit many video analysis requests in a single call. Each request creates an analysis task. The response contains one batch identifier and one task identifier per request. Use the batch identifier to check progress and retrieve results.<br/>
        /// &lt;Note title="Model requirement"&gt;<br/>
        /// You must use Pegasus 1.5 for batch analysis. Set the `model_name` parameter to `pegasus1.5`.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Run the same model and analysis settings across many videos.<br/>
        /// - Track a single batch instead of many individual analysis tasks.<br/>
        /// **Do not use this method for**:<br/>
        /// - Single videos that require immediate results. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// - Background processing of a single video. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// **Retention and retry**:<br/>
        /// - Batches expire 24 hours after creation. You can retrieve results for 30 days after creation.<br/>
        /// - If processing does not finish for some items in time, resubmit them in a new batch.<br/>
        /// **Limits**:<br/>
        /// - Up to 1,000 requests per batch.<br/>
        /// - Up to 2,000 total content hours per batch.<br/>
        /// - Up to 5 active batches per account.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.CreateAnalyzeBatchResponse> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateAnalyzeBatchRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Use this method to submit many video analysis requests in a single call. Each request creates an analysis task. The response contains one batch identifier and one task identifier per request. Use the batch identifier to check progress and retrieve results.<br/>
        /// &lt;Note title="Model requirement"&gt;<br/>
        /// You must use Pegasus 1.5 for batch analysis. Set the `model_name` parameter to `pegasus1.5`.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Run the same model and analysis settings across many videos.<br/>
        /// - Track a single batch instead of many individual analysis tasks.<br/>
        /// **Do not use this method for**:<br/>
        /// - Single videos that require immediate results. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// - Background processing of a single video. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// **Retention and retry**:<br/>
        /// - Batches expire 24 hours after creation. You can retrieve results for 30 days after creation.<br/>
        /// - If processing does not finish for some items in time, resubmit them in a new batch.<br/>
        /// **Limits**:<br/>
        /// - Up to 1,000 requests per batch.<br/>
        /// - Up to 2,000 total content hours per batch.<br/>
        /// - Up to 5 active batches per account.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.CreateAnalyzeBatchResponse>> CreateAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateAnalyzeBatchRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Use this method to submit many video analysis requests in a single call. Each request creates an analysis task. The response contains one batch identifier and one task identifier per request. Use the batch identifier to check progress and retrieve results.<br/>
        /// &lt;Note title="Model requirement"&gt;<br/>
        /// You must use Pegasus 1.5 for batch analysis. Set the `model_name` parameter to `pegasus1.5`.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Run the same model and analysis settings across many videos.<br/>
        /// - Track a single batch instead of many individual analysis tasks.<br/>
        /// **Do not use this method for**:<br/>
        /// - Single videos that require immediate results. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// - Background processing of a single video. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// **Retention and retry**:<br/>
        /// - Batches expire 24 hours after creation. You can retrieve results for 30 days after creation.<br/>
        /// - If processing does not finish for some items in time, resubmit them in a new batch.<br/>
        /// **Limits**:<br/>
        /// - Up to 1,000 requests per batch.<br/>
        /// - Up to 2,000 total content hours per batch.<br/>
        /// - Up to 5 active batches per account.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="modelName">
        /// The video understanding model to use for every item in this batch. Batch analysis requires Pegasus 1.5.
        /// </param>
        /// <param name="analysisMode">
        /// The analysis approach for every item in this batch.<br/>
        /// - `general`: Generate text from each video based on the prompt (the item's `prompt` field if set, otherwise `defaults.prompt`). Supports structured JSON output by using `json_schema` in the `response_format.type` field.<br/>
        /// - `time_based_metadata`: Extract timestamped metadata by using `segment_definitions` in the `response_format.type` field.<br/>
        /// Batches with mixed modes are not supported.
        /// </param>
        /// <param name="defaults">
        /// Default values applied to every item that does not override them. Every field is optional. Items in the `requests` array override these values. To override the `prompt` or `response_format` field, provide the full object on the item. You cannot change only some of its nested fields.
        /// </param>
        /// <param name="requests">
        /// The analysis requests in the batch. Provide 1 to 1,000 requests, with a combined video duration of up to 2,000 hours.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.CreateAnalyzeBatchResponse> CreateAsync(
            string xApiKey,
            global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode analysisMode,
            global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest> requests,
            global::TwelveLabs.CreateAnalyzeBatchRequestModelName modelName = default,
            global::TwelveLabs.BatchDefaults? defaults = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}