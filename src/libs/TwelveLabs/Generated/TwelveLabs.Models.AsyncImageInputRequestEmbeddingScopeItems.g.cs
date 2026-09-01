
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncImageInputRequestEmbeddingScopeItems
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncImageInputRequestEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncImageInputRequestEmbeddingScopeItems value)
        {
            return value switch
            {
                AsyncImageInputRequestEmbeddingScopeItems.Asset => "asset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncImageInputRequestEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AsyncImageInputRequestEmbeddingScopeItems.Asset,
                _ => null,
            };
        }
    }
}