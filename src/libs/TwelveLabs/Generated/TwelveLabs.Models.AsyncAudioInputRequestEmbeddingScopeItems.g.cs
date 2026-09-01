
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncAudioInputRequestEmbeddingScopeItems
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
    public static class AsyncAudioInputRequestEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncAudioInputRequestEmbeddingScopeItems value)
        {
            return value switch
            {
                AsyncAudioInputRequestEmbeddingScopeItems.Asset => "asset",
                AsyncAudioInputRequestEmbeddingScopeItems.Clip => "clip",
                AsyncAudioInputRequestEmbeddingScopeItems.Local => "local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncAudioInputRequestEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AsyncAudioInputRequestEmbeddingScopeItems.Asset,
                "clip" => AsyncAudioInputRequestEmbeddingScopeItems.Clip,
                "local" => AsyncAudioInputRequestEmbeddingScopeItems.Local,
                _ => null,
            };
        }
    }
}