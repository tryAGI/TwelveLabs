
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An item tag marks a moment or a range of a video item and carries custom metadata. A video item holds up to 100 tags.
    /// </summary>
    public sealed partial class KnowledgeStoreItemTag
    {
        /// <summary>
        /// The unique identifier of the item tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeStoreId { get; set; }

        /// <summary>
        /// The unique identifier of the knowledge store item that holds the tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The start of the tag, in seconds from the start of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartSec { get; set; }

        /// <summary>
        /// The end of the range, in seconds from the start of the video. The value is `null` for a tag on a single moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// The custom metadata of the tag. Keys are strings. Each value is a string, a number, a boolean, or an array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue> TagMetadata { get; set; }

        /// <summary>
        /// The date and time when the tag was created, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the tag was last updated, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemTag" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the item tag.
        /// </param>
        /// <param name="knowledgeStoreId">
        /// The unique identifier of the knowledge store.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the knowledge store item that holds the tag.
        /// </param>
        /// <param name="startSec">
        /// The start of the tag, in seconds from the start of the video.
        /// </param>
        /// <param name="tagMetadata">
        /// The custom metadata of the tag. Keys are strings. Each value is a string, a number, a boolean, or an array of strings.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the tag was created, in the RFC 3339 format.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the tag was last updated, in the RFC 3339 format.
        /// </param>
        /// <param name="endSec">
        /// The end of the range, in seconds from the start of the video. The value is `null` for a tag on a single moment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItemTag(
            string id,
            string knowledgeStoreId,
            string itemId,
            double startSec,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue> tagMetadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            double? endSec)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KnowledgeStoreId = knowledgeStoreId ?? throw new global::System.ArgumentNullException(nameof(knowledgeStoreId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.TagMetadata = tagMetadata ?? throw new global::System.ArgumentNullException(nameof(tagMetadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemTag" /> class.
        /// </summary>
        public KnowledgeStoreItemTag()
        {
        }

    }
}