
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.5. The image can be up to 32 MB before encoding, whether you provide a URL, an asset identifier, or base64-encoded data. For an image, the `embedding_option`, `embedding_type`, and `embedding_scope` fields each accept a single value; any other value returns a `400` error.
    /// </summary>
    public sealed partial class AsyncImageInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.MediaSource MediaSource { get; set; }

        /// <summary>
        /// The type of embedding to generate for the image. Always `visual`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? EmbeddingOption { get; set; }

        /// <summary>
        /// Specifies how to structure the embedding. Always `separate_embedding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? EmbeddingType { get; set; }

        /// <summary>
        /// The scope for which to generate embeddings. Always `asset`, which produces one embedding for the entire image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scope")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? EmbeddingScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncImageInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="embeddingOption">
        /// The type of embedding to generate for the image. Always `visual`.
        /// </param>
        /// <param name="embeddingType">
        /// Specifies how to structure the embedding. Always `separate_embedding`.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which to generate embeddings. Always `asset`, which produces one embedding for the entire image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncImageInputRequest(
            global::TwelveLabs.MediaSource mediaSource,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingOptionItems>? embeddingOption,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingTypeItems>? embeddingType,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageInputRequestEmbeddingScopeItems>? embeddingScope)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingType = embeddingType;
            this.EmbeddingScope = embeddingScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncImageInputRequest" /> class.
        /// </summary>
        public AsyncImageInputRequest()
        {
        }

    }
}