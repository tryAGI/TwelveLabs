
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The public video source associated with the task. When the video was uploaded using the [`POST`](/v1.3/api-reference/index-content/create) method of the `/tasks` endpoint, the source type is `video_id`. Otherwise, the source type is `url`, `base64_string`, or `asset_id`.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseVideoSource
    {
        /// <summary>
        /// The type of video source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseVideoSourceTypeJsonConverter))]
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? Type { get; set; }

        /// <summary>
        /// The video URL. Present when `type` is `url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The asset ID. Present when `type` is `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// The video identifier. Present when `type` is `video_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? VideoId { get; set; }

        /// <summary>
        /// The identifier of the index associated with the video. Present on a best-effort basis when `type` is `video_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? IndexId { get; set; }

        /// <summary>
        /// Video metadata that the platform extracted during processing, such as its duration. Present on a best-effort basis once the video has been processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseVideoSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of video source.
        /// </param>
        /// <param name="url">
        /// The video URL. Present when `type` is `url`.
        /// </param>
        /// <param name="assetId">
        /// The asset ID. Present when `type` is `asset_id`.
        /// </param>
        /// <param name="systemMetadata">
        /// Video metadata that the platform extracted during processing, such as its duration. Present on a best-effort basis once the video has been processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseVideoSource(
            global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? type,
            string? url,
            string? assetId,
            global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata? systemMetadata)
        {
            this.Type = type;
            this.Url = url;
            this.AssetId = assetId;
            this.SystemMetadata = systemMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseVideoSource" /> class.
        /// </summary>
        public AnalyzeTaskResponseVideoSource()
        {
        }

    }
}