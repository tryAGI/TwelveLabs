
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object specifying a media source for multi-input embeddings. You must provide exactly one of `url`, `base64_string`, or `asset_id`.<br/>
    /// With Marengo 3.5, each media source can be up to 32 MB, whichever of the three fields you use. Audio and video can be up to 30 seconds. Content above either limit returns a `400` error.
    /// </summary>
    public sealed partial class MultiInputMediaSource
    {
        /// <summary>
        /// The unique identifier for this media source.<br/>
        /// This field is required when `input_text` references this media source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of media.<br/>
        /// **Values**:<br/>
        /// - `image`: An image file. Works with both Marengo 3.0 and Marengo 3.5.<br/>
        /// - `video`: A video file. Requires Marengo 3.5.<br/>
        /// - `audio`: An audio file. Requires Marengo 3.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.MultiInputMediaSourceMediaType MediaType { get; set; }

        /// <summary>
        /// The publicly accessible URL of the media file. Use direct links to raw files. Media hosting platforms and cloud storage sharing links are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The base64-encoded media data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        public string? Base64String { get; set; }

        /// <summary>
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputMediaSource" /> class.
        /// </summary>
        /// <param name="mediaType">
        /// The type of media.<br/>
        /// **Values**:<br/>
        /// - `image`: An image file. Works with both Marengo 3.0 and Marengo 3.5.<br/>
        /// - `video`: A video file. Requires Marengo 3.5.<br/>
        /// - `audio`: An audio file. Requires Marengo 3.5.
        /// </param>
        /// <param name="name">
        /// The unique identifier for this media source.<br/>
        /// This field is required when `input_text` references this media source.
        /// </param>
        /// <param name="url">
        /// The publicly accessible URL of the media file. Use direct links to raw files. Media hosting platforms and cloud storage sharing links are not supported.
        /// </param>
        /// <param name="base64String">
        /// The base64-encoded media data.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of an asset from a [direct](/v1.3/api-reference/upload-content) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) upload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiInputMediaSource(
            global::TwelveLabs.MultiInputMediaSourceMediaType mediaType,
            string? name,
            string? url,
            string? base64String,
            string? assetId)
        {
            this.Name = name;
            this.MediaType = mediaType;
            this.Url = url;
            this.Base64String = base64String;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiInputMediaSource" /> class.
        /// </summary>
        public MultiInputMediaSource()
        {
        }

    }
}