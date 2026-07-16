
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeStoreItemSystemMetadataDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataDiscriminatorAssetTypeJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? AssetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemSystemMetadataDiscriminator" /> class.
        /// </summary>
        /// <param name="assetType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItemSystemMetadataDiscriminator(
            global::TwelveLabs.KnowledgeStoreItemSystemMetadataDiscriminatorAssetType? assetType)
        {
            this.AssetType = assetType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemSystemMetadataDiscriminator" /> class.
        /// </summary>
        public KnowledgeStoreItemSystemMetadataDiscriminator()
        {
        }

    }
}