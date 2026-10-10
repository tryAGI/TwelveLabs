
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Ties a span of the message text to what it cites.<br/>
    /// One object covers all citation kinds. Read the `type` field to tell them apart.<br/>
    /// `title`, `thumbnail_url` and `hls_url` are omitted when the platform cannot<br/>
    /// resolve a value or the field does not apply to the citation kind. When present,<br/>
    /// these fields contain strings, including an empty string if that is the resolved value.<br/>
    /// `url`, `item_id`, `collection_id`, `start_sec` and `end_sec` are absent when<br/>
    /// they do not apply, never null. `start_sec` and `end_sec` are absent together,<br/>
    /// never one alone: absent on a `video_citation` means the citation covers the<br/>
    /// whole video.<br/>
    /// A `url_citation` includes `url` and a string `title`. Its `thumbnail_url` and<br/>
    /// `hls_url` are absent. Web sources are not knowledge store items and have no<br/>
    /// `item_id`, `collection_id`, `start_sec`, or `end_sec`.
    /// </summary>
    public sealed partial class ResponseAnnotation
    {
        /// <summary>
        /// What this citation refers to:<br/>
        /// - `video_citation`: a time range within a video item.<br/>
        /// - `image_citation`: a whole image item.<br/>
        /// - `collection_citation`: an item collection.<br/>
        /// - `url_citation`: a web source.<br/>
        /// Treat an unrecognized type as a citation you cannot display. Preserve<br/>
        /// the response text and other annotations instead of rejecting the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Start of the cited span, inclusive, as a zero-based offset into the<br/>
        /// containing content part's `text` field, counted in Unicode code points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// End of the cited span, inclusive, in the same units as `start_index`.<br/>
        /// This convention applies to every citation type, including `url_citation`.<br/>
        /// To extract the span, use `text[start_index:end_index + 1]` in Python,<br/>
        /// `string([]rune(text)[start_index:end_index + 1])` in Go, or<br/>
        /// `Array.from(text).slice(start_index, end_index + 1).join("")` in JavaScript.<br/>
        /// Go string offsets count bytes and JavaScript string offsets count UTF-16<br/>
        /// code units, so convert to Unicode code points before slicing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EndIndex { get; set; }

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
        /// Display title of the cited item, collection, or web source. Present for<br/>
        /// `url_citation`; omitted when an item or collection title cannot be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The source URL. Present when `type` is `url_citation`; absent on media and collection citations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// A signed URL for a preview image. Omitted when the image cannot be<br/>
        /// resolved, and on `collection_citation` and `url_citation`,<br/>
        /// which have no preview.<br/>
        /// What it shows depends on the value of the `type` field:<br/>
        /// - `video_citation`: a still image from the video.<br/>
        /// - `image_citation`: a smaller version of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// A signed URL for video playback, in HLS format (`.m3u8`). Omitted when<br/>
        /// the video cannot be resolved, and on every kind except<br/>
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
        /// - `collection_citation`: an item collection.<br/>
        /// - `url_citation`: a web source.<br/>
        /// Treat an unrecognized type as a citation you cannot display. Preserve<br/>
        /// the response text and other annotations instead of rejecting the response.
        /// </param>
        /// <param name="startIndex">
        /// Start of the cited span, inclusive, as a zero-based offset into the<br/>
        /// containing content part's `text` field, counted in Unicode code points.
        /// </param>
        /// <param name="endIndex">
        /// End of the cited span, inclusive, in the same units as `start_index`.<br/>
        /// This convention applies to every citation type, including `url_citation`.<br/>
        /// To extract the span, use `text[start_index:end_index + 1]` in Python,<br/>
        /// `string([]rune(text)[start_index:end_index + 1])` in Go, or<br/>
        /// `Array.from(text).slice(start_index, end_index + 1).join("")` in JavaScript.<br/>
        /// Go string offsets count bytes and JavaScript string offsets count UTF-16<br/>
        /// code units, so convert to Unicode code points before slicing.
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
        /// Display title of the cited item, collection, or web source. Present for<br/>
        /// `url_citation`; omitted when an item or collection title cannot be resolved.
        /// </param>
        /// <param name="url">
        /// The source URL. Present when `type` is `url_citation`; absent on media and collection citations.
        /// </param>
        /// <param name="thumbnailUrl">
        /// A signed URL for a preview image. Omitted when the image cannot be<br/>
        /// resolved, and on `collection_citation` and `url_citation`,<br/>
        /// which have no preview.<br/>
        /// What it shows depends on the value of the `type` field:<br/>
        /// - `video_citation`: a still image from the video.<br/>
        /// - `image_citation`: a smaller version of the image.
        /// </param>
        /// <param name="hlsUrl">
        /// A signed URL for video playback, in HLS format (`.m3u8`). Omitted when<br/>
        /// the video cannot be resolved, and on every kind except<br/>
        /// `video_citation`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAnnotation(
            string type,
            int startIndex,
            long endIndex,
            string? itemId,
            string? collectionId,
            double? startSec,
            double? endSec,
            string? title,
            string? url,
            string? thumbnailUrl,
            string? hlsUrl)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.ItemId = itemId;
            this.CollectionId = collectionId;
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.Title = title;
            this.Url = url;
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