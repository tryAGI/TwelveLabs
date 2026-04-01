
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Provide the video via a URL.
    /// </summary>
    public sealed partial class VideoContext0
    {
        /// <summary>
        /// Set this field to `url` to indicate that you're providing the video via a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf0TypeJsonConverter))]
        public global::TwelveLabs.VideoContextOneOf0Type Type { get; set; }

        /// <summary>
        /// The publicly accessible URL of the video file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext0" /> class.
        /// </summary>
        /// <param name="url">
        /// The publicly accessible URL of the video file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </param>
        /// <param name="type">
        /// Set this field to `url` to indicate that you're providing the video via a URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoContext0(
            string url,
            global::TwelveLabs.VideoContextOneOf0Type type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext0" /> class.
        /// </summary>
        public VideoContext0()
        {
        }
    }
}