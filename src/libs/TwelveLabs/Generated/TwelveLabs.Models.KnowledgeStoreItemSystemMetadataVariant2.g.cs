
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// System-generated media metadata for an image item.
    /// </summary>
    public sealed partial class KnowledgeStoreItemSystemMetadataVariant2
    {
        /// <summary>
        /// This field is always set to `image` for image items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ImageMetadataAssetTypeJsonConverter))]
        public global::TwelveLabs.ImageMetadataAssetType AssetType { get; set; }

        /// <summary>
        /// The original filename of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

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
        /// The codec used to encode the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec_name")]
        public string? CodecName { get; set; }

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
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemSystemMetadataVariant2" /> class.
        /// </summary>
        /// <param name="assetType">
        /// This field is always set to `image` for image items.
        /// </param>
        /// <param name="filename">
        /// The original filename of the image.
        /// </param>
        /// <param name="width">
        /// The width of the image in pixels.
        /// </param>
        /// <param name="height">
        /// The height of the image in pixels.
        /// </param>
        /// <param name="codecName">
        /// The codec used to encode the image.
        /// </param>
        /// <param name="size">
        /// The file size of the image in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItemSystemMetadataVariant2(
            global::TwelveLabs.ImageMetadataAssetType assetType,
            string? filename,
            int? width,
            int? height,
            string? codecName,
            long? size)
        {
            this.AssetType = assetType;
            this.Filename = filename;
            this.Width = width;
            this.Height = height;
            this.CodecName = codecName;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemSystemMetadataVariant2" /> class.
        /// </summary>
        public KnowledgeStoreItemSystemMetadataVariant2()
        {
        }

    }
}