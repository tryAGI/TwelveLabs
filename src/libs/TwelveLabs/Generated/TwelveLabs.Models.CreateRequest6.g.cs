
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest6
    {
        /// <summary>
        /// The type of item to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemAssetType? AssetType { get; set; }

        /// <summary>
        /// The unique identifier of the asset to add to the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Custom metadata for the item. Both keys and values must be strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest6" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of the asset to add to the knowledge store.
        /// </param>
        /// <param name="assetType">
        /// The type of item to create.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item. Both keys and values must be strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest6(
            string assetId,
            global::TwelveLabs.KnowledgeStoreItemAssetType? assetType,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.AssetType = assetType;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest6" /> class.
        /// </summary>
        public CreateRequest6()
        {
        }

    }
}