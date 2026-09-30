
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbedV2TasksCreateResponse202
    {
        /// <summary>
        /// The unique identifier of the embedding task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The initial status of the embedding task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter))]
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus Status { get; set; }

        /// <summary>
        /// An array of embedding results when `status` is `ready`, or `null` when `status` is `processing` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? Data { get; set; }

        /// <summary>
        /// Metadata about the task you created. The platform sets the length of your embeddings when it creates the task, and the `embedding_dimension` field contains that length. Only Marengo 3.5 returns it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksCreateResponse202" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the embedding task
        /// </param>
        /// <param name="status">
        /// The initial status of the embedding task.
        /// </param>
        /// <param name="data">
        /// An array of embedding results when `status` is `ready`, or `null` when `status` is `processing` or `failed`.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the task you created. The platform sets the length of your embeddings when it creates the task, and the `embedding_dimension` field contains that length. Only Marengo 3.5 returns it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedV2TasksCreateResponse202(
            string id,
            global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatus status,
            global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingData>? data,
            global::TwelveLabs.EmbedV2TasksPostResponsesContentApplicationJsonSchemaMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Data = data;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksCreateResponse202" /> class.
        /// </summary>
        public EmbedV2TasksCreateResponse202()
        {
        }

    }
}