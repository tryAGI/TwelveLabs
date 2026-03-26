
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding
    {
        /// <summary>
        /// An object containing metadata associated with the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::TwelveLabs.VideoEmbeddingMetadata? Metadata { get; set; }

        /// <summary>
        /// An array of objects containing the embeddings for each video segment and the associated information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding" /> class.
        /// </summary>
        /// <param name="metadata">
        /// An object containing metadata associated with the embedding.
        /// </param>
        /// <param name="segments">
        /// An array of objects containing the embeddings for each video segment and the associated information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding(
            global::TwelveLabs.VideoEmbeddingMetadata? metadata,
            global::System.Collections.Generic.IList<global::TwelveLabs.VideoSegment>? segments)
        {
            this.Metadata = metadata;
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding" /> class.
        /// </summary>
        public EmbedTasksTaskIdGetResponsesContentApplicationJsonSchemaVideoEmbedding()
        {
        }
    }
}