
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// This field is always set to `video` for video items.
    /// </summary>
    public enum VideoMetadataAssetType
    {
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoMetadataAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoMetadataAssetType value)
        {
            return value switch
            {
                VideoMetadataAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoMetadataAssetType? ToEnum(string value)
        {
            return value switch
            {
                "video" => VideoMetadataAssetType.Video,
                _ => null,
            };
        }
    }
}