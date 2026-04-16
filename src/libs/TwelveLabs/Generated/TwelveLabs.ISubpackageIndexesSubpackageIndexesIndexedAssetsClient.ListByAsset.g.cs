#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// List indexed assets for an asset<br/>
        /// This method returns a list of indexed assets that reference the specified asset. Each entry includes the indexed asset ID and the index it belongs to.
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesIndexedAssetsListByAssetResponse200> ListByAssetAsync(
            string assetId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}