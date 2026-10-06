
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The `segment_time_format` value you set. Omitted when you did not set it. Automatic boundaries are then returned as JSON numbers in seconds.
    /// </summary>
    public enum AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat
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
    public static class AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat value)
        {
            return value switch
            {
                AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat.Hh_mm_ss => "hh:mm:ss",
                AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat.Hh_mm_ssFff => "hh:mm:ss.fff",
                AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat.Seconds => "seconds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat? ToEnum(string value)
        {
            return value switch
            {
                "hh:mm:ss" => AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat.Hh_mm_ss,
                "hh:mm:ss.fff" => AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat.Hh_mm_ssFff,
                "seconds" => AnalyzeTaskResponseRequestParamsResponseFormatSegmentTimeFormat.Seconds,
                _ => null,
            };
        }
    }
}