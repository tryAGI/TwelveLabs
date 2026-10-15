#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemTagsClient
    {
        /// <summary>
        /// List item tags<br/>
        /// This method returns the tags of the specified knowledge store item. The platform sorts the tags by `start_sec`, earliest first. Tags with the same `start_sec` are sorted by `_id`.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemTagsListResponse200> ListAsync(
            string knowledgeStoreId,
            string itemId,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List item tags<br/>
        /// This method returns the tags of the specified knowledge store item. The platform sorts the tags by `start_sec`, earliest first. Tags with the same `start_sec` are sorted by `_id`.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemTagsListResponse200>> ListAsResponseAsync(
            string knowledgeStoreId,
            string itemId,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}