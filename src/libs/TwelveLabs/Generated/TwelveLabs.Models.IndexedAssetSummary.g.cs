
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The identifier and index of an indexed asset that references the specified asset.
    /// </summary>
    public sealed partial class IndexedAssetSummary
    {
        /// <summary>
        /// The unique identifier of the indexed asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The index to which the indexed asset belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public global::TwelveLabs.IndexedAssetSummaryIndex? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the indexed asset.
        /// </param>
        /// <param name="index">
        /// The index to which the indexed asset belongs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexedAssetSummary(
            string? id,
            global::TwelveLabs.IndexedAssetSummaryIndex? index)
        {
            this.Id = id;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetSummary" /> class.
        /// </summary>
        public IndexedAssetSummary()
        {
        }
    }
}