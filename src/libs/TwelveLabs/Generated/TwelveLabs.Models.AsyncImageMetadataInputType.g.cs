
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncImageMetadataInputType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncImageMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncImageMetadataInputType value)
        {
            return value switch
            {
                AsyncImageMetadataInputType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncImageMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AsyncImageMetadataInputType.Image,
                _ => null,
            };
        }
    }
}