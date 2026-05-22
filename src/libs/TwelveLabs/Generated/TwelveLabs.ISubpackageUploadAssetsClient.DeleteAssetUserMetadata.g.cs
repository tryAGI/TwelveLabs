#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageUploadAssetsClient
    {
        /// <summary>
        /// Delete the user-defined metadata of an asset<br/>
        /// This method deletes the user-defined metadata of the specified asset.<br/>
        /// This action cannot be undone.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.UploadAssetsDeleteAssetUserMetadataResponse204> DeleteAssetUserMetadataAsync(
            string assetId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete the user-defined metadata of an asset<br/>
        /// This method deletes the user-defined metadata of the specified asset.<br/>
        /// This action cannot be undone.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.UploadAssetsDeleteAssetUserMetadataResponse204>> DeleteAssetUserMetadataAsResponseAsync(
            string assetId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}