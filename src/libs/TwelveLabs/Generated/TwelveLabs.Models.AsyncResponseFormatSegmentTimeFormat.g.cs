
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Set the output format for the automatic `start_time` and `end_time` keys returned on each segment. Requires the `type` parameter set to `segment_definitions` and the `model_name` parameter set to `pegasus1.5`. Omitting this parameter is equivalent to setting it to `seconds` — both return JSON numbers in seconds.<br/>
    /// | `segment_time_format` | Auto boundary output |<br/>
    /// |-----------------------|----------------------|<br/>
    /// | `seconds` (default) | JSON number in seconds (Example: `12.5`) |<br/>
    /// | `hh:mm:ss` | JSON string (Example: `"00:00:13"`) — rounded to the nearest second |<br/>
    /// | `hh:mm:ss.fff` | JSON string (Example: `"00:00:12.500"`) — millisecond precision |<br/>
    /// This parameter applies only to the automatic segment boundaries (`start_time` and `end_time`). Custom `timestamp` fields always use their own format, regardless of the value of this field.<br/>
    /// Default Value: seconds
    /// </summary>
    public enum AsyncResponseFormatSegmentTimeFormat
    {
        /// <summary>
        /// mm:ss` | JSON string (Example: `"00:00:13"`) — rounded to the nearest second |
        /// </summary>
        Hh_mm_ss,
        /// <summary>
        /// mm:ss.fff` | JSON string (Example: `"00:00:12.500"`) — millisecond precision |
        /// </summary>
        Hh_mm_ssFff,
        /// <summary>
        /// `12.5`) |
        /// </summary>
        Seconds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncResponseFormatSegmentTimeFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncResponseFormatSegmentTimeFormat value)
        {
            return value switch
            {
                AsyncResponseFormatSegmentTimeFormat.Hh_mm_ss => "hh:mm:ss",
                AsyncResponseFormatSegmentTimeFormat.Hh_mm_ssFff => "hh:mm:ss.fff",
                AsyncResponseFormatSegmentTimeFormat.Seconds => "seconds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncResponseFormatSegmentTimeFormat? ToEnum(string value)
        {
            return value switch
            {
                "hh:mm:ss" => AsyncResponseFormatSegmentTimeFormat.Hh_mm_ss,
                "hh:mm:ss.fff" => AsyncResponseFormatSegmentTimeFormat.Hh_mm_ssFff,
                "seconds" => AsyncResponseFormatSegmentTimeFormat.Seconds,
                _ => null,
            };
        }
    }
}