
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Provide the video via base64-encoded data.
    /// </summary>
    public sealed partial class VideoContext2
    {
        /// <summary>
        /// Set this field to `base64_string` to indicate that you're providing the video via base64-encoded data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextOneOf2TypeJsonConverter))]
        public global::TwelveLabs.VideoContextOneOf2Type Type { get; set; }

        /// <summary>
        /// The base64-encoded video data. The maximum size is 30MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base64_string")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Base64String { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext2" /> class.
        /// </summary>
        /// <param name="base64String">
        /// The base64-encoded video data. The maximum size is 30MB.
        /// </param>
        /// <param name="type">
        /// Set this field to `base64_string` to indicate that you're providing the video via base64-encoded data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoContext2(
            string base64String,
            global::TwelveLabs.VideoContextOneOf2Type type)
        {
            this.Type = type;
            this.Base64String = base64String ?? throw new global::System.ArgumentNullException(nameof(base64String));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContext2" /> class.
        /// </summary>
        public VideoContext2()
        {
        }
    }
}