#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Create a knowledge store item<br/>
        /// Adds a video to a knowledge store for processing.<br/>
        /// This operation is asynchronous — the item is created immediately with `queued` status<br/>
        /// and processed in the background.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateKnowledgeStoreItemAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.CreateKnowledgeStoreItemRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item<br/>
        /// Adds a video to a knowledge store for processing.<br/>
        /// This operation is asynchronous — the item is created immediately with `queued` status<br/>
        /// and processed in the background.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="assetId">
        /// The unique identifier of the video asset to add to the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to attach to the item.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> CreateKnowledgeStoreItemAsync(
            string knowledgeStoreId,
            string xApiKey,
            string assetId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}