
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncImageInputRequestEmbeddingTypeItems
    {
        /// <summary>
        ///
        /// </summary>
        SeparateEmbedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncImageInputRequestEmbeddingTypeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncImageInputRequestEmbeddingTypeItems value)
        {
            return value switch
            {
                AsyncImageInputRequestEmbeddingTypeItems.SeparateEmbedding => "separate_embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncImageInputRequestEmbeddingTypeItems? ToEnum(string value)
        {
            return value switch
            {
                "separate_embedding" => AsyncImageInputRequestEmbeddingTypeItems.SeparateEmbedding,
                _ => null,
            };
        }
    }
}