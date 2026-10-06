
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data type of this field. It does not accept `timestamp` or `time_array`. When set to the `array` value, the `items` object is required.
    /// </summary>
    public enum TimeArrayItemFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Array,
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimeArrayItemFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeArrayItemFieldType value)
        {
            return value switch
            {
                TimeArrayItemFieldType.Array => "array",
                TimeArrayItemFieldType.Boolean => "boolean",
                TimeArrayItemFieldType.Integer => "integer",
                TimeArrayItemFieldType.Number => "number",
                TimeArrayItemFieldType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeArrayItemFieldType? ToEnum(string value)
        {
            return value switch
            {
                "array" => TimeArrayItemFieldType.Array,
                "boolean" => TimeArrayItemFieldType.Boolean,
                "integer" => TimeArrayItemFieldType.Integer,
                "number" => TimeArrayItemFieldType.Number,
                "string" => TimeArrayItemFieldType.String,
                _ => null,
            };
        }
    }
}