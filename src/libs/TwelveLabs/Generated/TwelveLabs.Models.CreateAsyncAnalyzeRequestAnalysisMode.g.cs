
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Sets the analysis mode to `time_based_metadata`, which segments your video into time-based intervals and extracts custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.
    /// </summary>
    public enum CreateAsyncAnalyzeRequestAnalysisMode
    {
        /// <summary>
        /// 
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
                "time_based_metadata" => CreateAsyncAnalyzeRequestAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}