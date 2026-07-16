
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis mode applied to every item in this batch.
    /// </summary>
    public enum AnalyzeBatchStatusResponseAnalysisMode
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
    public static class AnalyzeBatchStatusResponseAnalysisModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeBatchStatusResponseAnalysisMode value)
        {
            return value switch
            {
                AnalyzeBatchStatusResponseAnalysisMode.General => "general",
                AnalyzeBatchStatusResponseAnalysisMode.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeBatchStatusResponseAnalysisMode? ToEnum(string value)
        {
            return value switch
            {
                "general" => AnalyzeBatchStatusResponseAnalysisMode.General,
                "time_based_metadata" => AnalyzeBatchStatusResponseAnalysisMode.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}