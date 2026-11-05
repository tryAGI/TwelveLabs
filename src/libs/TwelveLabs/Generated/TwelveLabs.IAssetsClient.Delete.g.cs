#nullable enable

namespace TwelveLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Delete an asset<br/>
        /// This method deletes the specified asset. This action cannot be undone.<br/>
        /// A successful delete also removes the asset from each entity that uses it. To list these entities first, use the [`GET`](/v1.3/api-reference/entities/list-entities-by-asset) method of the `/assets/{asset_id}/entities` endpoint.<br/>
        /// The delete fails with a `409 Conflict` error when other resources depend on the asset.<br/>
        /// **If the error code is `asset_has_knowledge_store_items`**, knowledge store items use the asset. The request fails even when you set the `force` query parameter to `true`. To delete the asset:<br/>
        /// 1. **Find the knowledge stores whose items use the asset**: Call the [`GET`](/v1.3/api-reference/knowledge-stores/list) method of the `/knowledge-stores` endpoint with the `asset_id` parameter set to the identifier of the asset.<br/>
        /// 2. **List the items that use the asset**: Call the [`GET`](/v1.3/api-reference/knowledge-store-items/list) method of the `/knowledge-stores/{knowledge_store_id}/items` endpoint for each knowledge store that step 1 returns. Set the `asset_id` parameter to the identifier of the asset.<br/>
        /// 3. **Delete the items**: Delete each item with the [`DELETE`](/v1.3/api-reference/knowledge-store-items/delete) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint.<br/>
        /// 4. **Delete the asset**: Retry the delete request. If the delete fails with the `asset_has_linked_resources` error code, follow the steps in the next case.<br/>
        /// **If the error code is `asset_has_linked_resources`**, indexed assets reference the asset. A delete with the `force` query parameter set to `true` also deletes these indexed assets. To delete both:<br/>
        /// 1. _(Optional)_ **List the indexed assets**: To see which indexed assets the delete removes, call the [`GET`](/v1.3/api-reference/index-content/list-indexed-assets-by-asset) method of the `/assets/{asset_id}/indexed-assets` endpoint.<br/>
        /// 2. **Delete the asset and its indexed assets**: Retry the delete request with the `force` query parameter set to `true`.
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
        /// A successful delete also removes the asset from each entity that uses it. To list these entities first, use the [`GET`](/v1.3/api-reference/entities/list-entities-by-asset) method of the `/assets/{asset_id}/entities` endpoint.<br/>
        /// The delete fails with a `409 Conflict` error when other resources depend on the asset.<br/>
        /// **If the error code is `asset_has_knowledge_store_items`**, knowledge store items use the asset. The request fails even when you set the `force` query parameter to `true`. To delete the asset:<br/>
        /// 1. **Find the knowledge stores whose items use the asset**: Call the [`GET`](/v1.3/api-reference/knowledge-stores/list) method of the `/knowledge-stores` endpoint with the `asset_id` parameter set to the identifier of the asset.<br/>
        /// 2. **List the items that use the asset**: Call the [`GET`](/v1.3/api-reference/knowledge-store-items/list) method of the `/knowledge-stores/{knowledge_store_id}/items` endpoint for each knowledge store that step 1 returns. Set the `asset_id` parameter to the identifier of the asset.<br/>
        /// 3. **Delete the items**: Delete each item with the [`DELETE`](/v1.3/api-reference/knowledge-store-items/delete) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint.<br/>
        /// 4. **Delete the asset**: Retry the delete request. If the delete fails with the `asset_has_linked_resources` error code, follow the steps in the next case.<br/>
        /// **If the error code is `asset_has_linked_resources`**, indexed assets reference the asset. A delete with the `force` query parameter set to `true` also deletes these indexed assets. To delete both:<br/>
        /// 1. _(Optional)_ **List the indexed assets**: To see which indexed assets the delete removes, call the [`GET`](/v1.3/api-reference/index-content/list-indexed-assets-by-asset) method of the `/assets/{asset_id}/indexed-assets` endpoint.<br/>
        /// 2. **Delete the asset and its indexed assets**: Retry the delete request with the `force` query parameter set to `true`.
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