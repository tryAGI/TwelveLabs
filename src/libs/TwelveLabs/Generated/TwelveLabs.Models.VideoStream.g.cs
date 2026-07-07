
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The technical properties of a single video stream within the media file.
    /// </summary>
    public sealed partial class VideoStream
    {
        /// <summary>
        /// The zero-based index of the stream within the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The codec of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec")]
        public string? Codec { get; set; }

        /// <summary>
        /// The pixel width of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The pixel height of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The nominal frame rate of the video stream, in frames per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// The average frame rate of the video stream, in frames per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_fps")]
        public double? AvgFps { get; set; }

        /// <summary>
        /// The duration of the video stream, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// The bit rate of the video stream, in bits per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate_bps")]
        public long? BitrateBps { get; set; }

        /// <summary>
        /// The rotation applied to the video stream, in degrees.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotation")]
        public int? Rotation { get; set; }

        /// <summary>
        /// The pixel (sample) aspect ratio of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pixel_aspect_ratio")]
        public string? PixelAspectRatio { get; set; }

        /// <summary>
        /// The display aspect ratio of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_aspect_ratio")]
        public string? DisplayAspectRatio { get; set; }

        /// <summary>
        /// The scan type of the video stream (for example, progressive or interlaced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_type")]
        public string? ScanType { get; set; }

        /// <summary>
        /// The pixel format of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pixel_format")]
        public string? PixelFormat { get; set; }

        /// <summary>
        /// The bit depth per color component of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_depth")]
        public int? BitDepth { get; set; }

        /// <summary>
        /// The color range of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_range")]
        public string? ColorRange { get; set; }

        /// <summary>
        /// The color transfer characteristics of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_transfer")]
        public string? ColorTransfer { get; set; }

        /// <summary>
        /// The color space of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_space")]
        public string? ColorSpace { get; set; }

        /// <summary>
        /// The color primaries of the video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_primaries")]
        public string? ColorPrimaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStream" /> class.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the stream within the media file.
        /// </param>
        /// <param name="codec">
        /// The codec of the video stream.
        /// </param>
        /// <param name="width">
        /// The pixel width of the video stream.
        /// </param>
        /// <param name="height">
        /// The pixel height of the video stream.
        /// </param>
        /// <param name="fps">
        /// The nominal frame rate of the video stream, in frames per second.
        /// </param>
        /// <param name="avgFps">
        /// The average frame rate of the video stream, in frames per second.
        /// </param>
        /// <param name="durationSeconds">
        /// The duration of the video stream, in seconds.
        /// </param>
        /// <param name="bitrateBps">
        /// The bit rate of the video stream, in bits per second.
        /// </param>
        /// <param name="rotation">
        /// The rotation applied to the video stream, in degrees.
        /// </param>
        /// <param name="pixelAspectRatio">
        /// The pixel (sample) aspect ratio of the video stream.
        /// </param>
        /// <param name="displayAspectRatio">
        /// The display aspect ratio of the video stream.
        /// </param>
        /// <param name="scanType">
        /// The scan type of the video stream (for example, progressive or interlaced).
        /// </param>
        /// <param name="pixelFormat">
        /// The pixel format of the video stream.
        /// </param>
        /// <param name="bitDepth">
        /// The bit depth per color component of the video stream.
        /// </param>
        /// <param name="colorRange">
        /// The color range of the video stream.
        /// </param>
        /// <param name="colorTransfer">
        /// The color transfer characteristics of the video stream.
        /// </param>
        /// <param name="colorSpace">
        /// The color space of the video stream.
        /// </param>
        /// <param name="colorPrimaries">
        /// The color primaries of the video stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoStream(
            int? index,
            string? codec,
            int? width,
            int? height,
            double? fps,
            double? avgFps,
            double? durationSeconds,
            long? bitrateBps,
            int? rotation,
            string? pixelAspectRatio,
            string? displayAspectRatio,
            string? scanType,
            string? pixelFormat,
            int? bitDepth,
            string? colorRange,
            string? colorTransfer,
            string? colorSpace,
            string? colorPrimaries)
        {
            this.Index = index;
            this.Codec = codec;
            this.Width = width;
            this.Height = height;
            this.Fps = fps;
            this.AvgFps = avgFps;
            this.DurationSeconds = durationSeconds;
            this.BitrateBps = bitrateBps;
            this.Rotation = rotation;
            this.PixelAspectRatio = pixelAspectRatio;
            this.DisplayAspectRatio = displayAspectRatio;
            this.ScanType = scanType;
            this.PixelFormat = pixelFormat;
            this.BitDepth = bitDepth;
            this.ColorRange = colorRange;
            this.ColorTransfer = colorTransfer;
            this.ColorSpace = colorSpace;
            this.ColorPrimaries = colorPrimaries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoStream" /> class.
        /// </summary>
        public VideoStream()
        {
        }

    }
}