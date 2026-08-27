
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchKnowledgeStoreHitDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreHitDiscriminatorAssetTypeJsonConverter))]
        public global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? AssetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreHitDiscriminator" /> class.
        /// </summary>
        /// <param name="assetType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreHitDiscriminator(
            global::TwelveLabs.SearchKnowledgeStoreHitDiscriminatorAssetType? assetType)
        {
            this.AssetType = assetType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreHitDiscriminator" /> class.
        /// </summary>
        public SearchKnowledgeStoreHitDiscriminator()
        {
        }

    }
}