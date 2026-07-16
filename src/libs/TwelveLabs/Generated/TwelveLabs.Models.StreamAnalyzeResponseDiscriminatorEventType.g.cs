
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamAnalyzeResponseDiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        StreamEnd,
        /// <summary>
        /// 
        /// </summary>
        StreamStart,
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamAnalyzeResponseDiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamAnalyzeResponseDiscriminatorEventType value)
        {
            return value switch
            {
                StreamAnalyzeResponseDiscriminatorEventType.StreamEnd => "stream_end",
                StreamAnalyzeResponseDiscriminatorEventType.StreamStart => "stream_start",
                StreamAnalyzeResponseDiscriminatorEventType.TextGeneration => "text_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamAnalyzeResponseDiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "stream_end" => StreamAnalyzeResponseDiscriminatorEventType.StreamEnd,
                "stream_start" => StreamAnalyzeResponseDiscriminatorEventType.StreamStart,
                "text_generation" => StreamAnalyzeResponseDiscriminatorEventType.TextGeneration,
                _ => null,
            };
        }
    }
}