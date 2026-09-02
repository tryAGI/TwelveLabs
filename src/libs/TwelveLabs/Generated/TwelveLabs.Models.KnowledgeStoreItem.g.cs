
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
        /// Custom metadata for the item. Keys are strings; each value is a string, a number, a boolean, or an array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

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
        /// Custom metadata for the item. Keys are strings; each value is a string, a number, a boolean, or an array of strings.
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
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.AssetType = assetType;
            this.AssetId = assetId;
            this.Status = status;
            this.SystemMetadata = systemMetadata;
            this.Metadata = metadata;
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