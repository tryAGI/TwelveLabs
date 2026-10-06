
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The output format for `timestamp` fields.
    /// </summary>
    public enum AnalyzeTaskSegmentFieldFormat
    {
        /// <summary>
        ///
        /// </summary>
        Hh_mm_ss,
        /// <summary>
        ///
        /// </summary>
        Hh_mm_ssFff,
        /// <summary>
        ///
        /// </summary>
        Seconds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyzeTaskSegmentFieldFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskSegmentFieldFormat value)
        {
            return value switch
            {
                AnalyzeTaskSegmentFieldFormat.Hh_mm_ss => "hh:mm:ss",
                AnalyzeTaskSegmentFieldFormat.Hh_mm_ssFff => "hh:mm:ss.fff",
                AnalyzeTaskSegmentFieldFormat.Seconds => "seconds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskSegmentFieldFormat? ToEnum(string value)
        {
            return value switch
            {
                "hh:mm:ss" => AnalyzeTaskSegmentFieldFormat.Hh_mm_ss,
                "hh:mm:ss.fff" => AnalyzeTaskSegmentFieldFormat.Hh_mm_ssFff,
                "seconds" => AnalyzeTaskSegmentFieldFormat.Seconds,
                _ => null,
            };
        }
    }
}