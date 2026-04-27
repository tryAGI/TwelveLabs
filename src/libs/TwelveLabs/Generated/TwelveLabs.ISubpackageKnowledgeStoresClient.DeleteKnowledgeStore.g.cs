#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoresClient
    {
        /// <summary>
        /// Delete a knowledge store<br/>
        /// Deletes the specified knowledge store and all its items.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoresDeleteKnowledgeStoreResponse204> DeleteKnowledgeStoreAsync(
            string knowledgeStoreId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}