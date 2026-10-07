
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// Custom metadata for the item, as user-defined key-value pairs. Up to 50 pairs, keys up to 128 characters, string values up to 8192 characters. Keys are strings; values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string. To change it after you create the item, use the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? ItemMetadata { get; set; }

        /// <summary>
        /// Deprecated. Use `item_metadata` instead. The item stores the pairs in its `item_metadata` field and not in its `metadata` field. Send `item_metadata` or `metadata`, not both. A request that sets both returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Metadata { get; set; }

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
        /// <param name="itemMetadata">
        /// Custom metadata for the item, as user-defined key-value pairs. Up to 50 pairs, keys up to 128 characters, string values up to 8192 characters. Keys are strings; values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string. To change it after you create the item, use the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest5(
            string assetId,
            global::TwelveLabs.KnowledgeStoreItemAssetType? assetType,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? itemMetadata)
        {
            this.AssetType = assetType;
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.ItemMetadata = itemMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest5" /> class.
        /// </summary>
        public CreateRequest5()
        {
        }

    }
}