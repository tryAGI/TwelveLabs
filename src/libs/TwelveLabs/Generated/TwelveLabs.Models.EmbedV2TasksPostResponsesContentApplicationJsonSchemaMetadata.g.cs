
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata about the task you created. The platform sets the length of your embeddings when it creates the task, and the `embedding_dimension` field contains that length. Only Marengo 3.5 returns it.
    /// </summary>
    public sealed partial class EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata
    {
        /// <summary>
        /// The number of dimensions for each embedding in this response. Only Marengo 3.5 returns this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dimension")]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata" /> class.
        /// </summary>
        /// <param name="embeddingDimension">
        /// The number of dimensions for each embedding in this response. Only Marengo 3.5 returns this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata(
            int? embeddingDimension)
        {
            this.EmbeddingDimension = embeddingDimension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata" /> class.
        /// </summary>
        public EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata()
        {
        }

    }
}