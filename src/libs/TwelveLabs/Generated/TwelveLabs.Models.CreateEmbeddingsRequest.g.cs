
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Defines the embedding request. The required fields vary depending on the the value of the `input_type` parameter. For example, when `input_type` is `text`, the `text` field becomes mandatory.
    /// </summary>
    public sealed partial class CreateEmbeddingsRequest
    {
        /// <summary>
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Creates embeddings for an audio file<br/>
        /// - `video`: Creates embeddings for a video file<br/>
        /// - `image`: Creates embeddings for an image file<br/>
        /// - `text`: Creates embeddings for text input<br/>
        /// - `text_image`: Creates embeddings for text and an image<br/>
        /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.CreateEmbeddingsRequestInputType InputType { get; set; }

        /// <summary>
        /// The video understanding model to use. Only "marengo3.0" is supported.<br/>
        /// Default Value: marengo3.0
        /// </summary>
        /// <default>global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter))]
        public global::TwelveLabs.CreateEmbeddingsRequestModelName ModelName { get; set; } = global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30;

        /// <summary>
        /// This field is required if the `input_type` parameter is `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::TwelveLabs.TextInputRequest? Text { get; set; }

        /// <summary>
        /// This field is required if the  `input_type` parameter is `image`.
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
        /// This field is required if the `input_type` parameter is `multi_input`.
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
        /// - `audio`: Creates embeddings for an audio file<br/>
        /// - `video`: Creates embeddings for a video file<br/>
        /// - `image`: Creates embeddings for an image file<br/>
        /// - `text`: Creates embeddings for text input<br/>
        /// - `text_image`: Creates embeddings for text and an image<br/>
        /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the  `input_type` parameter is `image`.
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
        /// This field is required if the `input_type` parameter is `multi_input`.
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to use. Only "marengo3.0" is supported.<br/>
        /// Default Value: marengo3.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequest(
            global::TwelveLabs.CreateEmbeddingsRequestInputType inputType,
            global::TwelveLabs.TextInputRequest? text,
            global::TwelveLabs.ImageInputRequest? image,
            global::TwelveLabs.TextImageInputRequest? textImage,
            global::TwelveLabs.AudioInputRequest? audio,
            global::TwelveLabs.VideoInputRequest? video,
            global::TwelveLabs.MultiInputRequest? multiInput,
            global::TwelveLabs.CreateEmbeddingsRequestModelName modelName = global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30)
        {
            this.InputType = inputType;
            this.ModelName = modelName;
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