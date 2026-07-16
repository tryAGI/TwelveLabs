
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A search result for an image. An image matches as a whole object and has no time range.
    /// </summary>
    public sealed partial class SearchKnowledgeStoreHitVariant2
    {
        /// <summary>
        /// Discriminator value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitVariant2AssetTypeJsonConverter))]
        public global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType AssetType { get; set; }

        /// <summary>
        /// The relevance position of this result, starting at 1.
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
        public global::TwelveLabs.ImageSearchItemMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreHitVariant2" /> class.
        /// </summary>
        /// <param name="rank">
        /// The relevance position of this result, starting at 1.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the knowledge store item.
        /// </param>
        /// <param name="assetType">
        /// Discriminator value: image
        /// </param>
        /// <param name="metadata">
        /// Metadata attached to the item. Returned when you set the `include_metadata` parameter to `true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreHitVariant2(
            int rank,
            string itemId,
            global::TwelveLabs.SearchKnowledgeStoreHitVariant2AssetType assetType,
            global::TwelveLabs.ImageSearchItemMetadata? metadata)
        {
            this.AssetType = assetType;
            this.Rank = rank;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreHitVariant2" /> class.
        /// </summary>
        public SearchKnowledgeStoreHitVariant2()
        {
        }

    }
}