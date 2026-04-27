#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoresClient
    {
        /// <summary>
        /// Retrieve a knowledge store<br/>
        /// Retrieves the details of a specific knowledge store.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStore> RetrieveKnowledgeStoreAsync(
            string knowledgeStoreId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}