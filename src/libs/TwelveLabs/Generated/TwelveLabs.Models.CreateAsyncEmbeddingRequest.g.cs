
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Defines the asynchronous embedding request. Set the `input_type` parameter to the kind of content you are embedding, and provide the field with the same name.
    /// </summary>
    public sealed partial class CreateAsyncEmbeddingRequest
    {
        /// <summary>
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: An audio file.<br/>
        /// - `video`: A video file.<br/>
        /// - `document`: A PDF, plain text, or Markdown file. Requires Marengo 3.5.<br/>
        /// - `image`: An image file. Requires Marengo 3.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.CreateAsyncEmbeddingRequestInputType InputType { get; set; }

        /// <summary>
        /// The embedding model to use.<br/>
        /// **Values**:<br/>
        /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
        /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
        /// Default Value: marengo3.0
        /// </summary>
        /// <default>global::TwelveLabs.CreateAsyncEmbeddingRequestModelName.Marengo30</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.CreateAsyncEmbeddingRequestModelName ModelName { get; set; } = global::TwelveLabs.CreateAsyncEmbeddingRequestModelName.Marengo30;

        /// <summary>
        /// Set this parameter to `true` to include a per-dimension uncertainty vector in the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) field of the result. The vector has the same length as the `embedding` array. A higher value indicates lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// **Requirements**:<br/>
        /// - For audio or video input, set the `embedding_scope` field to exclude `asset`. For example, set the `video.embedding_scope` field to `["clip"]`. The field defaults to `["clip", "asset"]`, so the platform returns a `400` error if you keep the default. This requirement does not apply to image input.<br/>
        /// - For a PDF document, the platform returns a `400` error regardless of the `document.embedding_scope` value.<br/>
        /// - For a plain text or Markdown document, set the `document.embedding_scope` field to `["local"]`. Any other value returns a `400` error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_uncertainty")]
        public bool? EmbeddingUncertainty { get; set; }

        /// <summary>
        /// The number of dimensions for each embedding that the task produces, including the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) vector.<br/>
        /// Marengo 3.5 produces Matryoshka embeddings: a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.<br/>
        /// **Requirements**:<br/>
        /// - Requires Marengo 3.5. Setting this parameter with `model_name: marengo3.0` returns a `400` error.<br/>
        /// - Applies to the entire task: you cannot set it for a single input type or embedding.<br/>
        /// - Set it once, when you create the task. To use a different value, create a new task.<br/>
        /// - Use the same value across an index.<br/>
        /// **Default**: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dimension")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAsyncEmbeddingRequestEmbeddingDimensionJsonConverter))]
        public global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension? EmbeddingDimension { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `audio`.<br/>
        /// Base64-encoded audio can be up to 36 MB decoded. For a larger file, provide a URL or an asset identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::TwelveLabs.AsyncAudioInputRequest? Audio { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `video`.<br/>
        /// Base64-encoded video can be up to 36 MB decoded. For a larger file, provide a URL or an asset identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::TwelveLabs.AsyncVideoInputRequest? Video { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::TwelveLabs.AsyncDocumentInputRequest? Document { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.5. The decoded file can be up to 32 MB. For an image, the `embedding_option`, `embedding_type`, and `embedding_scope` fields each accept a single value; the platform returns a `400` error if you send any other value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::TwelveLabs.AsyncImageInputRequest? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: An audio file.<br/>
        /// - `video`: A video file.<br/>
        /// - `document`: A PDF, plain text, or Markdown file. Requires Marengo 3.5.<br/>
        /// - `image`: An image file. Requires Marengo 3.5.
        /// </param>
        /// <param name="modelName">
        /// The embedding model to use.<br/>
        /// **Values**:<br/>
        /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
        /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="embeddingUncertainty">
        /// Set this parameter to `true` to include a per-dimension uncertainty vector in the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) field of the result. The vector has the same length as the `embedding` array. A higher value indicates lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// **Requirements**:<br/>
        /// - For audio or video input, set the `embedding_scope` field to exclude `asset`. For example, set the `video.embedding_scope` field to `["clip"]`. The field defaults to `["clip", "asset"]`, so the platform returns a `400` error if you keep the default. This requirement does not apply to image input.<br/>
        /// - For a PDF document, the platform returns a `400` error regardless of the `document.embedding_scope` value.<br/>
        /// - For a plain text or Markdown document, set the `document.embedding_scope` field to `["local"]`. Any other value returns a `400` error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingDimension">
        /// The number of dimensions for each embedding that the task produces, including the [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) vector.<br/>
        /// Marengo 3.5 produces Matryoshka embeddings: a shorter embedding consists of the first values of the full-length embedding. A 256-dimension embedding, for example, is the first 256 values of a 512-dimension embedding of the same content. Shorter embeddings reduce index size and speed up similarity search; longer embeddings produce higher retrieval quality.<br/>
        /// **Requirements**:<br/>
        /// - Requires Marengo 3.5. Setting this parameter with `model_name: marengo3.0` returns a `400` error.<br/>
        /// - Applies to the entire task: you cannot set it for a single input type or embedding.<br/>
        /// - Set it once, when you create the task. To use a different value, create a new task.<br/>
        /// - Use the same value across an index.<br/>
        /// **Default**: 512
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.<br/>
        /// Base64-encoded audio can be up to 36 MB decoded. For a larger file, provide a URL or an asset identifier.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.<br/>
        /// Base64-encoded video can be up to 36 MB decoded. For a larger file, provide a URL or an asset identifier.
        /// </param>
        /// <param name="document">
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
        /// </param>
        /// <param name="image">
        /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.5. The decoded file can be up to 32 MB. For an image, the `embedding_option`, `embedding_type`, and `embedding_scope` fields each accept a single value; the platform returns a `400` error if you send any other value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAsyncEmbeddingRequest(
            global::TwelveLabs.CreateAsyncEmbeddingRequestInputType inputType,
            global::TwelveLabs.CreateAsyncEmbeddingRequestModelName modelName,
            bool? embeddingUncertainty,
            global::TwelveLabs.CreateAsyncEmbeddingRequestEmbeddingDimension? embeddingDimension,
            global::TwelveLabs.AsyncAudioInputRequest? audio,
            global::TwelveLabs.AsyncVideoInputRequest? video,
            global::TwelveLabs.AsyncDocumentInputRequest? document,
            global::TwelveLabs.AsyncImageInputRequest? image)
        {
            this.InputType = inputType;
            this.ModelName = modelName;
            this.EmbeddingUncertainty = embeddingUncertainty;
            this.EmbeddingDimension = embeddingDimension;
            this.Audio = audio;
            this.Video = video;
            this.Document = document;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncEmbeddingRequest" /> class.
        /// </summary>
        public CreateAsyncEmbeddingRequest()
        {
        }

    }
}