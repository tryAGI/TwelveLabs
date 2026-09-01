
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncDocumentInputRequestEmbeddingScopeItems
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
    public static class AsyncDocumentInputRequestEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncDocumentInputRequestEmbeddingScopeItems value)
        {
            return value switch
            {
                AsyncDocumentInputRequestEmbeddingScopeItems.Asset => "asset",
                AsyncDocumentInputRequestEmbeddingScopeItems.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncDocumentInputRequestEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AsyncDocumentInputRequestEmbeddingScopeItems.Asset,
                "local" => AsyncDocumentInputRequestEmbeddingScopeItems.Local,
                _ => null,
            };
        }
    }
}