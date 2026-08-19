
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest4
    {
        /// <summary>
        /// The name of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Configuration that controls how content added to the knowledge store is processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingestion_config")]
        public global::TwelveLabs.IngestionConfig? IngestionConfig { get; set; }

        /// <summary>
        /// An optional description of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom metadata for the knowledge store. Both keys and values must be strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest4" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="ingestionConfig">
        /// Configuration that controls how content added to the knowledge store is processed.
        /// </param>
        /// <param name="description">
        /// An optional description of the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the knowledge store. Both keys and values must be strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest4(
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
        /// Initializes a new instance of the <see cref="CreateRequest4" /> class.
        /// </summary>
        public CreateRequest4()
        {
        }

    }
}