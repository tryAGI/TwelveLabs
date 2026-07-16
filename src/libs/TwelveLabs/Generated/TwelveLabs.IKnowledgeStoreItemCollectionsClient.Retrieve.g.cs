#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// Retrieve a knowledge store item collection<br/>
        /// Retrieves the details of a specific item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollection> RetrieveAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a knowledge store item collection<br/>
        /// Retrieves the details of a specific item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollection>> RetrieveAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}