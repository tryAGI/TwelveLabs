#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Remove items from a knowledge store item collection<br/>
        /// Removes one or more items from the specified item collection. This operation is idempotent: the platform skips the identifiers that do not match an item in the collection. The response lists the result for each identifier of an item in the `results` array. The items themselves remain in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResponse> RemoveItemsAsync(
            string knowledgeStoreId,
            string collectionId,

            global::TwelveLabs.RemoveItemsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove items from a knowledge store item collection<br/>
        /// Removes one or more items from the specified item collection. This operation is idempotent: the platform skips the identifiers that do not match an item in the collection. The response lists the result for each identifier of an item in the `results` array. The items themselves remain in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResponse>> RemoveItemsAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,

            global::TwelveLabs.RemoveItemsRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove items from a knowledge store item collection<br/>
        /// Removes one or more items from the specified item collection. This operation is idempotent: the platform skips the identifiers that do not match an item in the collection. The response lists the result for each identifier of an item in the `results` array. The items themselves remain in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="itemIds">
        /// The unique identifiers of the items to remove from the collection. Include up to 500 identifiers per request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResponse> RemoveItemsAsync(
            string knowledgeStoreId,
            string collectionId,
            global::System.Collections.Generic.IList<string> itemIds,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}