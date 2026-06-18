
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalyzeBatchesGetParametersAnalysisModeSchemaItems
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
    public static class AnalyzeBatchesGetParametersAnalysisModeSchemaItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeBatchesGetParametersAnalysisModeSchemaItems value)
        {
            return value switch
            {
                AnalyzeBatchesGetParametersAnalysisModeSchemaItems.General => "general",
                AnalyzeBatchesGetParametersAnalysisModeSchemaItems.TimeBasedMetadata => "time_based_metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeBatchesGetParametersAnalysisModeSchemaItems? ToEnum(string value)
        {
            return value switch
            {
                "general" => AnalyzeBatchesGetParametersAnalysisModeSchemaItems.General,
                "time_based_metadata" => AnalyzeBatchesGetParametersAnalysisModeSchemaItems.TimeBasedMetadata,
                _ => null,
            };
        }
    }
}