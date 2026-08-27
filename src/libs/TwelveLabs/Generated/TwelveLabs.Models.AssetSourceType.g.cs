
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The kind of source.
    /// </summary>
    public enum AssetSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Connector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetSourceType value)
        {
            return value switch
            {
                AssetSourceType.Connector => "connector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetSourceType? ToEnum(string value)
        {
            return value switch
            {
                "connector" => AssetSourceType.Connector,
                _ => null,
            };
        }
    }
}