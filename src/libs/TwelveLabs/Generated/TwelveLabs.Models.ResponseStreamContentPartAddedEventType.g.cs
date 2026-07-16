
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamContentPartAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamContentPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamContentPartAddedEventType value)
        {
            return value switch
            {
                ResponseStreamContentPartAddedEventType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamContentPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => ResponseStreamContentPartAddedEventType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}