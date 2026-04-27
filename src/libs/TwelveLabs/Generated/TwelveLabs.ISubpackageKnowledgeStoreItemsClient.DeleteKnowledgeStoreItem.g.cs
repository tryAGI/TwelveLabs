#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoreItemsClient
    {
        /// <summary>
        /// Delete a knowledge store item<br/>
        /// Deletes the specified knowledge store item.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemsDeleteKnowledgeStoreItemResponse204> DeleteKnowledgeStoreItemAsync(
            string knowledgeStoreId,
            string itemId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}