
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A knowledge store is a persistent, queryable store of videos plus derived understanding: spatiotemporal context, a typed ontology, and embeddings.<br/>
    /// These layers enable corpus-level reasoning across the full collection.
    /// </summary>
    public sealed partial class KnowledgeStore
    {
        /// <summary>
        /// The unique identifier of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An optional description of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Configuration that controls how content added to this knowledge store is processed.<br/>
        /// This field is immutable after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestion_config")]
        public global::TwelveLabs.IngestionConfig? IngestionConfig { get; set; }

        /// <summary>
        /// The number of items in the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// The date and time when the knowledge store was created, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the knowledge store was last updated, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Key-value pairs attached to the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStore" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the knowledge store.
        /// </param>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="description">
        /// An optional description of the knowledge store.
        /// </param>
        /// <param name="ingestionConfig">
        /// Configuration that controls how content added to this knowledge store is processed.<br/>
        /// This field is immutable after creation.
        /// </param>
        /// <param name="itemCount">
        /// The number of items in the knowledge store.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the knowledge store was created, in the RFC 3339 format.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the knowledge store was last updated, in the RFC 3339 format.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs attached to the knowledge store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStore(
            string? id,
            string? name,
            string? description,
            global::TwelveLabs.IngestionConfig? ingestionConfig,
            int? itemCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.IngestionConfig = ingestionConfig;
            this.ItemCount = itemCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStore" /> class.
        /// </summary>
        public KnowledgeStore()
        {
        }
    }
}