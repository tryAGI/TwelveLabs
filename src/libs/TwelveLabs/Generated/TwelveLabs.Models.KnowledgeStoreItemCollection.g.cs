
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A named collection of items within a knowledge store. Use item collections to organize and reference subsets of items together. The items themselves are not affected.
    /// </summary>
    public sealed partial class KnowledgeStoreItemCollection
    {
        /// <summary>
        /// The unique identifier of the item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier of the knowledge store this collection belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_store_id")]
        public string? KnowledgeStoreId { get; set; }

        /// <summary>
        /// The name of the item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom metadata for the item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The number of items in the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_count")]
        public int? MemberCount { get; set; }

        /// <summary>
        /// The date and time when the item collection was created, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the item collection was last updated, in the RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemCollection" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the item collection.
        /// </param>
        /// <param name="knowledgeStoreId">
        /// The unique identifier of the knowledge store this collection belongs to.
        /// </param>
        /// <param name="name">
        /// The name of the item collection.
        /// </param>
        /// <param name="description">
        /// The description of the item collection.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item collection.
        /// </param>
        /// <param name="memberCount">
        /// The number of items in the collection.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the item collection was created, in the RFC 3339 format.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the item collection was last updated, in the RFC 3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItemCollection(
            string? id,
            string? knowledgeStoreId,
            string? name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? memberCount,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.KnowledgeStoreId = knowledgeStoreId;
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.MemberCount = memberCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemCollection" /> class.
        /// </summary>
        public KnowledgeStoreItemCollection()
        {
        }

    }
}