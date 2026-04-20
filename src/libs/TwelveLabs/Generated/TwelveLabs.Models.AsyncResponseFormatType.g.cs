
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The response format to use.<br/>
    /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
    /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
    /// </summary>
    public enum AsyncResponseFormatType
    {
        /// <summary>
        /// Return structured JSON that conforms to your schema.
        /// </summary>
        JsonSchema,
        /// <summary>
        /// Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </summary>
        SegmentDefinitions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncResponseFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncResponseFormatType value)
        {
            return value switch
            {
                AsyncResponseFormatType.JsonSchema => "json_schema",
                AsyncResponseFormatType.SegmentDefinitions => "segment_definitions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncResponseFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => AsyncResponseFormatType.JsonSchema,
                "segment_definitions" => AsyncResponseFormatType.SegmentDefinitions,
                _ => null,
            };
        }
    }
}