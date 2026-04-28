
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis approach for this task.<br/>
    /// - `general`: Analyze the video and generate a response based on your prompt. Supports both free-form text and structured output via `response_format`.<br/>
    /// - `time_based_metadata`: Segment the video into time-based intervals and extract custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.<br/>
    /// **Default:** `general`<br/>
    /// Default Value: general
    /// </summary>
    public enum CreateAsyncAnalyzeRequestAnalysisMode
    {
        /// <summary>
        /// Analyze the video and generate a response based on your prompt. Supports both free-form text and structured output via `response_format`.
        /// </summary>
        General,
        /// <summary>
        /// Segment the video into time-based intervals and extract custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.
        /// </summary>
        TimeBasedMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsyncAnalyzeRequestAnalysisModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncAnalyzeRequestAnalysisMode value)
        {
            return value switch
            {
                CreateAsyncAnalyzeRequestAnalysisMode.General => "general",
                CreateAsyncAnalyzeRequestAnalysisMode.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncAnalyzeRequestAnalysisMode? ToEnum(string value)
        {
            return value switch
            {
                "general" => CreateAsyncAnalyzeRequestAnalysisMode.General,
                "time_based_metadata" => CreateAsyncAnalyzeRequestAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}