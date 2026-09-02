
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRequest5
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
        /// Custom metadata for the item, as user-defined key-value pairs. Up to 50 pairs, keys up to 128 characters, string values up to 8192 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest5" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of the asset to add to the knowledge store.
        /// </param>
        /// <param name="assetType">
        /// The type of item to create.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item, as user-defined key-value pairs. Up to 50 pairs, keys up to 128 characters, string values up to 8192 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest5(
            string assetId,
            global::TwelveLabs.KnowledgeStoreItemAssetType? assetType,
            object? metadata)
        {
            this.AssetType = assetType;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest5" /> class.
        /// </summary>
        public CreateRequest5()
        {
        }

    }
}