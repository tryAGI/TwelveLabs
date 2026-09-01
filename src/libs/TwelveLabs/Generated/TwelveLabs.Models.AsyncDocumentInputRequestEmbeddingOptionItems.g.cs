
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncDocumentInputRequestEmbeddingOptionItems
    {
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncDocumentInputRequestEmbeddingOptionItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncDocumentInputRequestEmbeddingOptionItems value)
        {
            return value switch
            {
                AsyncDocumentInputRequestEmbeddingOptionItems.Text => "text",
                AsyncDocumentInputRequestEmbeddingOptionItems.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncDocumentInputRequestEmbeddingOptionItems? ToEnum(string value)
        {
            return value switch
            {
                "text" => AsyncDocumentInputRequestEmbeddingOptionItems.Text,
                "visual" => AsyncDocumentInputRequestEmbeddingOptionItems.Visual,
                _ => null,
            };
        }
    }
}