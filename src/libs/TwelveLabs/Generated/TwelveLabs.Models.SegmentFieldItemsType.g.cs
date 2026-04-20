
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
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
                "string" => SegmentFieldItemsType.String,
                _ => null,
            };
        }
    }
}