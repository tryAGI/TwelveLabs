
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// System-generated media metadata for a video item in search results.
    /// </summary>
    public sealed partial class VideoSearchSystemMetadata
    {
        /// <summary>
        /// The duration of the video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoSearchSystemMetadata" /> class.
        /// </summary>
        /// <param name="duration">
        /// The duration of the video in seconds.
        /// </param>
        /// <param name="width">
        /// The width of the video in pixels.
        /// </param>
        /// <param name="height">
        /// The height of the video in pixels.
        /// </param>
        /// <param name="size">
        /// The file size of the video in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSearchSystemMetadata(
            double? duration,
            int? width,
            int? height,
            long? size)
        {
            this.Duration = duration;
            this.Width = width;
            this.Height = height;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchSystemMetadata" /> class.
        /// </summary>
        public VideoSearchSystemMetadata()
        {
        }

    }
}