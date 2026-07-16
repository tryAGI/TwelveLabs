#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Create a knowledge store item collection<br/>
        /// Creates an item collection in the specified knowledge store. An item collection is a named collection of items. Use item collections to organize and reference subsets of items together.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> CreateAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.CreateRequest7 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item collection<br/>
        /// Creates an item collection in the specified knowledge store. An item collection is a named collection of items. Use item collections to organize and reference subsets of items together.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollection>> CreateAsResponseAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.CreateRequest7 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store item collection<br/>
        /// Creates an item collection in the specified knowledge store. An item collection is a named collection of items. Use item collections to organize and reference subsets of items together.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the item collection. Must be unique within the knowledge store.
        /// </param>
        /// <param name="description">
        /// An optional description of the item collection.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item collection. Both keys and values must be strings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> CreateAsync(
            string knowledgeStoreId,
            string xApiKey,
            string name,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}