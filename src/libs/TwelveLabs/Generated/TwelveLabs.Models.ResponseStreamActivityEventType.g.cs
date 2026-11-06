
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamActivityEventType
    {
        /// <summary>
        ///
        /// </summary>
        Jockey_activity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamActivityEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamActivityEventType value)
        {
            return value switch
            {
                ResponseStreamActivityEventType.Jockey_activity => "jockey:activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamActivityEventType? ToEnum(string value)
        {
            return value switch
            {
                "jockey:activity" => ResponseStreamActivityEventType.Jockey_activity,
                _ => null,
            };
        }
    }
}