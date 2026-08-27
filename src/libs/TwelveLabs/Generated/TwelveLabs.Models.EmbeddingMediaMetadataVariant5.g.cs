
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for multi-input embeddings
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingMediaMetadataVariant5" /> class.
        /// </summary>
        /// <param name="inputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingMediaMetadataVariant5(
            global::TwelveLabs.EmbeddingMediaMetadataInputType inputType)
        {
            this.InputType = inputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingMediaMetadataVariant5" /> class.
        /// </summary>
        public EmbeddingMediaMetadataVariant5()
        {
        }

    }
}