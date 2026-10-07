#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Update the item metadata<br/>
        /// This method updates the `item_metadata` of the specified knowledge store item and returns the item. The platform merges your changes with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) or an empty array (`[]`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// The `metadata` field of the item does not change. If the merged result contains more than 50 pairs, the request fails.<br/>
        /// To replace all item metadata in a single call, use the [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint instead.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> UpdateKnowledgeStoreItemMetadataAsync(
            string knowledgeStoreId,
            string itemId,

            global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the item metadata<br/>
        /// This method updates the `item_metadata` of the specified knowledge store item and returns the item. The platform merges your changes with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) or an empty array (`[]`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// The `metadata` field of the item does not change. If the merged result contains more than 50 pairs, the request fails.<br/>
        /// To replace all item metadata in a single call, use the [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint instead.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItem>> UpdateKnowledgeStoreItemMetadataAsResponseAsync(
            string knowledgeStoreId,
            string itemId,

            global::TwelveLabs.UpdateKnowledgeStoreItemMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the item metadata<br/>
        /// This method updates the `item_metadata` of the specified knowledge store item and returns the item. The platform merges your changes with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) or an empty array (`[]`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// The `metadata` field of the item does not change. If the merged result contains more than 50 pairs, the request fails.<br/>
        /// To replace all item metadata in a single call, use the [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint instead.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="itemMetadata">
        /// The keys to change. Send at least one key. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, an array of strings, or `null` to delete the key. A nested object and an array containing anything other than strings are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> UpdateKnowledgeStoreItemMetadataAsync(
            string knowledgeStoreId,
            string itemId,
            object itemMetadata,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}