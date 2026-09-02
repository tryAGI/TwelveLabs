#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoresClient
    {
        /// <summary>
        /// Update a knowledge store<br/>
        /// This method updates the specified knowledge store. Only the `name`, `description`, and `metadata` fields can be updated.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> UpdateAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest3 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a knowledge store<br/>
        /// This method updates the specified knowledge store. Only the `name`, `description`, and `metadata` fields can be updated.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStore>> UpdateAsResponseAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest3 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a knowledge store<br/>
        /// This method updates the specified knowledge store. Only the `name`, `description`, and `metadata` fields can be updated.
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
        /// Custom metadata for the knowledge store, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string. The provided object replaces the existing metadata in full, so include every key you want to keep, and drop a key by omitting it. To clear all metadata, set this field to an empty object (`{}`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> UpdateAsync(
            string knowledgeStoreId,
            string xApiKey,
            string? name = default,
            string? description = default,
            object? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}