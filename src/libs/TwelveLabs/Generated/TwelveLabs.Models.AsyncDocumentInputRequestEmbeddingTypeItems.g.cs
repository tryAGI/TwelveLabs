
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncDocumentInputRequestEmbeddingTypeItems
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
    public static class AsyncDocumentInputRequestEmbeddingTypeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncDocumentInputRequestEmbeddingTypeItems value)
        {
            return value switch
            {
                AsyncDocumentInputRequestEmbeddingTypeItems.FusedEmbedding => "fused_embedding",
                AsyncDocumentInputRequestEmbeddingTypeItems.SeparateEmbedding => "separate_embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncDocumentInputRequestEmbeddingTypeItems? ToEnum(string value)
        {
            return value switch
            {
                "fused_embedding" => AsyncDocumentInputRequestEmbeddingTypeItems.FusedEmbedding,
                "separate_embedding" => AsyncDocumentInputRequestEmbeddingTypeItems.SeparateEmbedding,
                _ => null,
            };
        }
    }
}