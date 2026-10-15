
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results by type of item. Provide exactly one operator: `eq` to match one type, or `in` to match any of the listed types.
    /// </summary>
    public sealed partial class AssetTypeFilter
    {
        /// <summary>
        /// Match items that have this value for `asset_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemAssetType? Eq { get; set; }

        /// <summary>
        /// Match items that have any of these values for `asset_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTypeFilter" /> class.
        /// </summary>
        /// <param name="eq">
        /// Match items that have this value for `asset_type`.
        /// </param>
        /// <param name="in">
        /// Match items that have any of these values for `asset_type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetTypeFilter(
            global::TwelveLabs.KnowledgeStoreItemAssetType? eq,
            global::System.Collections.Generic.IList<global::TwelveLabs.KnowledgeStoreItemAssetType>? @in)
        {
            this.Eq = eq;
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTypeFilter" /> class.
        /// </summary>
        public AssetTypeFilter()
        {
        }

    }
}