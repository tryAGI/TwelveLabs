
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateKnowledgeStoreItemTagRequest
    {
        /// <summary>
        /// The new start of the tag, in seconds from the start of the video. It must be less than the duration of the video. The tag must still end after it starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// The new end of the range, in seconds from the start of the video. It must be greater than `start_sec`. It must not exceed the duration of the video. Send `null` to clear the end, which turns a range into a single moment. Omit the field to keep the current end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// The keys to change. Send at least one key. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, an array of strings, or `null` to delete the key. A key you omit keeps its current value. A nested object and an array containing anything other than strings are rejected. The tag holds up to 50 pairs after the merge. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_metadata")]
        public object? TagMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeStoreItemTagRequest" /> class.
        /// </summary>
        /// <param name="startSec">
        /// The new start of the tag, in seconds from the start of the video. It must be less than the duration of the video. The tag must still end after it starts.
        /// </param>
        /// <param name="endSec">
        /// The new end of the range, in seconds from the start of the video. It must be greater than `start_sec`. It must not exceed the duration of the video. Send `null` to clear the end, which turns a range into a single moment. Omit the field to keep the current end.
        /// </param>
        /// <param name="tagMetadata">
        /// The keys to change. Send at least one key. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, an array of strings, or `null` to delete the key. A key you omit keeps its current value. A nested object and an array containing anything other than strings are rejected. The tag holds up to 50 pairs after the merge. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKnowledgeStoreItemTagRequest(
            double? startSec,
            double? endSec,
            object? tagMetadata)
        {
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.TagMetadata = tagMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeStoreItemTagRequest" /> class.
        /// </summary>
        public UpdateKnowledgeStoreItemTagRequest()
        {
        }

    }
}