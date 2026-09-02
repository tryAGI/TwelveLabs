#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoresClient
    {
        /// <summary>
        /// Create a knowledge store<br/>
        /// This method creates a knowledge store.<br/>
        /// Provide a name. Optionally include a description, a metadata map, and an `ingestion_config` object that controls how content added to the store is processed. The `ingestion_config` object is immutable after creation.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateRequest4 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store<br/>
        /// This method creates a knowledge store.<br/>
        /// Provide a name. Optionally include a description, a metadata map, and an `ingestion_config` object that controls how content added to the store is processed. The `ingestion_config` object is immutable after creation.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStore>> CreateAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateRequest4 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a knowledge store<br/>
        /// This method creates a knowledge store.<br/>
        /// Provide a name. Optionally include a description, a metadata map, and an `ingestion_config` object that controls how content added to the store is processed. The `ingestion_config` object is immutable after creation.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="ingestionConfig">
        /// Configuration that controls how content added to the knowledge store is processed.
        /// </param>
        /// <param name="description">
        /// An optional description of the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the knowledge store, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> CreateAsync(
            string xApiKey,
            string name,
            global::TwelveLabs.IngestionConfig? ingestionConfig = default,
            string? description = default,
            object? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}