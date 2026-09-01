
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
        /// - `document`: A PDF file. Requires Marengo 3.5.<br/>
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
        /// Set this parameter to `true` to receive a [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) field in the response, representing a per-dimension uncertainty vector with the same length as the `embedding` array. A higher value shows lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// To use this parameter with audio or video input, exclude the `asset` scope from the `embedding_scope` field. For example, set `video.embedding_scope` to `["clip"]`. The field defaults to `["clip", "asset"]`, so a request that keeps the default returns a `400` error. This restriction does not apply to `document` and `image` input.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_uncertainty")]
        public bool? EmbeddingUncertainty { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::TwelveLabs.AsyncAudioInputRequest? Audio { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `video`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::TwelveLabs.AsyncVideoInputRequest? Video { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `document`. Requires Marengo 3.5.<br/>
        /// The platform embeds the rendered pages of your PDF file, one embedding per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::TwelveLabs.AsyncDocumentInputRequest? Document { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.5. The image can be up to 32 MB before encoding, whether you provide a URL, an asset identifier, or base64-encoded data. For an image, the `embedding_option`, `embedding_type`, and `embedding_scope` fields each accept a single value; any other value returns a `400` error.
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
        /// - `document`: A PDF file. Requires Marengo 3.5.<br/>
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
        /// Set this parameter to `true` to receive a [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) field in the response, representing a per-dimension uncertainty vector with the same length as the `embedding` array. A higher value shows lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// To use this parameter with audio or video input, exclude the `asset` scope from the `embedding_scope` field. For example, set `video.embedding_scope` to `["clip"]`. The field defaults to `["clip", "asset"]`, so a request that keeps the default returns a `400` error. This restriction does not apply to `document` and `image` input.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="document">
        /// This field is required if the `input_type` parameter is `document`. Requires Marengo 3.5.<br/>
        /// The platform embeds the rendered pages of your PDF file, one embedding per page.
        /// </param>
        /// <param name="image">
        /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.5. The image can be up to 32 MB before encoding, whether you provide a URL, an asset identifier, or base64-encoded data. For an image, the `embedding_option`, `embedding_type`, and `embedding_scope` fields each accept a single value; any other value returns a `400` error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAsyncEmbeddingRequest(
            global::TwelveLabs.CreateAsyncEmbeddingRequestInputType inputType,
            global::TwelveLabs.CreateAsyncEmbeddingRequestModelName modelName,
            bool? embeddingUncertainty,
            global::TwelveLabs.AsyncAudioInputRequest? audio,
            global::TwelveLabs.AsyncVideoInputRequest? video,
            global::TwelveLabs.AsyncDocumentInputRequest? document,
            global::TwelveLabs.AsyncImageInputRequest? image)
        {
            this.InputType = inputType;
            this.ModelName = modelName;
            this.EmbeddingUncertainty = embeddingUncertainty;
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