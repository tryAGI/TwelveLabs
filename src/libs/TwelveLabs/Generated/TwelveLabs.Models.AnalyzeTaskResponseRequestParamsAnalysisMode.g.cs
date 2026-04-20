
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis approach for this task.
    /// </summary>
    public enum AnalyzeTaskResponseRequestParamsAnalysisMode
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        TimeBasedMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTaskResponseRequestParamsAnalysisModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskResponseRequestParamsAnalysisMode value)
        {
            return value switch
            {
                AnalyzeTaskResponseRequestParamsAnalysisMode.General => "general",
                AnalyzeTaskResponseRequestParamsAnalysisMode.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskResponseRequestParamsAnalysisMode? ToEnum(string value)
        {
            return value switch
            {
                "general" => AnalyzeTaskResponseRequestParamsAnalysisMode.General,
                "time_based_metadata" => AnalyzeTaskResponseRequestParamsAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}