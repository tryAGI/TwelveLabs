#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoreItemsClient
    {
        /// <summary>
        /// List knowledge store items<br/>
        /// Returns a list of items in the specified knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="status"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemsListKnowledgeStoreItemsResponse200> ListKnowledgeStoreItemsAsync(
            string knowledgeStoreId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersSortBy? sortBy = default,
            string? sortOption = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? status = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}