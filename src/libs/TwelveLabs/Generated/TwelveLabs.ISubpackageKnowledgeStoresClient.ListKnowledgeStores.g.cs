#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageKnowledgeStoresClient
    {
        /// <summary>
        /// List knowledge stores<br/>
        /// Returns a list of the knowledge stores in your account.
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoresListKnowledgeStoresResponse200> ListKnowledgeStoresAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.KnowledgeStoresGetParametersSortBy? sortBy = default,
            string? sortOption = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}