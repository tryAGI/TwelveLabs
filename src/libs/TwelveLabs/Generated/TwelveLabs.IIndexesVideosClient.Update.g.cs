#nullable enable

namespace TwelveLabs
{
    public partial interface IIndexesVideosClient
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
        global::System.Threading.Tasks.Task UpdateAsync(
            string indexId,
            string videoId,
            string xApiKey,

            global::TwelveLabs.IndexesVideosUpdateRequest request,
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> UpdateAsResponseAsync(
            string indexId,
            string videoId,
            string xApiKey,

            global::TwelveLabs.IndexesVideosUpdateRequest request,
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
        global::System.Threading.Tasks.Task UpdateAsync(
            string indexId,
            string videoId,
            string xApiKey,
            global::TwelveLabs.UserMetadata? userMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}