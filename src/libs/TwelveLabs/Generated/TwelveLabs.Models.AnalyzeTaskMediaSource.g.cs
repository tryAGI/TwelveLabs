
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An image from the request, returned in the response. It can be a reference in the prompt or the analysis subject. For an image submitted through the `base64_string` field, the platform returns only `name` and `media_type`.
    /// </summary>
    public sealed partial class AnalyzeTaskMediaSource
    {
        /// <summary>
        /// The reference name you supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The media type. The value is always `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// Present when the source was provided as a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Present when the source was provided as an asset identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskMediaSource" /> class.
        /// </summary>
        /// <param name="name">
        /// The reference name you supplied.
        /// </param>
        /// <param name="mediaType">
        /// The media type. The value is always `image`.
        /// </param>
        /// <param name="url">
        /// Present when the source was provided as a URL.
        /// </param>
        /// <param name="assetId">
        /// Present when the source was provided as an asset identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskMediaSource(
            string name,
            string mediaType,
            string? url,
            string? assetId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Url = url;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskMediaSource" /> class.
        /// </summary>
        public AnalyzeTaskMediaSource()
        {
        }

    }
}