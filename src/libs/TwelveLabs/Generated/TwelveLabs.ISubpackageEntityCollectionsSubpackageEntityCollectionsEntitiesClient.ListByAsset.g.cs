#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// List entities for an asset<br/>
        /// This method returns a list of entities whose [`asset_ids`](/v1.3/api-reference/entities/entity-collections/entities/retrieve#response.body.asset_ids) array contains the specified asset.
        /// </summary>
        /// <param name="assetId"></param>
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.EntityCollectionsEntitiesListByAssetResponse200> ListByAssetAsync(
            string assetId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}