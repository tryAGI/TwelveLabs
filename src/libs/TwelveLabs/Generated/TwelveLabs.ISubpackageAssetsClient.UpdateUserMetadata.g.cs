#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// Update the user-defined metadata of an asset<br/>
        /// This method updates the user-defined metadata of the specified asset. The platform merges your changes with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// To replace all metadata in a single call, use the [`PUT`](/v1.3/api-reference/upload-content/direct-uploads/replace-asset-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint instead.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AssetsUpdateUserMetadataResponse204> UpdateUserMetadataAsync(
            string assetId,
            string xApiKey,

            global::TwelveLabs.UpdateUserMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the user-defined metadata of an asset<br/>
        /// This method updates the user-defined metadata of the specified asset. The platform merges your changes with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// To replace all metadata in a single call, use the [`PUT`](/v1.3/api-reference/upload-content/direct-uploads/replace-asset-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint instead.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AssetsUpdateUserMetadataResponse204>> UpdateUserMetadataAsResponseAsync(
            string assetId,
            string xApiKey,

            global::TwelveLabs.UpdateUserMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the user-defined metadata of an asset<br/>
        /// This method updates the user-defined metadata of the specified asset. The platform merges your changes with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// To replace all metadata in a single call, use the [`PUT`](/v1.3/api-reference/upload-content/direct-uploads/replace-asset-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint instead.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. The object contains user-defined keys and values, where keys are strings and values are one of `string`, `integer`, `float`, or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// To store other types of data, such as objects or arrays, convert your data into string values before sending it.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AssetsUpdateUserMetadataResponse204> UpdateUserMetadataAsync(
            string assetId,
            string xApiKey,
            global::TwelveLabs.UserMetadata userMetadata,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}