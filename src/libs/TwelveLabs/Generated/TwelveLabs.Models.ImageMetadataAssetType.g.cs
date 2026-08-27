
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is always set to `image` for image items.
    /// </summary>
    public enum ImageMetadataAssetType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMetadataAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMetadataAssetType value)
        {
            return value switch
            {
                ImageMetadataAssetType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMetadataAssetType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImageMetadataAssetType.Image,
                _ => null,
            };
        }
    }
}