#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Update a knowledge store item collection<br/>
        /// Updates the `name`, `description`, and `metadata` fields of the specified item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> UpdateAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest4 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a knowledge store item collection<br/>
        /// Updates the `name`, `description`, and `metadata` fields of the specified item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollection>> UpdateAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest4 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a knowledge store item collection<br/>
        /// Updates the `name`, `description`, and `metadata` fields of the specified item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the item collection. Must be unique within the knowledge store.
        /// </param>
        /// <param name="description">
        /// An optional description of the item collection.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item collection, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string. The provided object replaces the existing metadata in full, so include every key you want to keep, and drop a key by omitting it. To clear all metadata, set this field to an empty object (`{}`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> UpdateAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            string? name = default,
            string? description = default,
            object? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}