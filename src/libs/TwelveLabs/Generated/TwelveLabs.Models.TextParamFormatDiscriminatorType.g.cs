
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TextParamFormatDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextParamFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextParamFormatDiscriminatorType value)
        {
            return value switch
            {
                TextParamFormatDiscriminatorType.JsonSchema => "json_schema",
                TextParamFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextParamFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => TextParamFormatDiscriminatorType.JsonSchema,
                "text" => TextParamFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}