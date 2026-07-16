
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamContentPartDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamContentPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamContentPartDoneEventType value)
        {
            return value switch
            {
                ResponseStreamContentPartDoneEventType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamContentPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => ResponseStreamContentPartDoneEventType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}