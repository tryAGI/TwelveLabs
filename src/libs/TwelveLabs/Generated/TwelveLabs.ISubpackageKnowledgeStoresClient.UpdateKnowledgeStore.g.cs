#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoresClient
    {
        /// <summary>
        /// Update a knowledge store<br/>
        /// Updates the specified knowledge store. Only `name`, `description`, and `metadata` can be updated.<br/>
        /// The `ingestion_config` is immutable after creation.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> UpdateKnowledgeStoreAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.UpdateKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a knowledge store<br/>
        /// Updates the specified knowledge store. Only `name`, `description`, and `metadata` can be updated.<br/>
        /// The `ingestion_config` is immutable after creation.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="description">
        /// An optional description of the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to attach to the knowledge store.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> UpdateKnowledgeStoreAsync(
            string knowledgeStoreId,
            string xApiKey,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}