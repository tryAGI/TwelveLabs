#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Add items to a knowledge store item collection<br/>
        /// Adds one or more items to the specified item collection. This operation is idempotent: the platform skips the items already in the collection. The response lists the result for each identifier of an item in the `results` array. Every identifier must reference an existing item in the knowledge store. If one does not, the platform rejects the whole request with a `404` error and adds none of the items.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResponse> AddItemsAsync(
            string knowledgeStoreId,
            string collectionId,

            global::TwelveLabs.AddItemsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add items to a knowledge store item collection<br/>
        /// Adds one or more items to the specified item collection. This operation is idempotent: the platform skips the items already in the collection. The response lists the result for each identifier of an item in the `results` array. Every identifier must reference an existing item in the knowledge store. If one does not, the platform rejects the whole request with a `404` error and adds none of the items.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResponse>> AddItemsAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,

            global::TwelveLabs.AddItemsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add items to a knowledge store item collection<br/>
        /// Adds one or more items to the specified item collection. This operation is idempotent: the platform skips the items already in the collection. The response lists the result for each identifier of an item in the `results` array. Every identifier must reference an existing item in the knowledge store. If one does not, the platform rejects the whole request with a `404` error and adds none of the items.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="itemIds">
        /// The unique identifiers of the items to add to the collection. Include up to 500 identifiers per request. An item collection can contain up to 5,000 items.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResponse> AddItemsAsync(
            string knowledgeStoreId,
            string collectionId,
            global::System.Collections.Generic.IList<string> itemIds,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}