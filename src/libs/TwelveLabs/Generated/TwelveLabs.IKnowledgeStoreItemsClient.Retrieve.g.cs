#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Retrieve a knowledge store item<br/>
        /// This method retrieves the details of a specific knowledge store item.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItem> RetrieveAsync(
            string knowledgeStoreId,
            string itemId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a knowledge store item<br/>
        /// This method retrieves the details of a specific knowledge store item.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItem>> RetrieveAsResponseAsync(
            string knowledgeStoreId,
            string itemId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}