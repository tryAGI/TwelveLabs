
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Always `keepalive`.
    /// </summary>
    public enum ResponseStreamKeepAliveEventType
    {
        /// <summary>
        ///
        /// </summary>
        Keepalive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamKeepAliveEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamKeepAliveEventType value)
        {
            return value switch
            {
                ResponseStreamKeepAliveEventType.Keepalive => "keepalive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamKeepAliveEventType? ToEnum(string value)
        {
            return value switch
            {
                "keepalive" => ResponseStreamKeepAliveEventType.Keepalive,
                _ => null,
            };
        }
    }
}