
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The output format for `timestamp` fields. Required when `type` is `timestamp`. Must be omitted for any other type.<br/>
    /// | `format` | Example output |<br/>
    /// |----------|----------------|<br/>
    /// | `seconds` | `10.5` (JSON number in seconds) |<br/>
    /// | `hh:mm:ss` | `"00:01:23"` (rounded to the nearest second; negative values are converted to `"00:00:00"`) |<br/>
    /// | `hh:mm:ss.fff` | `"00:01:23.500"` (millisecond precision) |<br/>
    /// *Validation errors*<br/>
    /// The platform returns `400 parameter_invalid` (with field path `response_format.segment_definitions.fields.format`) when:<br/>
    /// - `type` is `timestamp` and `format` is missing, empty, or not one of the supported values.<br/>
    /// - `type` is not `timestamp` and `format` is set.
    /// </summary>
    public enum SegmentFieldFormat
    {
        /// <summary>
        /// mm:ss` | `"00:01:23"` (rounded to the nearest second; negative values are converted to `"00:00:00"`) |
        /// </summary>
        Hh_mm_ss,
        /// <summary>
        /// mm:ss.fff` | `"00:01:23.500"` (millisecond precision) |
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
    public static class SegmentFieldFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentFieldFormat value)
        {
            return value switch
            {
                SegmentFieldFormat.Hh_mm_ss => "hh:mm:ss",
                SegmentFieldFormat.Hh_mm_ssFff => "hh:mm:ss.fff",
                SegmentFieldFormat.Seconds => "seconds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentFieldFormat? ToEnum(string value)
        {
            return value switch
            {
                "hh:mm:ss" => SegmentFieldFormat.Hh_mm_ss,
                "hh:mm:ss.fff" => SegmentFieldFormat.Hh_mm_ssFff,
                "seconds" => SegmentFieldFormat.Seconds,
                _ => null,
            };
        }
    }
}