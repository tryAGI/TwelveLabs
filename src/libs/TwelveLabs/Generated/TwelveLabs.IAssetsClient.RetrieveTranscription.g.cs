#nullable enable

namespace TwelveLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Retrieve the transcription of an asset<br/>
        /// This method retrieves the transcription of a video or audio asset. An asset that has a transcription returns `200` with the current transcription status. The endpoint returns `404` when the asset cannot be found or has no transcription.<br/>
        /// The platform generates transcriptions asynchronously. Poll this endpoint to monitor the transcription status.<br/>
        /// When the status is `ready`, the response contains the segmentations you requested that the transcription supports. A transcription does not always support every segmentation, so read the segmentations the response returns rather than assuming every requested one is present.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="include"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AssetTranscriptionResponse> RetrieveTranscriptionAsync(
            string assetId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? include = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve the transcription of an asset<br/>
        /// This method retrieves the transcription of a video or audio asset. An asset that has a transcription returns `200` with the current transcription status. The endpoint returns `404` when the asset cannot be found or has no transcription.<br/>
        /// The platform generates transcriptions asynchronously. Poll this endpoint to monitor the transcription status.<br/>
        /// When the status is `ready`, the response contains the segmentations you requested that the transcription supports. A transcription does not always support every segmentation, so read the segmentations the response returns rather than assuming every requested one is present.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="include"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AssetTranscriptionResponse>> RetrieveTranscriptionAsResponseAsync(
            string assetId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::TwelveLabs.AssetsAssetIdTranscriptionGetParametersIncludeSchemaItems>? include = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}