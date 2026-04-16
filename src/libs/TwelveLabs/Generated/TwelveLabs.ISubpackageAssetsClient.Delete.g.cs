#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// Delete an asset<br/>
        /// This method deletes the specified asset. This action cannot be undone.<br/>
        /// By default, the platform checks whether any indexed assets reference the asset. If references exist, the platform rejects the request with a `409 Conflict` error. To skip this check and delete the asset anyway, set the `force` query parameter to `true`. The platform unlinks any entity associations.<br/>
        /// Before deleting, you can inspect existing references:<br/>
        /// - [`GET`](/v1.3/api-reference/index-content/list-indexed-assets-by-asset) `/assets/{asset_id}/indexed-assets` returns a list of the indexed assets that will block deletion unless the `force` query parameter is set to `true`.<br/>
        /// - [`GET`](/v1.3/api-reference/entities/list-entities-by-asset) `/assets/{asset_id}/entities` returns a list of the entities whose associations the platform will unlink.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AssetsDeleteResponse204> DeleteAsync(
            string assetId,
            string xApiKey,
            bool? force = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}