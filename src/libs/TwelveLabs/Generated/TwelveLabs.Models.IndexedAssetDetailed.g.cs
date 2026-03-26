
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexedAssetDetailed
    {
        /// <summary>
        /// A string representing the unique identifier of your indexed asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was last updated. The platform updates this field every time the indexing task transitions to a different state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task has been completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed_at")]
        public string? IndexedAt { get; set; }

        /// <summary>
        /// The status of the indexing task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.IndexedAssetStatusJsonConverter))]
        public global::TwelveLabs.IndexedAssetStatus? Status { get; set; }

        /// <summary>
        /// System-generated metadata about the indexed asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public global::TwelveLabs.IndexedAssetSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// User-generated metadata about the indexed asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public object? UserMetadata { get; set; }

        /// <summary>
        /// The platform returns this object only for the videos that you uploaded with the `enable_video_stream` parameter set to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls")]
        public global::TwelveLabs.HLSObject? Hls { get; set; }

        /// <summary>
        /// Contains the embedding and the associated information. The platform returns this field when the `embedding_option` parameter is specified in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::TwelveLabs.IndexedAssetDetailedEmbedding? Embedding { get; set; }

        /// <summary>
        /// An array of objects that contains the transcription. For each time range for which the platform finds spoken words, it returns an object that contains the fields below. If the platform doesn't find any spoken words, the `data` field is set to `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? Transcription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetDetailed" /> class.
        /// </summary>
        /// <param name="id">
        /// A string representing the unique identifier of your indexed asset.
        /// </param>
        /// <param name="createdAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task was last updated. The platform updates this field every time the indexing task transitions to a different state.
        /// </param>
        /// <param name="indexedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the indexing task has been completed.
        /// </param>
        /// <param name="status">
        /// The status of the indexing task.
        /// </param>
        /// <param name="systemMetadata">
        /// System-generated metadata about the indexed asset.
        /// </param>
        /// <param name="userMetadata">
        /// User-generated metadata about the indexed asset.
        /// </param>
        /// <param name="hls">
        /// The platform returns this object only for the videos that you uploaded with the `enable_video_stream` parameter set to `true`.
        /// </param>
        /// <param name="embedding">
        /// Contains the embedding and the associated information. The platform returns this field when the `embedding_option` parameter is specified in the request.
        /// </param>
        /// <param name="transcription">
        /// An array of objects that contains the transcription. For each time range for which the platform finds spoken words, it returns an object that contains the fields below. If the platform doesn't find any spoken words, the `data` field is set to `null`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexedAssetDetailed(
            string? id,
            string? createdAt,
            string? updatedAt,
            string? indexedAt,
            global::TwelveLabs.IndexedAssetStatus? status,
            global::TwelveLabs.IndexedAssetSystemMetadata? systemMetadata,
            object? userMetadata,
            global::TwelveLabs.HLSObject? hls,
            global::TwelveLabs.IndexedAssetDetailedEmbedding? embedding,
            global::System.Collections.Generic.IList<global::TwelveLabs.TranscriptionDataItems>? transcription)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IndexedAt = indexedAt;
            this.Status = status;
            this.SystemMetadata = systemMetadata;
            this.UserMetadata = userMetadata;
            this.Hls = hls;
            this.Embedding = embedding;
            this.Transcription = transcription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedAssetDetailed" /> class.
        /// </summary>
        public IndexedAssetDetailed()
        {
        }
    }
}