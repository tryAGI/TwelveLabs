
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncVideoInputRequestEmbeddingScopeItems
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
        /// <summary>
        ///
        /// </summary>
        Clip,
        /// <summary>
        ///
        /// </summary>
        Local,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncVideoInputRequestEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncVideoInputRequestEmbeddingScopeItems value)
        {
            return value switch
            {
                AsyncVideoInputRequestEmbeddingScopeItems.Asset => "asset",
                AsyncVideoInputRequestEmbeddingScopeItems.Clip => "clip",
                AsyncVideoInputRequestEmbeddingScopeItems.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncVideoInputRequestEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AsyncVideoInputRequestEmbeddingScopeItems.Asset,
                "clip" => AsyncVideoInputRequestEmbeddingScopeItems.Clip,
                "local" => AsyncVideoInputRequestEmbeddingScopeItems.Local,
                _ => null,
            };
        }
    }
}