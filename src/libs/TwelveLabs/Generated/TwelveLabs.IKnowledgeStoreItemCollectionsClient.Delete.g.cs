#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Delete a knowledge store item collection<br/>
        /// Deletes the specified item collection. The items themselves remain in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a knowledge store item collection<br/>
        /// Deletes the specified item collection. The items themselves remain in the knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}