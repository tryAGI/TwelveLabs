#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAnalyzeAsyncSubpackageAnalyzeAsyncBatchesClient
    {
        /// <summary>
        /// List batches<br/>
        /// Use this method to list all the batch objects in your account. The response sorts batches by creation date, with the newest batch first.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="status"></param>
        /// <param name="analysisMode"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeAsyncBatchesListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? status = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? analysisMode = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List batches<br/>
        /// Use this method to list all the batch objects in your account. The response sorts batches by creation date, with the newest batch first.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="status"></param>
        /// <param name="analysisMode"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeAsyncBatchesListResponse200>> ListAsResponseAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.BatchStatus>? status = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchesGetParametersAnalysisModeSchemaItems>? analysisMode = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}