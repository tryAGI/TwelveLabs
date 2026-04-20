
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyzeTasksGetParametersAnalysisMode
    {
        /// <summary>
        /// 
        /// </summary>
        TimeBasedMetadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTasksGetParametersAnalysisModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTasksGetParametersAnalysisMode value)
        {
            return value switch
            {
                AnalyzeTasksGetParametersAnalysisMode.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTasksGetParametersAnalysisMode? ToEnum(string value)
        {
            return value switch
            {
                "time_based_metadata" => AnalyzeTasksGetParametersAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}