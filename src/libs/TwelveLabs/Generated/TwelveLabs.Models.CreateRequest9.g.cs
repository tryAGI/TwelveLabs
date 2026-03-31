
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest9
    {
        /// <summary>
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The text for which you wish to create an embedding.<br/>
        /// **Example**: "Man with a dog crossing the street"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The publicly accessible URL of the image for which you wish to create an embedding. This parameter is required for image embeddings if `image_file` is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_filename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// The publicly accessible URL of the audio file for which you wish to creae an embedding. This parameter is required for audio embeddings if `audio_file` is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file")]
        public byte[]? AudioFile { get; set; }

        /// <summary>
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_filename")]
        public string? AudioFilename { get; set; }

        /// <summary>
        /// Specifies the start time, in seconds, from which the platform generates the audio embeddings. This parameter allows you to skip the initial portion of the audio during processing.<br/>
        /// **Default**: `0`.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_offset_sec")]
        public double? AudioStartOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest9" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.
        /// </param>
        /// <param name="text">
        /// The text for which you wish to create an embedding.<br/>
        /// **Example**: "Man with a dog crossing the street"
        /// </param>
        /// <param name="imageUrl">
        /// The publicly accessible URL of the image for which you wish to create an embedding. This parameter is required for image embeddings if `image_file` is not provided.
        /// </param>
        /// <param name="imageFile">
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </param>
        /// <param name="imageFilename">
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </param>
        /// <param name="audioUrl">
        /// The publicly accessible URL of the audio file for which you wish to creae an embedding. This parameter is required for audio embeddings if `audio_file` is not provided.
        /// </param>
        /// <param name="audioFile">
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </param>
        /// <param name="audioFilename">
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </param>
        /// <param name="audioStartOffsetSec">
        /// Specifies the start time, in seconds, from which the platform generates the audio embeddings. This parameter allows you to skip the initial portion of the audio during processing.<br/>
        /// **Default**: `0`.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest9(
            string modelName,
            string? text,
            string? imageUrl,
            byte[]? imageFile,
            string? imageFilename,
            string? audioUrl,
            byte[]? audioFile,
            string? audioFilename,
            double? audioStartOffsetSec)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.AudioUrl = audioUrl;
            this.AudioFile = audioFile;
            this.AudioFilename = audioFilename;
            this.AudioStartOffsetSec = audioStartOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest9" /> class.
        /// </summary>
        public CreateRequest9()
        {
        }
    }
}