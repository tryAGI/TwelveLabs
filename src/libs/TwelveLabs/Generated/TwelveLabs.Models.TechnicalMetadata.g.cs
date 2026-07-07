
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Technical metadata read from the media file of the asset, covering the container, the individual video and audio streams, image properties, and derived attributes.<br/>
    /// The platform populates this object asynchronously after the upload completes. It is omitted from the response while the status of the asset is `processing`, and it may be partially populated when the status is `failed`. A field is absent when it does not apply to the media type of the asset, or when the source file did not carry the corresponding information.
    /// </summary>
    public sealed partial class TechnicalMetadata
    {
        /// <summary>
        /// The size of the source media file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size_bytes")]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// The MIME type detected for the source media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_mime_type")]
        public string? FileMimeType { get; set; }

        /// <summary>
        /// The container format of the source media file. When a container maps to several format names, the platform reports them as a comma-separated list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_container_format")]
        public string? FileContainerFormat { get; set; }

        /// <summary>
        /// The creation time recorded in the media container, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_creation_time")]
        public global::System.DateTime? ContainerCreationTime { get; set; }

        /// <summary>
        /// The video streams contained in the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_streams")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? VideoStreams { get; set; }

        /// <summary>
        /// The codec of the primary video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_codec")]
        public string? VideoCodec { get; set; }

        /// <summary>
        /// The pixel width of the primary video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_width")]
        public int? VideoWidth { get; set; }

        /// <summary>
        /// The pixel height of the primary video stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_height")]
        public int? VideoHeight { get; set; }

        /// <summary>
        /// The frame rate of the primary video stream, in frames per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_fps")]
        public double? VideoFps { get; set; }

        /// <summary>
        /// The duration of the primary video stream, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_duration_seconds")]
        public double? VideoDurationSeconds { get; set; }

        /// <summary>
        /// The bit rate of the primary video stream, in bits per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_bitrate_bps")]
        public long? VideoBitrateBps { get; set; }

        /// <summary>
        /// The audio streams contained in the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_streams")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? AudioStreams { get; set; }

        /// <summary>
        /// The codec of the primary audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_codec")]
        public string? AudioCodec { get; set; }

        /// <summary>
        /// The sample rate of the primary audio stream, in hertz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample_rate")]
        public int? AudioSampleRate { get; set; }

        /// <summary>
        /// The number of channels in the primary audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channels")]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// The duration of the primary audio stream, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration_seconds")]
        public double? AudioDurationSeconds { get; set; }

        /// <summary>
        /// The starting SMPTE timecode of the media, when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timecode")]
        public string? StartTimecode { get; set; }

        /// <summary>
        /// The source from which the starting timecode was derived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timecode_source")]
        public string? TimecodeSource { get; set; }

        /// <summary>
        /// Whether the timecode uses drop-frame numbering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_frame")]
        public bool? DropFrame { get; set; }

        /// <summary>
        /// The pixel width of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_width")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// The pixel height of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_height")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// The format of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_format")]
        public string? ImageFormat { get; set; }

        /// <summary>
        /// The EXIF orientation value of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_orientation")]
        public int? ImageOrientation { get; set; }

        /// <summary>
        /// The color space of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_color_space")]
        public string? ImageColorSpace { get; set; }

        /// <summary>
        /// The bit depth per channel of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_bit_depth")]
        public int? ImageBitDepth { get; set; }

        /// <summary>
        /// Whether the media is high dynamic range (HDR).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_hdr")]
        public bool? IsHdr { get; set; }

        /// <summary>
        /// Whether the media contains at least one audio stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_audio")]
        public bool? HasAudio { get; set; }

        /// <summary>
        /// Whether the image contains an alpha (transparency) channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_alpha")]
        public bool? HasAlpha { get; set; }

        /// <summary>
        /// Whether the image is animated (for example, an animated GIF or WebP).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_animated")]
        public bool? IsAnimated { get; set; }

        /// <summary>
        /// The total number of video streams in the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_video_streams")]
        public int? TotalVideoStreams { get; set; }

        /// <summary>
        /// The total number of audio streams in the media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_audio_streams")]
        public int? TotalAudioStreams { get; set; }

        /// <summary>
        /// The storage aspect ratio of the video (pixel width divided by pixel height).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_aspect_ratio")]
        public double? StorageAspectRatio { get; set; }

        /// <summary>
        /// The GPS latitude embedded in the source media, in decimal degrees. Present only when the source media carries location metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geospatial_latitude")]
        public double? GeospatialLatitude { get; set; }

        /// <summary>
        /// The GPS longitude embedded in the source media, in decimal degrees. Present only when the source media carries location metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geospatial_longitude")]
        public double? GeospatialLongitude { get; set; }

        /// <summary>
        /// The GPS altitude embedded in the source media, in meters. Present only when the source media carries location metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geospatial_altitude_meters")]
        public double? GeospatialAltitudeMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalMetadata" /> class.
        /// </summary>
        /// <param name="fileSizeBytes">
        /// The size of the source media file in bytes.
        /// </param>
        /// <param name="fileMimeType">
        /// The MIME type detected for the source media file.
        /// </param>
        /// <param name="fileContainerFormat">
        /// The container format of the source media file. When a container maps to several format names, the platform reports them as a comma-separated list.
        /// </param>
        /// <param name="containerCreationTime">
        /// The creation time recorded in the media container, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when present.
        /// </param>
        /// <param name="videoStreams">
        /// The video streams contained in the media file.
        /// </param>
        /// <param name="videoCodec">
        /// The codec of the primary video stream.
        /// </param>
        /// <param name="videoWidth">
        /// The pixel width of the primary video stream.
        /// </param>
        /// <param name="videoHeight">
        /// The pixel height of the primary video stream.
        /// </param>
        /// <param name="videoFps">
        /// The frame rate of the primary video stream, in frames per second.
        /// </param>
        /// <param name="videoDurationSeconds">
        /// The duration of the primary video stream, in seconds.
        /// </param>
        /// <param name="videoBitrateBps">
        /// The bit rate of the primary video stream, in bits per second.
        /// </param>
        /// <param name="audioStreams">
        /// The audio streams contained in the media file.
        /// </param>
        /// <param name="audioCodec">
        /// The codec of the primary audio stream.
        /// </param>
        /// <param name="audioSampleRate">
        /// The sample rate of the primary audio stream, in hertz.
        /// </param>
        /// <param name="audioChannels">
        /// The number of channels in the primary audio stream.
        /// </param>
        /// <param name="audioDurationSeconds">
        /// The duration of the primary audio stream, in seconds.
        /// </param>
        /// <param name="startTimecode">
        /// The starting SMPTE timecode of the media, when present.
        /// </param>
        /// <param name="timecodeSource">
        /// The source from which the starting timecode was derived.
        /// </param>
        /// <param name="dropFrame">
        /// Whether the timecode uses drop-frame numbering.
        /// </param>
        /// <param name="imageWidth">
        /// The pixel width of the image.
        /// </param>
        /// <param name="imageHeight">
        /// The pixel height of the image.
        /// </param>
        /// <param name="imageFormat">
        /// The format of the image.
        /// </param>
        /// <param name="imageOrientation">
        /// The EXIF orientation value of the image.
        /// </param>
        /// <param name="imageColorSpace">
        /// The color space of the image.
        /// </param>
        /// <param name="imageBitDepth">
        /// The bit depth per channel of the image.
        /// </param>
        /// <param name="isHdr">
        /// Whether the media is high dynamic range (HDR).
        /// </param>
        /// <param name="hasAudio">
        /// Whether the media contains at least one audio stream.
        /// </param>
        /// <param name="hasAlpha">
        /// Whether the image contains an alpha (transparency) channel.
        /// </param>
        /// <param name="isAnimated">
        /// Whether the image is animated (for example, an animated GIF or WebP).
        /// </param>
        /// <param name="totalVideoStreams">
        /// The total number of video streams in the media file.
        /// </param>
        /// <param name="totalAudioStreams">
        /// The total number of audio streams in the media file.
        /// </param>
        /// <param name="storageAspectRatio">
        /// The storage aspect ratio of the video (pixel width divided by pixel height).
        /// </param>
        /// <param name="geospatialLatitude">
        /// The GPS latitude embedded in the source media, in decimal degrees. Present only when the source media carries location metadata.
        /// </param>
        /// <param name="geospatialLongitude">
        /// The GPS longitude embedded in the source media, in decimal degrees. Present only when the source media carries location metadata.
        /// </param>
        /// <param name="geospatialAltitudeMeters">
        /// The GPS altitude embedded in the source media, in meters. Present only when the source media carries location metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TechnicalMetadata(
            long? fileSizeBytes,
            string? fileMimeType,
            string? fileContainerFormat,
            global::System.DateTime? containerCreationTime,
            global::System.Collections.Generic.IList<global::TwelveLabs.VideoStream>? videoStreams,
            string? videoCodec,
            int? videoWidth,
            int? videoHeight,
            double? videoFps,
            double? videoDurationSeconds,
            long? videoBitrateBps,
            global::System.Collections.Generic.IList<global::TwelveLabs.AudioStream>? audioStreams,
            string? audioCodec,
            int? audioSampleRate,
            int? audioChannels,
            double? audioDurationSeconds,
            string? startTimecode,
            string? timecodeSource,
            bool? dropFrame,
            int? imageWidth,
            int? imageHeight,
            string? imageFormat,
            int? imageOrientation,
            string? imageColorSpace,
            int? imageBitDepth,
            bool? isHdr,
            bool? hasAudio,
            bool? hasAlpha,
            bool? isAnimated,
            int? totalVideoStreams,
            int? totalAudioStreams,
            double? storageAspectRatio,
            double? geospatialLatitude,
            double? geospatialLongitude,
            double? geospatialAltitudeMeters)
        {
            this.FileSizeBytes = fileSizeBytes;
            this.FileMimeType = fileMimeType;
            this.FileContainerFormat = fileContainerFormat;
            this.ContainerCreationTime = containerCreationTime;
            this.VideoStreams = videoStreams;
            this.VideoCodec = videoCodec;
            this.VideoWidth = videoWidth;
            this.VideoHeight = videoHeight;
            this.VideoFps = videoFps;
            this.VideoDurationSeconds = videoDurationSeconds;
            this.VideoBitrateBps = videoBitrateBps;
            this.AudioStreams = audioStreams;
            this.AudioCodec = audioCodec;
            this.AudioSampleRate = audioSampleRate;
            this.AudioChannels = audioChannels;
            this.AudioDurationSeconds = audioDurationSeconds;
            this.StartTimecode = startTimecode;
            this.TimecodeSource = timecodeSource;
            this.DropFrame = dropFrame;
            this.ImageWidth = imageWidth;
            this.ImageHeight = imageHeight;
            this.ImageFormat = imageFormat;
            this.ImageOrientation = imageOrientation;
            this.ImageColorSpace = imageColorSpace;
            this.ImageBitDepth = imageBitDepth;
            this.IsHdr = isHdr;
            this.HasAudio = hasAudio;
            this.HasAlpha = hasAlpha;
            this.IsAnimated = isAnimated;
            this.TotalVideoStreams = totalVideoStreams;
            this.TotalAudioStreams = totalAudioStreams;
            this.StorageAspectRatio = storageAspectRatio;
            this.GeospatialLatitude = geospatialLatitude;
            this.GeospatialLongitude = geospatialLongitude;
            this.GeospatialAltitudeMeters = geospatialAltitudeMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicalMetadata" /> class.
        /// </summary>
        public TechnicalMetadata()
        {
        }

    }
}