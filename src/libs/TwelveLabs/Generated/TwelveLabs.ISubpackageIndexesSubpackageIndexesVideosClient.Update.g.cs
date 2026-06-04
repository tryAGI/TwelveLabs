#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesSubpackageIndexesVideosClient
    {
        /// <summary>
        /// Partial update video information<br/>
        /// &lt;Info&gt;This method will be deprecated in a future version. New implementations should use the [Partial update indexed asset](/v1.3/api-reference/index-content/update) method.&lt;/Info&gt;<br/>
        /// This method updates one or more fields of the metadata of a video. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="videoId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesVideosUpdateResponse204> UpdateAsync(
            string indexId,
            string videoId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest3 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial update video information<br/>
        /// &lt;Info&gt;This method will be deprecated in a future version. New implementations should use the [Partial update indexed asset](/v1.3/api-reference/index-content/update) method.&lt;/Info&gt;<br/>
        /// This method updates one or more fields of the metadata of a video. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="videoId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.IndexesVideosUpdateResponse204>> UpdateAsResponseAsync(
            string indexId,
            string videoId,
            string xApiKey,

            global::TwelveLabs.UpdateRequest3 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial update video information<br/>
        /// &lt;Info&gt;This method will be deprecated in a future version. New implementations should use the [Partial update indexed asset](/v1.3/api-reference/index-content/update) method.&lt;/Info&gt;<br/>
        /// This method updates one or more fields of the metadata of a video. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="videoId"></param>
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesVideosUpdateResponse204> UpdateAsync(
            string indexId,
            string videoId,
            string xApiKey,
            global::TwelveLabs.UserMetadata? userMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}