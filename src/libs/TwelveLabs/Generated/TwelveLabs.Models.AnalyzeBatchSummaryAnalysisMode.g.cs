
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis mode applied to every item in this batch.
    /// </summary>
    public enum AnalyzeBatchSummaryAnalysisMode
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
    public static class AnalyzeBatchSummaryAnalysisModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeBatchSummaryAnalysisMode value)
        {
            return value switch
            {
                AnalyzeBatchSummaryAnalysisMode.General => "general",
                AnalyzeBatchSummaryAnalysisMode.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeBatchSummaryAnalysisMode? ToEnum(string value)
        {
            return value switch
            {
                "general" => AnalyzeBatchSummaryAnalysisMode.General,
                "time_based_metadata" => AnalyzeBatchSummaryAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}