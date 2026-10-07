#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Replace the item metadata<br/>
        /// This method replaces the entire `item_metadata` of the specified knowledge store item and returns the item. Unlike the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) method, which merges your changes with the existing metadata, this method overwrites the stored value in full:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key you omit, or set to an empty string (`""`), an empty array (`[]`), or `null`, is removed.<br/>
        /// To clear all item metadata, send an empty object (`{}`) in the `item_metadata` field. The `metadata` field of the item does not change.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> ReplaceKnowledgeStoreItemMetadataAsync(
            string knowledgeStoreId,
            string itemId,

            global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the item metadata<br/>
        /// This method replaces the entire `item_metadata` of the specified knowledge store item and returns the item. Unlike the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) method, which merges your changes with the existing metadata, this method overwrites the stored value in full:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key you omit, or set to an empty string (`""`), an empty array (`[]`), or `null`, is removed.<br/>
        /// To clear all item metadata, send an empty object (`{}`) in the `item_metadata` field. The `metadata` field of the item does not change.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItem>> ReplaceKnowledgeStoreItemMetadataAsResponseAsync(
            string knowledgeStoreId,
            string itemId,

            global::TwelveLabs.ReplaceKnowledgeStoreItemMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the item metadata<br/>
        /// This method replaces the entire `item_metadata` of the specified knowledge store item and returns the item. Unlike the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) method, which merges your changes with the existing metadata, this method overwrites the stored value in full:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key you omit, or set to an empty string (`""`), an empty array (`[]`), or `null`, is removed.<br/>
        /// To clear all item metadata, send an empty object (`{}`) in the `item_metadata` field. The `metadata` field of the item does not change.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="itemMetadata">
        /// The complete `item_metadata` of the item after the request. Up to 50 pairs. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, or an array of strings. A nested object and an array containing anything other than strings are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> ReplaceKnowledgeStoreItemMetadataAsync(
            string knowledgeStoreId,
            string itemId,
            object itemMetadata,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}