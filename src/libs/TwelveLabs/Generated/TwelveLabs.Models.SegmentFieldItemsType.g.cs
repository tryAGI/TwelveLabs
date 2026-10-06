
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The item type. For an `array` field, use one of the scalar types (`string`, `number`, `boolean`, `integer`). For a `time_array` field, use `object` and declare the per-event schema in the `fields` array. Setting `object` as the `type` value on a plain `array` field returns a `400` error. Setting the `fields` array on a plain `array` field also returns a `400` error.
    /// </summary>
    public enum SegmentFieldItemsType
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
        Object,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentFieldItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentFieldItemsType value)
        {
            return value switch
            {
                SegmentFieldItemsType.Boolean => "boolean",
                SegmentFieldItemsType.Integer => "integer",
                SegmentFieldItemsType.Number => "number",
                SegmentFieldItemsType.Object => "object",
                SegmentFieldItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentFieldItemsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => SegmentFieldItemsType.Boolean,
                "integer" => SegmentFieldItemsType.Integer,
                "number" => SegmentFieldItemsType.Number,
                "object" => SegmentFieldItemsType.Object,
                "string" => SegmentFieldItemsType.String,
                _ => null,
            };
        }
    }
}