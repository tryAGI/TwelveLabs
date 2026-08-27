
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamOutputTextDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamOutputTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamOutputTextDoneEventType value)
        {
            return value switch
            {
                ResponseStreamOutputTextDoneEventType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamOutputTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => ResponseStreamOutputTextDoneEventType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}