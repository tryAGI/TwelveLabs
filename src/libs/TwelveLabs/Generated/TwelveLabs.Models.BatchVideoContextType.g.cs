
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Set this field to `asset_id` to indicate that you're providing the video as an asset.
    /// </summary>
    public enum BatchVideoContextType
    {
        /// <summary>
        /// 
        /// </summary>
        AssetId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchVideoContextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchVideoContextType value)
        {
            return value switch
            {
                BatchVideoContextType.AssetId => "asset_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchVideoContextType? ToEnum(string value)
        {
            return value switch
            {
                "asset_id" => BatchVideoContextType.AssetId,
                _ => null,
            };
        }
    }
}