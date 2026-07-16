
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// System-generated media metadata for a video item.
    /// </summary>
    public sealed partial class KnowledgeStoreItemSystemMetadataVariant1
    {
        /// <summary>
        /// This field is always set to `video` for video items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoMetadataAssetTypeJsonConverter))]
        public global::TwelveLabs.VideoMetadataAssetType AssetType { get; set; }

        /// <summary>
        /// The original filename of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The duration of the video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The frame rate of the video in frames per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// The width of the video in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the video in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The codec used to encode the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec_name")]
        public string? CodecName { get; set; }

        /// <summary>
        /// The file size of the video in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemSystemMetadataVariant1" /> class.
        /// </summary>
        /// <param name="assetType">
        /// This field is always set to `video` for video items.
        /// </param>
        /// <param name="filename">
        /// The original filename of the video.
        /// </param>
        /// <param name="duration">
        /// The duration of the video in seconds.
        /// </param>
        /// <param name="fps">
        /// The frame rate of the video in frames per second.
        /// </param>
        /// <param name="width">
        /// The width of the video in pixels.
        /// </param>
        /// <param name="height">
        /// The height of the video in pixels.
        /// </param>
        /// <param name="codecName">
        /// The codec used to encode the video.
        /// </param>
        /// <param name="size">
        /// The file size of the video in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItemSystemMetadataVariant1(
            global::TwelveLabs.VideoMetadataAssetType assetType,
            string? filename,
            double? duration,
            double? fps,
            int? width,
            int? height,
            string? codecName,
            long? size)
        {
            this.AssetType = assetType;
            this.Filename = filename;
            this.Duration = duration;
            this.Fps = fps;
            this.Width = width;
            this.Height = height;
            this.CodecName = codecName;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemSystemMetadataVariant1" /> class.
        /// </summary>
        public KnowledgeStoreItemSystemMetadataVariant1()
        {
        }

    }
}