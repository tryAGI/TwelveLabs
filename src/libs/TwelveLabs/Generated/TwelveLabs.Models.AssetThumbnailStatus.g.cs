
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The status of the thumbnail.<br/>
    /// **Values**:<br/>
    /// - `pending`: The platform has not yet started thumbnail generation<br/>
    /// - `processing`: The platform is generating the thumbnail<br/>
    /// - `ready`: The thumbnail is ready<br/>
    /// - `error`: Thumbnail generation failed
    /// </summary>
    public enum AssetThumbnailStatus
    {
        /// <summary>
        /// Thumbnail generation failed
        /// </summary>
        Error,
        /// <summary>
        /// The platform has not yet started thumbnail generation
        /// </summary>
        Pending,
        /// <summary>
        /// The platform is generating the thumbnail
        /// </summary>
        Processing,
        /// <summary>
        /// The thumbnail is ready
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetThumbnailStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetThumbnailStatus value)
        {
            return value switch
            {
                AssetThumbnailStatus.Error => "error",
                AssetThumbnailStatus.Pending => "pending",
                AssetThumbnailStatus.Processing => "processing",
                AssetThumbnailStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetThumbnailStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AssetThumbnailStatus.Error,
                "pending" => AssetThumbnailStatus.Pending,
                "processing" => AssetThumbnailStatus.Processing,
                "ready" => AssetThumbnailStatus.Ready,
                _ => null,
            };
        }
    }
}