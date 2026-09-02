
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Defines the embedding request. Set the `input_type` parameter to the kind of content you are embedding, and provide the field with the same name.
    /// </summary>
    public sealed partial class CreateEmbeddingsRequest
    {
        /// <summary>
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `multi_input`: Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
        /// - `audio`: An audio file. Requires Marengo 3.0.<br/>
        /// - `video`: A video file. Requires Marengo 3.0.<br/>
        /// - `image`: An image file. Requires Marengo 3.0.<br/>
        /// - `text`: Text input. Requires Marengo 3.0.<br/>
        /// - `text_image`: Text and an image. Requires Marengo 3.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.CreateEmbeddingsRequestInputType InputType { get; set; }

        /// <summary>
        /// The embedding model to use.<br/>
        /// **Values**:<br/>
        /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
        /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
        /// Default Value: marengo3.0
        /// </summary>
        /// <default>global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.CreateEmbeddingsRequestModelName ModelName { get; set; } = global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30;

        /// <summary>
        /// Controls the behavior of the platform when the text in your request exceeds 2,000 tokens. Requires Marengo 3.5.<br/>
        /// **Values**:<br/>
        /// - `false`: Return a `400` error.<br/>
        /// - `true`: Truncate your text to fit the limit, and set the [`usage.truncated`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.usage.truncated) field to `true` in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_truncate")]
        public bool? AutoTruncate { get; set; }

        /// <summary>
        /// Set this parameter to `true` to receive a [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.data.embedding-uncertainty) field in the response, representing a per-dimension uncertainty vector with the same length as the `embedding` array. A higher value shows lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// Set this parameter to `true` only when your request embeds text only, or media only. Requests that combine text with media sources return a `400` error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_uncertainty")]
        public bool? EmbeddingUncertainty { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::TwelveLabs.TextInputRequest? Text { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::TwelveLabs.ImageInputRequest? Image { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_image")]
        public global::TwelveLabs.TextImageInputRequest? TextImage { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::TwelveLabs.AudioInputRequest? Audio { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `video`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::TwelveLabs.VideoInputRequest? Video { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `multi_input`. It combines text and up to 10 media sources into a single embedding. Provide the `input_text` field, the `media_sources` field, or both.<br/>
        /// Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
        /// Include text in the `input_text` field when you combine media sources of different types. For example, a request that combines an image and a video returns a `400` error without text. Media sources of the same type do not require text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_input")]
        public global::TwelveLabs.MultiInputRequest? MultiInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `multi_input`: Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
        /// - `audio`: An audio file. Requires Marengo 3.0.<br/>
        /// - `video`: A video file. Requires Marengo 3.0.<br/>
        /// - `image`: An image file. Requires Marengo 3.0.<br/>
        /// - `text`: Text input. Requires Marengo 3.0.<br/>
        /// - `text_image`: Text and an image. Requires Marengo 3.0.
        /// </param>
        /// <param name="modelName">
        /// The embedding model to use.<br/>
        /// **Values**:<br/>
        /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
        /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="autoTruncate">
        /// Controls the behavior of the platform when the text in your request exceeds 2,000 tokens. Requires Marengo 3.5.<br/>
        /// **Values**:<br/>
        /// - `false`: Return a `400` error.<br/>
        /// - `true`: Truncate your text to fit the limit, and set the [`usage.truncated`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.usage.truncated) field to `true` in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="embeddingUncertainty">
        /// Set this parameter to `true` to receive a [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#response.body.data.embedding-uncertainty) field in the response, representing a per-dimension uncertainty vector with the same length as the `embedding` array. A higher value shows lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// Set this parameter to `true` only when your request embeds text only, or media only. Requests that combine text with media sources return a `400` error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the `input_type` parameter is `image`.
        /// </param>
        /// <param name="textImage">
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="multiInput">
        /// This field is required if the `input_type` parameter is `multi_input`. It combines text and up to 10 media sources into a single embedding. Provide the `input_text` field, the `media_sources` field, or both.<br/>
        /// Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
        /// Include text in the `input_text` field when you combine media sources of different types. For example, a request that combines an image and a video returns a `400` error without text. Media sources of the same type do not require text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequest(
            global::TwelveLabs.CreateEmbeddingsRequestInputType inputType,
            global::TwelveLabs.CreateEmbeddingsRequestModelName modelName,
            bool? autoTruncate,
            bool? embeddingUncertainty,
            global::TwelveLabs.TextInputRequest? text,
            global::TwelveLabs.ImageInputRequest? image,
            global::TwelveLabs.TextImageInputRequest? textImage,
            global::TwelveLabs.AudioInputRequest? audio,
            global::TwelveLabs.VideoInputRequest? video,
            global::TwelveLabs.MultiInputRequest? multiInput)
        {
            this.InputType = inputType;
            this.ModelName = modelName;
            this.AutoTruncate = autoTruncate;
            this.EmbeddingUncertainty = embeddingUncertainty;
            this.Text = text;
            this.Image = image;
            this.TextImage = textImage;
            this.Audio = audio;
            this.Video = video;
            this.MultiInput = multiInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        public CreateEmbeddingsRequest()
        {
        }

    }
}