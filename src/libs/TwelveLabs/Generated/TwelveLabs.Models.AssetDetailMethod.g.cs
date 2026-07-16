
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Indicates how you uploaded the asset.<br/>
    /// **Values**:<br/>
    /// - `direct`: Uploaded from your local file system<br/>
    /// - `url`: Uploaded from a publicly accessible URL<br/>
    /// - `multipart`: Uploaded using the multipart upload flow
    /// </summary>
    public enum AssetDetailMethod
    {
        /// <summary>
        /// Uploaded from your local file system
        /// </summary>
        Direct,
        /// <summary>
        /// Uploaded using the multipart upload flow
        /// </summary>
        Multipart,
        /// <summary>
        /// Uploaded from a publicly accessible URL
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetDetailMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetDetailMethod value)
        {
            return value switch
            {
                AssetDetailMethod.Direct => "direct",
                AssetDetailMethod.Multipart => "multipart",
                AssetDetailMethod.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetDetailMethod? ToEnum(string value)
        {
            return value switch
            {
                "direct" => AssetDetailMethod.Direct,
                "multipart" => AssetDetailMethod.Multipart,
                "url" => AssetDetailMethod.Url,
                _ => null,
            };
        }
    }
}