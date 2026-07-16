#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Create a knowledge store item<br/>
        /// This method adds an asset to a knowledge store for processing.<br/>
        /// The operation is asynchronous. The item is created immediately with the `queued`<br/>
        /// status and processed in the background.<br/>
        /// The asset must not exceed 5 GB.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.CreateRequest6 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item<br/>
        /// This method adds an asset to a knowledge store for processing.<br/>
        /// The operation is asynchronous. The item is created immediately with the `queued`<br/>
        /// status and processed in the background.<br/>
        /// The asset must not exceed 5 GB.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItem>> CreateAsResponseAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.CreateRequest6 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item<br/>
        /// This method adds an asset to a knowledge store for processing.<br/>
        /// The operation is asynchronous. The item is created immediately with the `queued`<br/>
        /// status and processed in the background.<br/>
        /// The asset must not exceed 5 GB.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="assetType">
        /// The type of item to create.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of the asset to add to the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item. Both keys and values must be strings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateAsync(
            string knowledgeStoreId,
            string xApiKey,
            string assetId,
            global::TwelveLabs.KnowledgeStoreItemAssetType? assetType = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}