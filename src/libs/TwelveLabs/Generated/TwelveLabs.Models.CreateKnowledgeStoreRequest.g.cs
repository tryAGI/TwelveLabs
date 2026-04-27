
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKnowledgeStoreRequest
    {
        /// <summary>
        /// The name of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Configuration that controls how content added to this knowledge store is processed.<br/>
        /// This field is immutable after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestion_config")]
        public global::TwelveLabs.IngestionConfig? IngestionConfig { get; set; }

        /// <summary>
        /// An optional description of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Key-value pairs to attach to the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeStoreRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="ingestionConfig">
        /// Configuration that controls how content added to this knowledge store is processed.<br/>
        /// This field is immutable after creation.
        /// </param>
        /// <param name="description">
        /// An optional description of the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to attach to the knowledge store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeStoreRequest(
            string name,
            global::TwelveLabs.IngestionConfig? ingestionConfig,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IngestionConfig = ingestionConfig;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeStoreRequest" /> class.
        /// </summary>
        public CreateKnowledgeStoreRequest()
        {
        }
    }
}