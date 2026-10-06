
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of the array elements. It must be a scalar (`string`, `number`, `boolean`, or `integer`).
    /// </summary>
    public enum TimeArrayItemFieldItemsType
    {
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
    public static class TimeArrayItemFieldItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeArrayItemFieldItemsType value)
        {
            return value switch
            {
                TimeArrayItemFieldItemsType.Boolean => "boolean",
                TimeArrayItemFieldItemsType.Integer => "integer",
                TimeArrayItemFieldItemsType.Number => "number",
                TimeArrayItemFieldItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeArrayItemFieldItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => TimeArrayItemFieldItemsType.Boolean,
                "integer" => TimeArrayItemFieldItemsType.Integer,
                "number" => TimeArrayItemFieldItemsType.Number,
                "string" => TimeArrayItemFieldItemsType.String,
                _ => null,
            };
        }
    }
}