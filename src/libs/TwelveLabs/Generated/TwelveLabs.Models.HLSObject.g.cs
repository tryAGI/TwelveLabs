
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The platform returns this object only for the videos that you uploaded with the `enable_video_stream` parameter set to `true`.
    /// </summary>
    public sealed partial class HLSObject
    {
        /// <summary>
        /// A string representing the URL of the video. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol. The URL can expire. A signed URL is valid for 1 hour. Playback that has started continues after the URL expires. A request for the manifest or the encryption key after the URL expires returns a `403` error. Call the method that returned the URL again for a new URL instead of storing it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// An array of thumbnail URLs. The signed URLs are valid for at least 1 hour and up to 2 hours. A request for a thumbnail after its URL expires returns a `403` error. Call the method that returned the URLs again for new URLs instead of storing them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_urls")]
        public global::System.Collections.Generic.IList<string>? ThumbnailUrls { get; set; }

        /// <summary>
        /// A string representing the encoding status of the video file from its original format to a streamable format.<br/>
        /// **Values**:<br/>
        /// - `PROCESSING`: Video is currently being encoded and is not yet ready for streaming<br/>
        /// - `COMPLETE`: Encoding has successfully finished and the video is ready for streaming<br/>
        /// - `CANCELED`: Encoding was manually canceled before completion<br/>
        /// - `ERROR`: An error occurred during the encoding process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.HlsObjectStatusJsonConverter))]
        public global::TwelveLabs.HlsObjectStatus? Status { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the encoding status was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HLSObject" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// A string representing the URL of the video. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol. The URL can expire. A signed URL is valid for 1 hour. Playback that has started continues after the URL expires. A request for the manifest or the encryption key after the URL expires returns a `403` error. Call the method that returned the URL again for a new URL instead of storing it.
        /// </param>
        /// <param name="thumbnailUrls">
        /// An array of thumbnail URLs. The signed URLs are valid for at least 1 hour and up to 2 hours. A request for a thumbnail after its URL expires returns a `403` error. Call the method that returned the URLs again for new URLs instead of storing them.
        /// </param>
        /// <param name="status">
        /// A string representing the encoding status of the video file from its original format to a streamable format.<br/>
        /// **Values**:<br/>
        /// - `PROCESSING`: Video is currently being encoded and is not yet ready for streaming<br/>
        /// - `COMPLETE`: Encoding has successfully finished and the video is ready for streaming<br/>
        /// - `CANCELED`: Encoding was manually canceled before completion<br/>
        /// - `ERROR`: An error occurred during the encoding process
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the encoding status was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HLSObject(
            string? videoUrl,
            global::System.Collections.Generic.IList<string>? thumbnailUrls,
            global::TwelveLabs.HlsObjectStatus? status,
            string? updatedAt)
        {
            this.VideoUrl = videoUrl;
            this.ThumbnailUrls = thumbnailUrls;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HLSObject" /> class.
        /// </summary>
        public HLSObject()
        {
        }

    }
}