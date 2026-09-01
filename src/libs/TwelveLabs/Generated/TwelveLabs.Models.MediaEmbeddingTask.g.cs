
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An embedding task that describes the status of the task and the metadata about the media.
    /// </summary>
    public sealed partial class MediaEmbeddingTask
    {
        /// <summary>
        /// The unique identifier of the embedding task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the video understanding model the platform used to create the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// A string indicating the status of the embedding task. It can take one of the following values: `processing`, `ready` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// An object containing the metadata associated with the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_embedding")]
        public global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? VideoEmbedding { get; set; }

        /// <summary>
        /// An object containing the metadata associated with the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_embedding")]
        public global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? AudioEmbedding { get; set; }

        /// <summary>
        /// An object containing the metadata associated with the embedding. Present only for `document` tasks created with Marengo 3.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_embedding")]
        public global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? DocumentEmbedding { get; set; }

        /// <summary>
        /// An object containing the metadata associated with the embedding. Present only for `image` tasks created with Marengo 3.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_embedding")]
        public global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? ImageEmbedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEmbeddingTask" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the embedding task.
        /// </param>
        /// <param name="modelName">
        /// The name of the video understanding model the platform used to create the embedding.
        /// </param>
        /// <param name="status">
        /// A string indicating the status of the embedding task. It can take one of the following values: `processing`, `ready` or `failed`.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the resource was last updated.
        /// </param>
        /// <param name="videoEmbedding">
        /// An object containing the metadata associated with the embedding.
        /// </param>
        /// <param name="audioEmbedding">
        /// An object containing the metadata associated with the embedding.
        /// </param>
        /// <param name="documentEmbedding">
        /// An object containing the metadata associated with the embedding. Present only for `document` tasks created with Marengo 3.5.
        /// </param>
        /// <param name="imageEmbedding">
        /// An object containing the metadata associated with the embedding. Present only for `image` tasks created with Marengo 3.5.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaEmbeddingTask(
            string? id,
            string? modelName,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::TwelveLabs.MediaEmbeddingTaskVideoEmbedding? videoEmbedding,
            global::TwelveLabs.MediaEmbeddingTaskAudioEmbedding? audioEmbedding,
            global::TwelveLabs.MediaEmbeddingTaskDocumentEmbedding? documentEmbedding,
            global::TwelveLabs.MediaEmbeddingTaskImageEmbedding? imageEmbedding)
        {
            this.Id = id;
            this.ModelName = modelName;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.VideoEmbedding = videoEmbedding;
            this.AudioEmbedding = audioEmbedding;
            this.DocumentEmbedding = documentEmbedding;
            this.ImageEmbedding = imageEmbedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEmbeddingTask" /> class.
        /// </summary>
        public MediaEmbeddingTask()
        {
        }

    }
}