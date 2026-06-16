#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// Partial update indexed asset information<br/>
        /// This method updates one or more fields of the metadata of an indexed asset. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesIndexedAssetsUpdateResponse204> UpdateAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest2 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial update indexed asset information<br/>
        /// This method updates one or more fields of the metadata of an indexed asset. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.IndexesIndexedAssetsUpdateResponse204>> UpdateAsResponseAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest2 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial update indexed asset information<br/>
        /// This method updates one or more fields of the metadata of an indexed asset. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesIndexedAssetsUpdateResponse204> UpdateAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,
            global::TwelveLabs.UserMetadata? userMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}