
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextResponseFormatTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextResponseFormatTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextResponseFormatTextType value)
        {
            return value switch
            {
                TextResponseFormatTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextResponseFormatTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextResponseFormatTextType.Text,
                _ => null,
            };
        }
    }
}