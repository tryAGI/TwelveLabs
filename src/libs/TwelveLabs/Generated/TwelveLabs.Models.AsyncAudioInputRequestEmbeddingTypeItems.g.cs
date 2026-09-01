
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncAudioInputRequestEmbeddingTypeItems
    {
        /// <summary>
        ///
        /// </summary>
        FusedEmbedding,
        /// <summary>
        ///
        /// </summary>
        SeparateEmbedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncAudioInputRequestEmbeddingTypeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncAudioInputRequestEmbeddingTypeItems value)
        {
            return value switch
            {
                AsyncAudioInputRequestEmbeddingTypeItems.FusedEmbedding => "fused_embedding",
                AsyncAudioInputRequestEmbeddingTypeItems.SeparateEmbedding => "separate_embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncAudioInputRequestEmbeddingTypeItems? ToEnum(string value)
        {
            return value switch
            {
                "fused_embedding" => AsyncAudioInputRequestEmbeddingTypeItems.FusedEmbedding,
                "separate_embedding" => AsyncAudioInputRequestEmbeddingTypeItems.SeparateEmbedding,
                _ => null,
            };
        }
    }
}