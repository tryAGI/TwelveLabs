
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncImageInputRequestEmbeddingOptionItems
    {
        /// <summary>
        ///
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncImageInputRequestEmbeddingOptionItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncImageInputRequestEmbeddingOptionItems value)
        {
            return value switch
            {
                AsyncImageInputRequestEmbeddingOptionItems.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncImageInputRequestEmbeddingOptionItems? ToEnum(string value)
        {
            return value switch
            {
                "visual" => AsyncImageInputRequestEmbeddingOptionItems.Visual,
                _ => null,
            };
        }
    }
}