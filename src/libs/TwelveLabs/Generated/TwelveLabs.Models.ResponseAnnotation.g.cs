
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Ties a span of the message text to what it cites.<br/>
    /// One object covers all citation kinds. Read the `type` field to tell them apart.<br/>
    /// The fields fall into two groups that behave differently:<br/>
    /// `title`, `thumbnail_url` and `hls_url` are always present and nullable: `null`<br/>
    /// reports a value the platform could not resolve, or one that does not apply to this<br/>
    /// citation kind (an image has no video to play).<br/>
    /// `item_id`, `collection_id`, `start_sec` and `end_sec` are absent when they do<br/>
    /// not apply, never null. `start_sec` and `end_sec` are absent together, never one<br/>
    /// alone: absent on a `video_citation` means the citation covers the whole video.
    /// </summary>
    public sealed partial class ResponseAnnotation
    {
        /// <summary>
        /// What this citation refers to:<br/>
        /// - `video_citation`: a time range within a video item.<br/>
        /// - `image_citation`: a whole image item.<br/>
        /// - `collection_citation`: an item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseAnnotationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseAnnotationType Type { get; set; }

        /// <summary>
        /// Start of the marker, as a zero-based offset into the `text` field,<br/>
        /// counted in Unicode code points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// End of the marker, inclusive, in the same units as the `start_index` field.<br/>
        /// Most languages slice up to but not including the end. To read the marker<br/>
        /// in Go, Python, or JavaScript, use `text[start_index : end_index + 1]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// The cited item. Present when `type` is `video_citation` or `image_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The cited collection. Present when `type` is `collection_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public string? CollectionId { get; set; }

        /// <summary>
        /// Start of the cited range within the video, in seconds. Present when `type`<br/>
        /// is `video_citation` and the citation specifies a range.<br/>
        /// Absent (not null) together with the `end_sec` field when the citation<br/>
        /// covers the whole video, and on every other citation kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// End of the cited range within the video, in seconds. Present whenever the<br/>
        /// `start_sec` field is present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// Display title of the cited item or collection. Always present; `null` when it could not be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A signed URL for a preview image. Always present. It is `null` when the image<br/>
        /// could not be resolved, and on a `collection_citation`, which has no preview.<br/>
        /// What it shows depends on the value of the `type` field:<br/>
        /// - `video_citation`: a still image from the video.<br/>
        /// - `image_citation`: a smaller version of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// A signed URL for video playback, in HLS format (`.m3u8`). Always present. It is<br/>
        /// `null` when the video could not be resolved, and on every kind except<br/>
        /// `video_citation`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls_url")]
        public string? HlsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAnnotation" /> class.
        /// </summary>
        /// <param name="type">
        /// What this citation refers to:<br/>
        /// - `video_citation`: a time range within a video item.<br/>
        /// - `image_citation`: a whole image item.<br/>
        /// - `collection_citation`: an item collection.
        /// </param>
        /// <param name="startIndex">
        /// Start of the marker, as a zero-based offset into the `text` field,<br/>
        /// counted in Unicode code points.
        /// </param>
        /// <param name="endIndex">
        /// End of the marker, inclusive, in the same units as the `start_index` field.<br/>
        /// Most languages slice up to but not including the end. To read the marker<br/>
        /// in Go, Python, or JavaScript, use `text[start_index : end_index + 1]`.
        /// </param>
        /// <param name="itemId">
        /// The cited item. Present when `type` is `video_citation` or `image_citation`.
        /// </param>
        /// <param name="collectionId">
        /// The cited collection. Present when `type` is `collection_citation`.
        /// </param>
        /// <param name="startSec">
        /// Start of the cited range within the video, in seconds. Present when `type`<br/>
        /// is `video_citation` and the citation specifies a range.<br/>
        /// Absent (not null) together with the `end_sec` field when the citation<br/>
        /// covers the whole video, and on every other citation kind.
        /// </param>
        /// <param name="endSec">
        /// End of the cited range within the video, in seconds. Present whenever the<br/>
        /// `start_sec` field is present.
        /// </param>
        /// <param name="title">
        /// Display title of the cited item or collection. Always present; `null` when it could not be resolved.
        /// </param>
        /// <param name="thumbnailUrl">
        /// A signed URL for a preview image. Always present. It is `null` when the image<br/>
        /// could not be resolved, and on a `collection_citation`, which has no preview.<br/>
        /// What it shows depends on the value of the `type` field:<br/>
        /// - `video_citation`: a still image from the video.<br/>
        /// - `image_citation`: a smaller version of the image.
        /// </param>
        /// <param name="hlsUrl">
        /// A signed URL for video playback, in HLS format (`.m3u8`). Always present. It is<br/>
        /// `null` when the video could not be resolved, and on every kind except<br/>
        /// `video_citation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAnnotation(
            global::TwelveLabs.ResponseAnnotationType type,
            int startIndex,
            int endIndex,
            string? itemId,
            string? collectionId,
            double? startSec,
            double? endSec,
            string? title,
            string? thumbnailUrl,
            string? hlsUrl)
        {
            this.Type = type;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.ItemId = itemId;
            this.CollectionId = collectionId;
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.Title = title;
            this.ThumbnailUrl = thumbnailUrl;
            this.HlsUrl = hlsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAnnotation" /> class.
        /// </summary>
        public ResponseAnnotation()
        {
        }

    }
}