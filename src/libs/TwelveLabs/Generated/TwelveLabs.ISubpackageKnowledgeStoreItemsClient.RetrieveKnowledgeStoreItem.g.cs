#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Retrieve a knowledge store item<br/>
        /// Retrieves the details of a specific knowledge store item.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> RetrieveKnowledgeStoreItemAsync(
            string knowledgeStoreId,
            string itemId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}