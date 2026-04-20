
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The media type. Only `image` is available.
    /// </summary>
    public enum SmeMediaSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmeMediaSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmeMediaSourceMediaType value)
        {
            return value switch
            {
                SmeMediaSourceMediaType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmeMediaSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image" => SmeMediaSourceMediaType.Image,
                _ => null,
            };
        }
    }
}