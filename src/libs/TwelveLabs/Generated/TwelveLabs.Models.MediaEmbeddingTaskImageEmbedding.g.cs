
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object containing the metadata associated with the embedding. Present only for `image` tasks created with Marengo 3.5.
    /// </summary>
    public sealed partial class MediaEmbeddingTaskImageEmbedding
    {
        /// <summary>
        /// An object containing metadata associated with the embedding. Only Marengo 3.5 returns this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::TwelveLabs.ImageEmbeddingMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEmbeddingTaskImageEmbedding" /> class.
        /// </summary>
        /// <param name="metadata">
        /// An object containing metadata associated with the embedding. Only Marengo 3.5 returns this object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaEmbeddingTaskImageEmbedding(
            global::TwelveLabs.ImageEmbeddingMetadata? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEmbeddingTaskImageEmbedding" /> class.
        /// </summary>
        public MediaEmbeddingTaskImageEmbedding()
        {
        }

    }
}