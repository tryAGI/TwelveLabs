#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemCollectionsClient
    {
        /// <summary>
        /// List items in a knowledge store item collection<br/>
        /// Returns a list of the items in the specified item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200> ListItemsAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List items in a knowledge store item collection<br/>
        /// Returns a list of the items in the specified item collection.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="collectionId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemCollectionsListItemsResponse200>> ListItemsAsResponseAsync(
            string knowledgeStoreId,
            string collectionId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}