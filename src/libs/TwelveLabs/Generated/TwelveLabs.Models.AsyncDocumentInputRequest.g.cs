
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `document`. Requires Marengo 3.5.<br/>
    /// The platform embeds the rendered pages of your PDF file, one embedding per page.
    /// </summary>
    public sealed partial class AsyncDocumentInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.MediaSource MediaSource { get; set; }

        /// <summary>
        /// The type of content to embed.<br/>
        /// **Values**:<br/>
        /// - `visual`: Embeds the rendered pages. Valid for PDF files.<br/>
        /// - `text`: Not supported. Returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? EmbeddingOption { get; set; }

        /// <summary>
        /// Specifies how to structure the embedding.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns one embedding per requested `embedding_scope`.<br/>
        /// - `fused_embedding`: Returns a `400` error. Documents have a single modality.<br/>
        /// **Default**: `separate_embedding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? EmbeddingType { get; set; }

        /// <summary>
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `local`: Returns one embedding per page. The only supported scope for PDF files, and the default.<br/>
        /// - `asset`: Not supported for PDF files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scope")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? EmbeddingScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDocumentInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="embeddingOption">
        /// The type of content to embed.<br/>
        /// **Values**:<br/>
        /// - `visual`: Embeds the rendered pages. Valid for PDF files.<br/>
        /// - `text`: Not supported. Returns a `400` error.
        /// </param>
        /// <param name="embeddingType">
        /// Specifies how to structure the embedding.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns one embedding per requested `embedding_scope`.<br/>
        /// - `fused_embedding`: Returns a `400` error. Documents have a single modality.<br/>
        /// **Default**: `separate_embedding`.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `local`: Returns one embedding per page. The only supported scope for PDF files, and the default.<br/>
        /// - `asset`: Not supported for PDF files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncDocumentInputRequest(
            global::TwelveLabs.MediaSource mediaSource,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? embeddingOption,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? embeddingType,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? embeddingScope)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingType = embeddingType;
            this.EmbeddingScope = embeddingScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncDocumentInputRequest" /> class.
        /// </summary>
        public AsyncDocumentInputRequest()
        {
        }

    }
}