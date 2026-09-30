
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for multi-input embeddings.
    /// </summary>
    public sealed partial class EmbeddingMediaMetadataVariant5
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.EmbeddingMediaMetadataInputType InputType { get; set; }

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
        /// Initializes a new instance of the <see cref="EmbeddingMediaMetadataVariant5" /> class.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="embeddingDimension">
        /// The number of dimensions for each embedding in this response. Only Marengo 3.5 returns this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingMediaMetadataVariant5(
            global::TwelveLabs.EmbeddingMediaMetadataInputType inputType,
            int? embeddingDimension)
        {
            this.InputType = inputType;
            this.EmbeddingDimension = embeddingDimension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingMediaMetadataVariant5" /> class.
        /// </summary>
        public EmbeddingMediaMetadataVariant5()
        {
        }

    }
}