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

            global::TwelveLabs.CreateRequest5 request,
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

            global::TwelveLabs.CreateRequest5 request,
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
        /// Custom metadata for the item, as user-defined key-value pairs. Up to 50 pairs, keys up to 128 characters, string values up to 8192 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateAsync(
            string knowledgeStoreId,
            string xApiKey,
            string assetId,
            global::TwelveLabs.KnowledgeStoreItemAssetType? assetType = default,
            object? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}