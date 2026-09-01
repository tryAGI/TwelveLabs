
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncVideoInputRequestEmbeddingTypeItems
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
    public static class AsyncVideoInputRequestEmbeddingTypeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncVideoInputRequestEmbeddingTypeItems value)
        {
            return value switch
            {
                AsyncVideoInputRequestEmbeddingTypeItems.FusedEmbedding => "fused_embedding",
                AsyncVideoInputRequestEmbeddingTypeItems.SeparateEmbedding => "separate_embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncVideoInputRequestEmbeddingTypeItems? ToEnum(string value)
        {
            return value switch
            {
                "fused_embedding" => AsyncVideoInputRequestEmbeddingTypeItems.FusedEmbedding,
                "separate_embedding" => AsyncVideoInputRequestEmbeddingTypeItems.SeparateEmbedding,
                _ => null,
            };
        }
    }
}