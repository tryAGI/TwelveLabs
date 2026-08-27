
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingTaskMediaMetadataDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskMediaMetadataDiscriminator" /> class.
        /// </summary>
        /// <param name="inputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingTaskMediaMetadataDiscriminator(
            string? inputType)
        {
            this.InputType = inputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskMediaMetadataDiscriminator" /> class.
        /// </summary>
        public EmbeddingTaskMediaMetadataDiscriminator()
        {
        }

    }
}