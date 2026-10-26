#nullable enable

namespace TwelveLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Delete an asset<br/>
        /// This method deletes the specified asset. This action cannot be undone.<br/>
        /// The delete fails with a `409 Conflict` error if other resources depend on the asset.<br/>
        /// - **If knowledge store items use the asset**, in any status: the error code is `asset_has_knowledge_store_items`. The request fails even when you set the `force` query parameter to `true`. First delete the items with the [`DELETE`](/v1.3/api-reference/knowledge-store-items/delete) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint. Then delete the asset.<br/>
        /// - **If indexed assets reference the asset**: the error code is `asset_has_linked_resources`. To delete the asset and these indexed assets together, set the `force` query parameter to `true`. To list the indexed assets first, use the [`GET`](/v1.3/api-reference/index-content/list-indexed-assets-by-asset) method of the `/assets/{asset_id}/indexed-assets` endpoint.<br/>
        /// - **If both apply**: the error code is `asset_has_knowledge_store_items`.<br/>
        /// **If entities use the asset**, a successful delete removes the asset from the `asset_ids` array of each entity. To list these entities, use the [`GET`](/v1.3/api-reference/entities/list-entities-by-asset) method of the `/assets/{asset_id}/entities` endpoint.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string assetId,
            bool? force = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an asset<br/>
        /// This method deletes the specified asset. This action cannot be undone.<br/>
        /// The delete fails with a `409 Conflict` error if other resources depend on the asset.<br/>
        /// - **If knowledge store items use the asset**, in any status: the error code is `asset_has_knowledge_store_items`. The request fails even when you set the `force` query parameter to `true`. First delete the items with the [`DELETE`](/v1.3/api-reference/knowledge-store-items/delete) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint. Then delete the asset.<br/>
        /// - **If indexed assets reference the asset**: the error code is `asset_has_linked_resources`. To delete the asset and these indexed assets together, set the `force` query parameter to `true`. To list the indexed assets first, use the [`GET`](/v1.3/api-reference/index-content/list-indexed-assets-by-asset) method of the `/assets/{asset_id}/indexed-assets` endpoint.<br/>
        /// - **If both apply**: the error code is `asset_has_knowledge_store_items`.<br/>
        /// **If entities use the asset**, a successful delete removes the asset from the `asset_ids` array of each entity. To list these entities, use the [`GET`](/v1.3/api-reference/entities/list-entities-by-asset) method of the `/assets/{asset_id}/entities` endpoint.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string assetId,
            bool? force = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}