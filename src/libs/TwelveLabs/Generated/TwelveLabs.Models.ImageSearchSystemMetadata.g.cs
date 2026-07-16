
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// System-generated media metadata for an image item in search results.
    /// </summary>
    public sealed partial class ImageSearchSystemMetadata
    {
        /// <summary>
        /// The width of the image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The file size of the image in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchSystemMetadata" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the image in pixels.
        /// </param>
        /// <param name="height">
        /// The height of the image in pixels.
        /// </param>
        /// <param name="size">
        /// The file size of the image in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSearchSystemMetadata(
            int? width,
            int? height,
            long? size)
        {
            this.Width = width;
            this.Height = height;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchSystemMetadata" /> class.
        /// </summary>
        public ImageSearchSystemMetadata()
        {
        }

    }
}