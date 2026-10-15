#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemTagsClient
    {
        /// <summary>
        /// Create an item tag<br/>
        /// This method tags a moment or a range of a video item and returns the tag. Set `start_sec` to tag a moment. Set `start_sec` and `end_sec` to tag a range. A video item holds up to 100 tags. The method returns a 422 error for an item that is not a video item, and when the item already holds 100 tags.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemTag> CreateAsync(
            string knowledgeStoreId,
            string itemId,

            global::TwelveLabs.CreateKnowledgeStoreItemTagRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an item tag<br/>
        /// This method tags a moment or a range of a video item and returns the tag. Set `start_sec` to tag a moment. Set `start_sec` and `end_sec` to tag a range. A video item holds up to 100 tags. The method returns a 422 error for an item that is not a video item, and when the item already holds 100 tags.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemTag>> CreateAsResponseAsync(
            string knowledgeStoreId,
            string itemId,

            global::TwelveLabs.CreateKnowledgeStoreItemTagRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an item tag<br/>
        /// This method tags a moment or a range of a video item and returns the tag. Set `start_sec` to tag a moment. Set `start_sec` and `end_sec` to tag a range. A video item holds up to 100 tags. The method returns a 422 error for an item that is not a video item, and when the item already holds 100 tags.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="startSec">
        /// The start of the tag, in seconds from the start of the video. It must be less than the duration of the video.
        /// </param>
        /// <param name="endSec">
        /// The end of the range, in seconds from the start of the video. It must be greater than `start_sec`. It must not exceed the duration of the video. Omit it, or send `null`, to tag a single moment.
        /// </param>
        /// <param name="tagMetadata">
        /// The custom metadata of the tag, as key-value pairs. Send at least one key. Up to 50 pairs. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemTag> CreateAsync(
            string knowledgeStoreId,
            string itemId,
            double startSec,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue> tagMetadata,
            double? endSec = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}