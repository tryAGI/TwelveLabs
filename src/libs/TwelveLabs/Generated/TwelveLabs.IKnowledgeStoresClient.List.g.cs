#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoresClient
    {
        /// <summary>
        /// List knowledge stores<br/>
        /// This method returns a list of the knowledge stores in your account.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoresListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.KnowledgeStoresGetParametersSortBy? sortBy = default,
            string? sortOption = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List knowledge stores<br/>
        /// This method returns a list of the knowledge stores in your account.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoresListResponse200>> ListAsResponseAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.KnowledgeStoresGetParametersSortBy? sortBy = default,
            string? sortOption = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}