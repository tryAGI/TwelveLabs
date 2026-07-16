
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: asset_id
    /// </summary>
    public enum VideoContextVariant2Type
    {
        /// <summary>
        /// asset_id
        /// </summary>
        AssetId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextVariant2Type value)
        {
            return value switch
            {
                VideoContextVariant2Type.AssetId => "asset_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "asset_id" => VideoContextVariant2Type.AssetId,
                _ => null,
            };
        }
    }
}