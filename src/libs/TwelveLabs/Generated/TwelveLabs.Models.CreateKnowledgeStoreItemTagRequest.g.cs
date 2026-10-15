
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKnowledgeStoreItemTagRequest
    {
        /// <summary>
        /// The start of the tag, in seconds from the start of the video. It must be less than the duration of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartSec { get; set; }

        /// <summary>
        /// The end of the range, in seconds from the start of the video. It must be greater than `start_sec`. It must not exceed the duration of the video. Omit it, or send `null`, to tag a single moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// The custom metadata of the tag, as key-value pairs. Send at least one key. Up to 50 pairs. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue> TagMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeStoreItemTagRequest" /> class.
        /// </summary>
        /// <param name="startSec">
        /// The start of the tag, in seconds from the start of the video. It must be less than the duration of the video.
        /// </param>
        /// <param name="tagMetadata">
        /// The custom metadata of the tag, as key-value pairs. Send at least one key. Up to 50 pairs. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
        /// <param name="endSec">
        /// The end of the range, in seconds from the start of the video. It must be greater than `start_sec`. It must not exceed the duration of the video. Omit it, or send `null`, to tag a single moment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeStoreItemTagRequest(
            double startSec,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue> tagMetadata,
            double? endSec)
        {
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.TagMetadata = tagMetadata ?? throw new global::System.ArgumentNullException(nameof(tagMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeStoreItemTagRequest" /> class.
        /// </summary>
        public CreateKnowledgeStoreItemTagRequest()
        {
        }

    }
}