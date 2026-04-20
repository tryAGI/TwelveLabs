
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A reference image that provides visual context for segment identification. Provide exactly one of `url`, `asset_id`, or `base64_string`.
    /// </summary>
    public sealed partial class SMEMediaSource
    {
        /// <summary>
        /// A descriptive name for this media source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The media type. Only `image` is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SmeMediaSourceMediaTypeJsonConverter))]
        public global::TwelveLabs.SmeMediaSourceMediaType MediaType { get; set; }

        /// <summary>
        /// A publicly accessible HTTPS URL of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The unique identifier of an uploaded asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Base64-encoded image data. The maximum size is 30MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        public string? Base64String { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMEMediaSource" /> class.
        /// </summary>
        /// <param name="name">
        /// A descriptive name for this media source.
        /// </param>
        /// <param name="mediaType">
        /// The media type. Only `image` is available.
        /// </param>
        /// <param name="url">
        /// A publicly accessible HTTPS URL of the image.
        /// </param>
        /// <param name="assetId">
        /// The unique identifier of an uploaded asset.
        /// </param>
        /// <param name="base64String">
        /// Base64-encoded image data. The maximum size is 30MB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMEMediaSource(
            string name,
            global::TwelveLabs.SmeMediaSourceMediaType mediaType,
            string? url,
            string? assetId,
            string? base64String)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MediaType = mediaType;
            this.Url = url;
            this.AssetId = assetId;
            this.Base64String = base64String;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMEMediaSource" /> class.
        /// </summary>
        public SMEMediaSource()
        {
        }
    }
}