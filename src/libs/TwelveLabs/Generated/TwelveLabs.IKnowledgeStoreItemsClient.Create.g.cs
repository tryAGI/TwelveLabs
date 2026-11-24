#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Create a knowledge store item<br/>
        /// This method adds an asset to a knowledge store for processing.<br/>
        /// The operation is asynchronous. The item is created immediately with the `queued`<br/>
        /// status and processed in the background.<br/>
        /// **Asset size limits**:<br/>
        /// - **Video**: Up to 10 GB<br/>
        /// - **Images**: Up to 32 MB<br/>
        /// **Video duration**: From 1.1 seconds to 24 hours.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateAsync(
            string knowledgeStoreId,

            global::TwelveLabs.CreateRequest5 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item<br/>
        /// This method adds an asset to a knowledge store for processing.<br/>
        /// The operation is asynchronous. The item is created immediately with the `queued`<br/>
        /// status and processed in the background.<br/>
        /// **Asset size limits**:<br/>
        /// - **Video**: Up to 10 GB<br/>
        /// - **Images**: Up to 32 MB<br/>
        /// **Video duration**: From 1.1 seconds to 24 hours.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItem>> CreateAsResponseAsync(
            string knowledgeStoreId,

            global::TwelveLabs.CreateRequest5 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item<br/>
        /// This method adds an asset to a knowledge store for processing.<br/>
        /// The operation is asynchronous. The item is created immediately with the `queued`<br/>
        /// status and processed in the background.<br/>
        /// **Asset size limits**:<br/>
        /// - **Video**: Up to 10 GB<br/>
        /// - **Images**: Up to 32 MB<br/>
        /// **Video duration**: From 1.1 seconds to 24 hours.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="assetType">
        /// The type of item to create.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of the asset to add to the knowledge store. If you uploaded the asset before your plan moved to the new billing, enable storage accounting for it before you add it to a knowledge store. Use the [Enable storage accounting for an asset](/v1.3/api-reference/manage-assets/enable-storage-accounting) method.
        /// </param>
        /// <param name="itemMetadata">
        /// Custom metadata for the item, as user-defined key-value pairs. It has the following limits:<br/>
        /// - Up to 50 pairs.<br/>
        /// - Keys are strings of up to 128 characters.<br/>
        /// - String values can have up to 8192 characters.<br/>
        /// - The strings in an array can have up to 8192 characters in total.<br/>
        /// Values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected.<br/>
        /// An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.<br/>
        /// To change it after you create the item, use the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateAsync(
            string knowledgeStoreId,
            string assetId,
            global::TwelveLabs.KnowledgeStoreItemAssetType? assetType = default,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? itemMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}