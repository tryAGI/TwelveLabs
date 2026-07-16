
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamOutputItemAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamOutputItemAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamOutputItemAddedEventType value)
        {
            return value switch
            {
                ResponseStreamOutputItemAddedEventType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamOutputItemAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => ResponseStreamOutputItemAddedEventType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}