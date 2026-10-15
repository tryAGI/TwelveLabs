#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoreItemTagsClient
    {
        /// <summary>
        /// Update an item tag<br/>
        /// This method updates the range or the `tag_metadata` of the specified tag and returns the tag. Send at least one field. A field you omit keeps its current value. To clear the end of the range, send `end_sec` as `null`. The tag becomes a single moment. The platform merges your changes to `tag_metadata` with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) or an empty array (`[]`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// The tag must keep at least one key in `tag_metadata`, and it holds up to 50 pairs. If the merged result breaks either limit, the request fails.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="tagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemTag> UpdateAsync(
            string knowledgeStoreId,
            string itemId,
            string tagId,

            global::TwelveLabs.UpdateKnowledgeStoreItemTagRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an item tag<br/>
        /// This method updates the range or the `tag_metadata` of the specified tag and returns the tag. Send at least one field. A field you omit keeps its current value. To clear the end of the range, send `end_sec` as `null`. The tag becomes a single moment. The platform merges your changes to `tag_metadata` with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) or an empty array (`[]`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// The tag must keep at least one key in `tag_metadata`, and it holds up to 50 pairs. If the merged result breaks either limit, the request fails.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="tagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.KnowledgeStoreItemTag>> UpdateAsResponseAsync(
            string knowledgeStoreId,
            string itemId,
            string tagId,

            global::TwelveLabs.UpdateKnowledgeStoreItemTagRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an item tag<br/>
        /// This method updates the range or the `tag_metadata` of the specified tag and returns the tag. Send at least one field. A field you omit keeps its current value. To clear the end of the range, send `end_sec` as `null`. The tag becomes a single moment. The platform merges your changes to `tag_metadata` with the existing metadata:<br/>
        /// - A key with a value creates or replaces that key.<br/>
        /// - A key set to `null` deletes that key.<br/>
        /// - A key set to an empty string (`""`) or an empty array (`[]`) is ignored.<br/>
        /// - A key you omit from the request keeps its current value.<br/>
        /// The tag must keep at least one key in `tag_metadata`, and it holds up to 50 pairs. If the merged result breaks either limit, the request fails.
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="itemId"></param>
        /// <param name="tagId"></param>
        /// <param name="startSec">
        /// The new start of the tag, in seconds from the start of the video. It must be less than the duration of the video. The tag must still end after it starts.
        /// </param>
        /// <param name="endSec">
        /// The new end of the range, in seconds from the start of the video. It must be greater than `start_sec`. It must not exceed the duration of the video. Send `null` to clear the end, which turns a range into a single moment. Omit the field to keep the current end.
        /// </param>
        /// <param name="tagMetadata">
        /// The keys to change. Send at least one key. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, an array of strings, or `null` to delete the key. A key you omit keeps its current value. A nested object and an array containing anything other than strings are rejected. The tag holds up to 50 pairs after the merge. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.KnowledgeStoreItemTag> UpdateAsync(
            string knowledgeStoreId,
            string itemId,
            string tagId,
            double? startSec = default,
            double? endSec = default,
            object? tagMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}