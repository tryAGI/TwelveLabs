
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The data type of the field.<br/>
    /// When set to `timestamp`, the `format` property is required and controls the format of the returned value. Requires the `model_name` parameter set to `pegasus1.5`.
    /// </summary>
    public enum SegmentFieldType
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
        /// <summary>
        /// 
        /// </summary>
        Timestamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentFieldType value)
        {
            return value switch
            {
                SegmentFieldType.Array => "array",
                SegmentFieldType.Boolean => "boolean",
                SegmentFieldType.Integer => "integer",
                SegmentFieldType.Number => "number",
                SegmentFieldType.String => "string",
                SegmentFieldType.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentFieldType? ToEnum(string value)
        {
            return value switch
            {
                "array" => SegmentFieldType.Array,
                "boolean" => SegmentFieldType.Boolean,
                "integer" => SegmentFieldType.Integer,
                "number" => SegmentFieldType.Number,
                "string" => SegmentFieldType.String,
                "timestamp" => SegmentFieldType.Timestamp,
                _ => null,
            };
        }
    }
}