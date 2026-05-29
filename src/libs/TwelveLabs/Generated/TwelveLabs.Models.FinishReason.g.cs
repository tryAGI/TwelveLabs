
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The reason the generation stopped.<br/>
    /// - `stop`: The generation reached the end of the output text.<br/>
    /// - `length`: The response reached the maximum response length or the context window. For JSON responses, this may return truncated JSON that fails to parse.
    /// </summary>
    public enum FinishReason
    {
        /// <summary>
        /// The response reached the maximum response length or the context window. For JSON responses, this may return truncated JSON that fails to parse.
        /// </summary>
        Length,
        /// <summary>
        /// The generation reached the end of the output text.
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.Length => "length",
                FinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "length" => FinishReason.Length,
                "stop" => FinishReason.Stop,
                _ => null,
            };
        }
    }
}