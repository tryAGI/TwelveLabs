
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamOutputTextDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamOutputTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamOutputTextDeltaEventType value)
        {
            return value switch
            {
                ResponseStreamOutputTextDeltaEventType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamOutputTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => ResponseStreamOutputTextDeltaEventType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}