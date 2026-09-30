
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `document`. Requires Marengo 3.5.<br/>
    /// The platform accepts PDF (`.pdf`), plain text (`.txt`), and Markdown (`.md`) files. The decoded file can be up to 512 MB. It embeds a PDF file from its rendered pages or from its extracted text, and a plain text or Markdown file from its text.<br/>
    /// A PDF file also has a page allowance: 64 pages for each MB of file size. A 0.5 MB file is allowed 64 pages, and a 4 MB file is allowed 256 pages. The `quadrants` strategy counts each page five times against this allowance. The platform checks the page count of the file against the allowance before processing the file. If the file exceeds the allowance, the platform creates the task and sets its `status` field to the `failed` value. The `error.message` field contains the page count and the allowance. Plain text and Markdown files have no page allowance.<br/>
    /// The `embedding_option` and `embedding_scope` fields combine, and the platform supports the following combinations.<br/>
    /// | File type | `embedding_option` | `embedding_scope` | Result |<br/>
    /// |-----------|--------------------|-------------------|--------|<br/>
    /// | PDF | `visual` | `local` | One embedding for each rendered page. The default for PDF files. |<br/>
    /// | PDF | `visual` | `asset` | One embedding for the entire file. |<br/>
    /// | PDF | `text` | `asset` | One embedding for the extracted text of the entire file. |<br/>
    /// | Plain text, Markdown | `text` | `asset` | One embedding for the entire file. The default for plain text and Markdown files. |<br/>
    /// | Plain text, Markdown | `text` | `local` | One embedding for each chunk of whole sentences. Requires the `segmentation.sequential` field. |<br/>
    /// You can request more than one combination at a time. For example, `embedding_scope: ["local", "asset"]` on a PDF file returns the per-page embeddings and the whole-file embedding together. The platform pairs each value in one field with each value in the other. Each pair must appear in this table; if you send a pair outside it, the platform returns a `400` error. If you omit a field, the platform uses its default value. If you embed a PDF file with `embedding_option: ["text"]`, also set `embedding_scope: ["asset"]`. For PDF files, the default `["local"]` pairs with only the `visual` option.
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
        /// Specifies how the platform divides your document before it generates embeddings. Requires Marengo 3.5.<br/>
        /// Use the `spatial` field to divide each rendered page of a PDF file. Use the `sequential` field to divide a plain text or Markdown file into chunks.<br/>
        /// Provide the field that matches your file. If you provide neither field, the platform returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation")]
        public global::TwelveLabs.DocumentSegmentation? Segmentation { get; set; }

        /// <summary>
        /// The types of embeddings to generate for the document.<br/>
        /// **Values**:<br/>
        /// - `visual`: Generates embeddings from the rendered pages. Valid for PDF files.<br/>
        /// - `text`: Generates embeddings from the text content. Valid for PDF, plain text, and Markdown files.<br/>
        /// **Default**: `["visual"]` for PDF files; `["text"]` for plain text and Markdown files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? EmbeddingOption { get; set; }

        /// <summary>
        /// Specifies how to structure the embedding.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns one embedding per requested `embedding_scope`.<br/>
        /// - `fused_embedding`: The platform returns a `400` error if you set this value. Documents have a single modality.<br/>
        /// **Default**: `separate_embedding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? EmbeddingType { get; set; }

        /// <summary>
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `local`: Returns one embedding for each part of the file.<br/>
        ///     - For a PDF file, each part is a rendered page. You can divide each page further with the `segmentation.spatial` field.<br/>
        ///     - For a plain text or Markdown file, each part is a chunk of whole sentences. The `segmentation.sequential` field is required.<br/>
        /// - `asset`: Returns one embedding for the entire file.<br/>
        /// **Default**: `["local"]` for PDF files; `["asset"]` for plain text and Markdown files.
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
        /// <param name="segmentation">
        /// Specifies how the platform divides your document before it generates embeddings. Requires Marengo 3.5.<br/>
        /// Use the `spatial` field to divide each rendered page of a PDF file. Use the `sequential` field to divide a plain text or Markdown file into chunks.<br/>
        /// Provide the field that matches your file. If you provide neither field, the platform returns a `400` error.
        /// </param>
        /// <param name="embeddingOption">
        /// The types of embeddings to generate for the document.<br/>
        /// **Values**:<br/>
        /// - `visual`: Generates embeddings from the rendered pages. Valid for PDF files.<br/>
        /// - `text`: Generates embeddings from the text content. Valid for PDF, plain text, and Markdown files.<br/>
        /// **Default**: `["visual"]` for PDF files; `["text"]` for plain text and Markdown files.
        /// </param>
        /// <param name="embeddingType">
        /// Specifies how to structure the embedding.<br/>
        /// **Values**:<br/>
        /// - `separate_embedding`: Returns one embedding per requested `embedding_scope`.<br/>
        /// - `fused_embedding`: The platform returns a `400` error if you set this value. Documents have a single modality.<br/>
        /// **Default**: `separate_embedding`.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which you wish to generate embeddings.<br/>
        /// **Values**:<br/>
        /// - `local`: Returns one embedding for each part of the file.<br/>
        ///     - For a PDF file, each part is a rendered page. You can divide each page further with the `segmentation.spatial` field.<br/>
        ///     - For a plain text or Markdown file, each part is a chunk of whole sentences. The `segmentation.sequential` field is required.<br/>
        /// - `asset`: Returns one embedding for the entire file.<br/>
        /// **Default**: `["local"]` for PDF files; `["asset"]` for plain text and Markdown files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncDocumentInputRequest(
            global::TwelveLabs.MediaSource mediaSource,
            global::TwelveLabs.DocumentSegmentation? segmentation,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingOptionItems>? embeddingOption,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingTypeItems>? embeddingType,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncDocumentInputRequestEmbeddingScopeItems>? embeddingScope)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
            this.Segmentation = segmentation;
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