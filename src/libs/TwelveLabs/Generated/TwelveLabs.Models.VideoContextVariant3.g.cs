
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Provide the video via base64-encoded data.
    /// </summary>
    public sealed partial class VideoContextVariant3
    {
        /// <summary>
        /// Discriminator value: base64_string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextVariant3TypeJsonConverter))]
        public global::TwelveLabs.VideoContextVariant3Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoContextVariant3" /> class.
        /// </summary>
        /// <param name="base64String">
        /// The base64-encoded video data. The maximum size is 30MB.
        /// </param>
        /// <param name="type">
        /// Discriminator value: base64_string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoContextVariant3(
            string base64String,
            global::TwelveLabs.VideoContextVariant3Type type)
        {
            this.Type = type;
            this.Base64String = base64String ?? throw new global::System.ArgumentNullException(nameof(base64String));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoContextVariant3" /> class.
        /// </summary>
        public VideoContextVariant3()
        {
        }

    }
}