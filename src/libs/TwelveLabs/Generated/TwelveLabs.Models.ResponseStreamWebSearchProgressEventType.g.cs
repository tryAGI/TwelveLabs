
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseStreamWebSearchProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        Jockey_webSearchCompleted,
        /// <summary>
        ///
        /// </summary>
        Jockey_webSearchInProgress,
        /// <summary>
        ///
        /// </summary>
        Jockey_webSearchSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStreamWebSearchProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStreamWebSearchProgressEventType value)
        {
            return value switch
            {
                ResponseStreamWebSearchProgressEventType.Jockey_webSearchCompleted => "jockey:web_search.completed",
                ResponseStreamWebSearchProgressEventType.Jockey_webSearchInProgress => "jockey:web_search.in_progress",
                ResponseStreamWebSearchProgressEventType.Jockey_webSearchSearching => "jockey:web_search.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStreamWebSearchProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "jockey:web_search.completed" => ResponseStreamWebSearchProgressEventType.Jockey_webSearchCompleted,
                "jockey:web_search.in_progress" => ResponseStreamWebSearchProgressEventType.Jockey_webSearchInProgress,
                "jockey:web_search.searching" => ResponseStreamWebSearchProgressEventType.Jockey_webSearchSearching,
                _ => null,
            };
        }
    }
}