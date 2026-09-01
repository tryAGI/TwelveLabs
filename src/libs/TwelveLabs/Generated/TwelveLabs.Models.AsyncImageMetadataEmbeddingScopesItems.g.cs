
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncImageMetadataEmbeddingScopesItems
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncImageMetadataEmbeddingScopesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncImageMetadataEmbeddingScopesItems value)
        {
            return value switch
            {
                AsyncImageMetadataEmbeddingScopesItems.Asset => "asset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncImageMetadataEmbeddingScopesItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AsyncImageMetadataEmbeddingScopesItems.Asset,
                _ => null,
            };
        }
    }
}