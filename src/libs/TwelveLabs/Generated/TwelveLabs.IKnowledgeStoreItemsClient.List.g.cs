#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemsClient
    {
        /// <summary>
        /// List knowledge store items<br/>
        /// This method returns a list of items in the specified knowledge store.<br/>
        /// Use the `status`, `asset_id`, `metadata`, `enrichment`, `created_at_gte`, and `created_at_lte` parameters to choose which items to list. An item must match every parameter that you specify. You can repeat the `status` and `asset_id` parameters. For a repeated parameter, an item matches when it matches any of its values.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
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
        /// <param name="status"></param>
        /// <param name="assetId"></param>
        /// <param name="metadata"></param>
        /// <param name="enrichment"></param>
        /// <param name="createdAtGte"></param>
        /// <param name="createdAtLte"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemsListResponse200> ListAsync(
            string knowledgeStoreId,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? status = default,
            global::System.Collections.Generic.IList<string>? assetId = default,
            string? metadata = default,
            string? enrichment = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List knowledge store items<br/>
        /// This method returns a list of items in the specified knowledge store.<br/>
        /// Use the `status`, `asset_id`, `metadata`, `enrichment`, `created_at_gte`, and `created_at_lte` parameters to choose which items to list. An item must match every parameter that you specify. You can repeat the `status` and `asset_id` parameters. For a repeated parameter, an item matches when it matches any of its values.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
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
        /// <param name="status"></param>
        /// <param name="assetId"></param>
        /// <param name="metadata"></param>
        /// <param name="enrichment"></param>
        /// <param name="createdAtGte"></param>
        /// <param name="createdAtLte"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemsListResponse200>> ListAsResponseAsync(
            string knowledgeStoreId,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoresKnowledgeStoreIdItemsGetParametersStatusSchemaItems>? status = default,
            global::System.Collections.Generic.IList<string>? assetId = default,
            string? metadata = default,
            string? enrichment = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtLte = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}