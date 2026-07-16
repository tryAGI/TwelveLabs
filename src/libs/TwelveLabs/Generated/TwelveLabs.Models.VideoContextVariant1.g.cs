
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Provide the video via a URL.
    /// </summary>
    public sealed partial class VideoContextVariant1
    {
        /// <summary>
        /// Discriminator value: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextVariant1TypeJsonConverter))]
        public global::TwelveLabs.VideoContextVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoContextVariant1" /> class.
        /// </summary>
        /// <param name="url">
        /// The publicly accessible URL of the video file.<br/>
        /// Use direct links to raw media files. Video hosting platforms and cloud storage sharing links are not supported.
        /// </param>
        /// <param name="type">
        /// Discriminator value: url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoContextVariant1(
            string url,
            global::TwelveLabs.VideoContextVariant1Type type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContextVariant1" /> class.
        /// </summary>
        public VideoContextVariant1()
        {
        }

    }
}