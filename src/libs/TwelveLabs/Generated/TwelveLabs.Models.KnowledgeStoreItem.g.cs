
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A knowledge store item is an asset added to a knowledge store for processing. You can use it in different workflows once its `status` is `ready`.
    /// </summary>
    public sealed partial class KnowledgeStoreItem
    {
        /// <summary>
        /// The unique identifier of the knowledge store item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.KnowledgeStoreItemAssetType AssetType { get; set; }

        /// <summary>
        /// The unique identifier of the source asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The processing status of the item. For the meaning of each value, see the<br/>
        /// [Item statuses](/v1.3/api-reference/knowledge-store-items/the-knowledge-store-item-object#item-statuses)<br/>
        /// section on **The knowledge store item object** page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemStatus? Status { get; set; }

        /// <summary>
        /// System-generated media metadata for the source asset. Its `asset_type` field<br/>
        /// always matches the item's top-level `asset_type` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemSystemMetadataJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// Custom metadata from the source asset. Keys are strings; each value is a string, a number, a boolean, or an array of strings. The platform updates it when the user-defined metadata of the asset changes. To change it, use the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint. To store metadata on the item alone, use `item_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Metadata { get; set; }

        /// <summary>
        /// Custom metadata stored on this item alone. Keys are strings; each value is a string, a number, a boolean, or an array of strings. The source asset never changes it, so the same key can have a different value in `metadata` and in `item_metadata`. You set it when you create the item or change it with the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint. The field is absent when the item has no item metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? ItemMetadata { get; set; }

        /// <summary>
        /// Metadata that the platform extracts from the whole item, as defined by the enrichment configuration of the knowledge store. It holds the properties whose `granularity` is `video` for a video, or `image` for an image. Properties whose `granularity` is `shot` do not appear in this field. Keys are the property names; each value matches its property definition. A property with no value is omitted. The field is present only when the item is `ready` and holds at least one value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enriched_metadata")]
        public object? EnrichedMetadata { get; set; }

        /// <summary>
        /// The date and time when the item was created, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the item was last updated, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItem" /> class.
        /// </summary>
        /// <param name="assetType">
        /// The type of item.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the knowledge store item.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of the source asset.
        /// </param>
        /// <param name="status">
        /// The processing status of the item. For the meaning of each value, see the<br/>
        /// [Item statuses](/v1.3/api-reference/knowledge-store-items/the-knowledge-store-item-object#item-statuses)<br/>
        /// section on **The knowledge store item object** page.
        /// </param>
        /// <param name="systemMetadata">
        /// System-generated media metadata for the source asset. Its `asset_type` field<br/>
        /// always matches the item's top-level `asset_type` field.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata from the source asset. Keys are strings; each value is a string, a number, a boolean, or an array of strings. The platform updates it when the user-defined metadata of the asset changes. To change it, use the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint. To store metadata on the item alone, use `item_metadata`.
        /// </param>
        /// <param name="itemMetadata">
        /// Custom metadata stored on this item alone. Keys are strings; each value is a string, a number, a boolean, or an array of strings. The source asset never changes it, so the same key can have a different value in `metadata` and in `item_metadata`. You set it when you create the item or change it with the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint. The field is absent when the item has no item metadata.
        /// </param>
        /// <param name="enrichedMetadata">
        /// Metadata that the platform extracts from the whole item, as defined by the enrichment configuration of the knowledge store. It holds the properties whose `granularity` is `video` for a video, or `image` for an image. Properties whose `granularity` is `shot` do not appear in this field. Keys are the property names; each value matches its property definition. A property with no value is omitted. The field is present only when the item is `ready` and holds at least one value.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the item was created, in the RFC 3339 format.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the item was last updated, in the RFC 3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItem(
            global::TwelveLabs.KnowledgeStoreItemAssetType assetType,
            string? id,
            string? assetId,
            global::TwelveLabs.KnowledgeStoreItemStatus? status,
            global::TwelveLabs.KnowledgeStoreItemSystemMetadata? systemMetadata,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? metadata,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? itemMetadata,
            object? enrichedMetadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.AssetType = assetType;
            this.AssetId = assetId;
            this.Status = status;
            this.SystemMetadata = systemMetadata;
            this.Metadata = metadata;
            this.ItemMetadata = itemMetadata;
            this.EnrichedMetadata = enrichedMetadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItem" /> class.
        /// </summary>
        public KnowledgeStoreItem()
        {
        }

    }
}