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
        /// To replace all metadata, first delete it using [`DELETE`](/v1.3/api-reference/upload-content/direct-uploads/delete-asset-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint, then use this method to set the new values.
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
        /// To replace all metadata, first delete it using [`DELETE`](/v1.3/api-reference/upload-content/direct-uploads/delete-asset-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint, then use this method to set the new values.
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
        /// To replace all metadata, first delete it using [`DELETE`](/v1.3/api-reference/upload-content/direct-uploads/delete-asset-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint, then use this method to set the new values.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
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
        /// If you want to store other types of data such as objects or arrays, you must convert your data into string values.<br/>
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