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
        /// Custom metadata for the knowledge store. Both keys and values must be strings. The provided object replaces the existing metadata in full, so include every key you want to keep. To clear all metadata, set this field to an empty object (`{}`). A null value is stored as an empty string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> UpdateAsync(
            string knowledgeStoreId,
            string xApiKey,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}