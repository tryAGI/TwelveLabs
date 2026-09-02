
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata attached to a video knowledge store item in search results.
    /// </summary>
    public sealed partial class VideoSearchItemMetadata
    {
        /// <summary>
        /// System-generated media metadata for the source video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::TwelveLabs.VideoSearchSystemMetadata? System { get; set; }

        /// <summary>
        /// Caller-supplied key-value pairs attached to the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public object? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchItemMetadata" /> class.
        /// </summary>
        /// <param name="system">
        /// System-generated media metadata for the source video.
        /// </param>
        /// <param name="user">
        /// Caller-supplied key-value pairs attached to the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSearchItemMetadata(
            global::TwelveLabs.VideoSearchSystemMetadata? system,
            object? user)
        {
            this.System = system;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSearchItemMetadata" /> class.
        /// </summary>
        public VideoSearchItemMetadata()
        {
        }

    }
}