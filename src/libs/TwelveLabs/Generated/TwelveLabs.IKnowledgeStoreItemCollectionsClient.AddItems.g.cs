#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Add items to a knowledge store item collection<br/>
        /// Adds one or more items to the specified item collection. This operation is idempotent — items already in the collection are skipped. Every identifier must reference an existing item in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> AddItemsAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,

            global::TwelveLabs.AddItemsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add items to a knowledge store item collection<br/>
        /// Adds one or more items to the specified item collection. This operation is idempotent — items already in the collection are skipped. Every identifier must reference an existing item in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollection>> AddItemsAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,

            global::TwelveLabs.AddItemsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add items to a knowledge store item collection<br/>
        /// Adds one or more items to the specified item collection. This operation is idempotent — items already in the collection are skipped. Every identifier must reference an existing item in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="itemIds">
        /// The unique identifiers of the items to add to the collection. Include up to 500 identifiers per request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> AddItemsAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            global::System.Collections.Generic.IList<string> itemIds,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}