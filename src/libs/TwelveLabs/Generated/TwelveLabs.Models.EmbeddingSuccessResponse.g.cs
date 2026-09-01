
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
        /// Token counts for the request. Only Marengo 3.5 returns this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::TwelveLabs.EmbeddingUsage? Usage { get; set; }

        /// <summary>
        /// Metadata for the media input. Available for the `image`, `text_image`, `audio`, `video`, and `multi_input` input types.
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
        /// <param name="usage">
        /// Token counts for the request. Only Marengo 3.5 returns this field.
        /// </param>
        /// <param name="metadata">
        /// Metadata for the media input. Available for the `image`, `text_image`, `audio`, `video`, and `multi_input` input types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingSuccessResponse(
            global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData> data,
            global::TwelveLabs.EmbeddingUsage? usage,
            global::TwelveLabs.EmbeddingMediaMetadata? metadata)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage;
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