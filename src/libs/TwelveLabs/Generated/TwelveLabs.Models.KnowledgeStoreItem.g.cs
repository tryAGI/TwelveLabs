
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An item within a knowledge store, representing a video that has been or is being processed.
    /// </summary>
    public sealed partial class KnowledgeStoreItem
    {
        /// <summary>
        /// The unique identifier of the knowledge store item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier of the source video asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The processing status of the item. The following options are available:<br/>
        /// - `queued`: The item has been submitted and is waiting to be processed.<br/>
        /// - `pending`: The item has been dispatched and is waiting for available processing capacity.<br/>
        /// - `processing`: The item is currently being processed.<br/>
        /// - `ready`: The item has been successfully processed.<br/>
        /// - `failed`: The item processing has failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemStatusJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemStatus? Status { get; set; }

        /// <summary>
        /// Key-value pairs attached to the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

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
        /// <param name="id">
        /// The unique identifier of the knowledge store item.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of the source video asset.
        /// </param>
        /// <param name="status">
        /// The processing status of the item. The following options are available:<br/>
        /// - `queued`: The item has been submitted and is waiting to be processed.<br/>
        /// - `pending`: The item has been dispatched and is waiting for available processing capacity.<br/>
        /// - `processing`: The item is currently being processed.<br/>
        /// - `ready`: The item has been successfully processed.<br/>
        /// - `failed`: The item processing has failed.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs attached to the item.
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
            string? id,
            string? assetId,
            global::TwelveLabs.KnowledgeStoreItemStatus? status,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.AssetId = assetId;
            this.Status = status;
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