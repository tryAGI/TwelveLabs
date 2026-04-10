#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageIndexesSubpackageIndexesVideosClient
    {
        /// <summary>
        /// Retrieve video information<br/>
        /// &lt;Info&gt; This method will be deprecated in a future version. New implementations should use the [Retrieve an indexed asset](/v1.3/api-reference/index-content/retrieve) method.&lt;/Info&gt;<br/>
        /// This method retrieves information about the specified video.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="videoId"></param>
        /// <param name="embeddingOption"></param>
        /// <param name="transcription"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesVideosRetrieveResponse200> RetrieveAsync(
            string indexId,
            string videoId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::TwelveLabs.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption = default,
            bool? transcription = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}