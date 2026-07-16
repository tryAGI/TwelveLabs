
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A search result for a video.
    /// </summary>
    public sealed partial class SearchKnowledgeStoreHitVariant1
    {
        /// <summary>
        /// Discriminator value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant1AssetTypeJsonConverter))]
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType AssetType { get; set; }

        /// <summary>
        /// The relevance position of this result, starting at 1. When `group_by` is `item`, videos are ordered by their most relevant clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// The unique identifier of the knowledge store item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Metadata attached to the item. Returned when you set the `include_metadata` parameter to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::TwelveLabs.VideoSearchItemMetadata? Metadata { get; set; }

        /// <summary>
        /// Matching clips from this video, ordered by relevance.<br/>
        /// - When `group_by` is `none`: Contains one entry — the matching clip.<br/>
        /// - When `group_by` is `item`: Contains all matching clips from this video, with the best match first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch> Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreHitVariant1" /> class.
        /// </summary>
        /// <param name="rank">
        /// The relevance position of this result, starting at 1. When `group_by` is `item`, videos are ordered by their most relevant clip.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the knowledge store item.
        /// </param>
        /// <param name="matches">
        /// Matching clips from this video, ordered by relevance.<br/>
        /// - When `group_by` is `none`: Contains one entry — the matching clip.<br/>
        /// - When `group_by` is `item`: Contains all matching clips from this video, with the best match first.
        /// </param>
        /// <param name="assetType">
        /// Discriminator value: video
        /// </param>
        /// <param name="metadata">
        /// Metadata attached to the item. Returned when you set the `include_metadata` parameter to `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreHitVariant1(
            int rank,
            string itemId,
            global::System.Collections.Generic.IList<global::TwelveLabs.VideoMatch> matches,
            global::TwelveLabs.SearchKnowledgeStoreHitVariant1AssetType assetType,
            global::TwelveLabs.VideoSearchItemMetadata? metadata)
        {
            this.AssetType = assetType;
            this.Rank = rank;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Metadata = metadata;
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreHitVariant1" /> class.
        /// </summary>
        public SearchKnowledgeStoreHitVariant1()
        {
        }

    }
}