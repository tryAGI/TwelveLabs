
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The reason the input was truncated. Present only when the `truncated` field is `true`.<br/>
    /// **Values**:<br/>
    /// - `model_context_window`: The input exceeded the context window of the model.
    /// </summary>
    public enum EmbeddingUsageTruncationReason
    {
        /// <summary>
        /// The input exceeded the context window of the model.
        /// </summary>
        ModelContextWindow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingUsageTruncationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingUsageTruncationReason value)
        {
            return value switch
            {
                EmbeddingUsageTruncationReason.ModelContextWindow => "model_context_window",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingUsageTruncationReason? ToEnum(string value)
        {
            return value switch
            {
                "model_context_window" => EmbeddingUsageTruncationReason.ModelContextWindow,
                _ => null,
            };
        }
    }
}