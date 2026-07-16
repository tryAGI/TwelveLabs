
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of content part.
    /// </summary>
    public enum ResponseOutputContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputContentPartType value)
        {
            return value switch
            {
                ResponseOutputContentPartType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => ResponseOutputContentPartType.OutputText,
                _ => null,
            };
        }
    }
}