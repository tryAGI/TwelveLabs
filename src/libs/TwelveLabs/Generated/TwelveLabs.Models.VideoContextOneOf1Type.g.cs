
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Set this field to `asset_id` to indicate that you're providing the video via a unique identifier of an asset.
    /// </summary>
    public enum VideoContextOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        AssetId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextOneOf1Type value)
        {
            return value switch
            {
                VideoContextOneOf1Type.AssetId => "asset_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "asset_id" => VideoContextOneOf1Type.AssetId,
                _ => null,
            };
        }
    }
}