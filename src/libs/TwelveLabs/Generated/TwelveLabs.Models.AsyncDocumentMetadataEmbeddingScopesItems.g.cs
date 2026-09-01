
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncDocumentMetadataEmbeddingScopesItems
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
        /// <summary>
        ///
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncDocumentMetadataEmbeddingScopesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncDocumentMetadataEmbeddingScopesItems value)
        {
            return value switch
            {
                AsyncDocumentMetadataEmbeddingScopesItems.Asset => "asset",
                AsyncDocumentMetadataEmbeddingScopesItems.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncDocumentMetadataEmbeddingScopesItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AsyncDocumentMetadataEmbeddingScopesItems.Asset,
                "local" => AsyncDocumentMetadataEmbeddingScopesItems.Local,
                _ => null,
            };
        }
    }
}