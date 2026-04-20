
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyzeTaskResponseRequestParamsResponseFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        SegmentDefinitions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTaskResponseRequestParamsResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskResponseRequestParamsResponseFormatType value)
        {
            return value switch
            {
                AnalyzeTaskResponseRequestParamsResponseFormatType.JsonSchema => "json_schema",
                AnalyzeTaskResponseRequestParamsResponseFormatType.SegmentDefinitions => "segment_definitions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskResponseRequestParamsResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => AnalyzeTaskResponseRequestParamsResponseFormatType.JsonSchema,
                "segment_definitions" => AnalyzeTaskResponseRequestParamsResponseFormatType.SegmentDefinitions,
                _ => null,
            };
        }
    }
}