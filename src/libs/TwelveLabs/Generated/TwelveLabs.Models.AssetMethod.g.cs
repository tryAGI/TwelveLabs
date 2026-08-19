
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Indicates how the asset was uploaded or imported.<br/>
    /// **Values**:<br/>
    /// - `direct`: Uploaded from your local file system<br/>
    /// - `url`: Uploaded from a publicly accessible URL<br/>
    /// - `multipart`: Uploaded using the multipart upload flow<br/>
    /// - `connector`: Imported through a data connector
    /// </summary>
    public enum AssetMethod
    {
        /// <summary>
        /// Imported through a data connector
        /// </summary>
        Connector,
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
    public static class AssetMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetMethod value)
        {
            return value switch
            {
                AssetMethod.Connector => "connector",
                AssetMethod.Direct => "direct",
                AssetMethod.Multipart => "multipart",
                AssetMethod.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetMethod? ToEnum(string value)
        {
            return value switch
            {
                "connector" => AssetMethod.Connector,
                "direct" => AssetMethod.Direct,
                "multipart" => AssetMethod.Multipart,
                "url" => AssetMethod.Url,
                _ => null,
            };
        }
    }
}