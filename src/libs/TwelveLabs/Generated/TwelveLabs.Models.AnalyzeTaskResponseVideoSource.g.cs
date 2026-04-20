
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The video source you provided. Only present for tasks that use direct video input (`url`, `base64_string`, or `asset_id`).
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
        /// The video ID. Present when `type` is `video_id`. Deprecated — use `asset_id` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// System-extracted video metadata. Present on a best-effort basis once the video has been processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>? SystemMetadata { get; set; }

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
        /// <param name="videoId">
        /// The video ID. Present when `type` is `video_id`. Deprecated — use `asset_id` instead.
        /// </param>
        /// <param name="systemMetadata">
        /// System-extracted video metadata. Present on a best-effort basis once the video has been processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseVideoSource(
            global::TwelveLabs.AnalyzeTaskResponseVideoSourceType? type,
            string? url,
            string? assetId,
            string? videoId,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSourceSystemMetadata, object>? systemMetadata)
        {
            this.Type = type;
            this.Url = url;
            this.AssetId = assetId;
            this.VideoId = videoId;
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