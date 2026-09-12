#nullable enable

namespace TwelveLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Replace the user-defined metadata of an asset<br/>
        /// This method replaces the entire user-defined metadata of the specified asset. Unlike the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method, which merges your changes with the existing metadata, this method overwrites the stored value in full:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to an empty string (`""`), an empty array (`[]`), or `null` is ignored.<br/>
        /// - A key you omit from the request body is removed.<br/>
        /// To clear all metadata, send an empty object (`{}`) in the `user_metadata` field. This produces the same result as the [`DELETE`](/v1.3/api-reference/upload-content/direct-uploads/delete-user-metadata) method.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task ReplaceUserMetadataAsync(
            string assetId,
            string xApiKey,

            global::TwelveLabs.ReplaceUserMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the user-defined metadata of an asset<br/>
        /// This method replaces the entire user-defined metadata of the specified asset. Unlike the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method, which merges your changes with the existing metadata, this method overwrites the stored value in full:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to an empty string (`""`), an empty array (`[]`), or `null` is ignored.<br/>
        /// - A key you omit from the request body is removed.<br/>
        /// To clear all metadata, send an empty object (`{}`) in the `user_metadata` field. This produces the same result as the [`DELETE`](/v1.3/api-reference/upload-content/direct-uploads/delete-user-metadata) method.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> ReplaceUserMetadataAsResponseAsync(
            string assetId,
            string xApiKey,

            global::TwelveLabs.ReplaceUserMetadataRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace the user-defined metadata of an asset<br/>
        /// This method replaces the entire user-defined metadata of the specified asset. Unlike the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method, which merges your changes with the existing metadata, this method overwrites the stored value in full:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to an empty string (`""`), an empty array (`[]`), or `null` is ignored.<br/>
        /// - A key you omit from the request body is removed.<br/>
        /// To clear all metadata, send an empty object (`{}`) in the `user_metadata` field. This produces the same result as the [`DELETE`](/v1.3/api-reference/upload-content/direct-uploads/delete-user-metadata) method.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. The object contains user-defined keys and values, where keys are strings. Each value is a string, a number, a boolean, or an array of strings. Send an integer wider than 53 bits (-9007199254740991 to 9007199254740991), and any identifier you want preserved verbatim, as a string.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true,<br/>
        ///   "hashtags": ["summer", "vlog"]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReplaceUserMetadataAsync(
            string assetId,
            string xApiKey,
            global::TwelveLabs.UserMetadata userMetadata,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}