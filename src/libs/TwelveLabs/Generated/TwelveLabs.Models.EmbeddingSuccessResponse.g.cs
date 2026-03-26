
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingSuccessResponse
    {
        /// <summary>
        /// Array of embedding results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData> Data { get; set; }

        /// <summary>
        /// Metadata for the media input. Available for image, text_image, audio, video, and multi_input inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataJsonConverter))]
        public global::TwelveLabs.EmbeddingMediaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingSuccessResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of embedding results
        /// </param>
        /// <param name="metadata">
        /// Metadata for the media input. Available for image, text_image, audio, video, and multi_input inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingSuccessResponse(
            global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData> data,
            global::TwelveLabs.EmbeddingMediaMetadata? metadata)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingSuccessResponse" /> class.
        /// </summary>
        public EmbeddingSuccessResponse()
        {
        }
    }
}