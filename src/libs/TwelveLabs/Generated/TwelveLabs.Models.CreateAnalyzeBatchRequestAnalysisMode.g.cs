
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis approach for every item in this batch.<br/>
    /// - `general`: Generate text from each video based on the prompt (the item's `prompt` field if set, otherwise `defaults.prompt`). Supports structured JSON output by using `json_schema` in the `response_format.type` field.<br/>
    /// - `time_based_metadata`: Extract timestamped metadata by using `segment_definitions` in the `response_format.type` field.<br/>
    /// Batches with mixed modes are not supported.
    /// </summary>
    public enum CreateAnalyzeBatchRequestAnalysisMode
    {
        /// <summary>
        /// Generate text from each video based on the prompt (the item's `prompt` field if set, otherwise `defaults.prompt`). Supports structured JSON output by using `json_schema` in the `response_format.type` field.
        /// </summary>
        General,
        /// <summary>
        /// Extract timestamped metadata by using `segment_definitions` in the `response_format.type` field.
        /// </summary>
        TimeBasedMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAnalyzeBatchRequestAnalysisModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnalyzeBatchRequestAnalysisMode value)
        {
            return value switch
            {
                CreateAnalyzeBatchRequestAnalysisMode.General => "general",
                CreateAnalyzeBatchRequestAnalysisMode.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnalyzeBatchRequestAnalysisMode? ToEnum(string value)
        {
            return value switch
            {
                "general" => CreateAnalyzeBatchRequestAnalysisMode.General,
                "time_based_metadata" => CreateAnalyzeBatchRequestAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}