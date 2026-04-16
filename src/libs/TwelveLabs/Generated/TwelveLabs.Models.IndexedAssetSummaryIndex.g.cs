
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The index to which the indexed asset belongs.
    /// </summary>
    public sealed partial class IndexedAssetSummaryIndex
    {
        /// <summary>
        /// The unique identifier of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetSummaryIndex" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the index.
        /// </param>
        /// <param name="name">
        /// The name of the index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexedAssetSummaryIndex(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetSummaryIndex" /> class.
        /// </summary>
        public IndexedAssetSummaryIndex()
        {
        }
    }
}