
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamOutputItemDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamOutputItemDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamOutputItemDoneEventType value)
        {
            return value switch
            {
                ResponseStreamOutputItemDoneEventType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamOutputItemDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => ResponseStreamOutputItemDoneEventType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}