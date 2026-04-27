#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoresClient
    {
        /// <summary>
        /// Create a knowledge store<br/>
        /// Creates a new knowledge store. A knowledge store holds your videos plus the understanding the platform derives from them: spatiotemporal context, a typed ontology, and embeddings for semantic retrieval.<br/>
        /// Agents use knowledge stores to reason across the full video collection, not just individual clips.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> CreateKnowledgeStoreAsync(
            string xApiKey,

            global::TwelveLabs.CreateKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store<br/>
        /// Creates a new knowledge store. A knowledge store holds your videos plus the understanding the platform derives from them: spatiotemporal context, a typed ontology, and embeddings for semantic retrieval.<br/>
        /// Agents use knowledge stores to reason across the full video collection, not just individual clips.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="ingestionConfig">
        /// Configuration that controls how content added to this knowledge store is processed.<br/>
        /// This field is immutable after creation.
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> CreateKnowledgeStoreAsync(
            string xApiKey,
            string name,
            global::TwelveLabs.IngestionConfig? ingestionConfig = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}