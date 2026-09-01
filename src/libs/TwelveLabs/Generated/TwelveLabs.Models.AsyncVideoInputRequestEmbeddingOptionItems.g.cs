
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncVideoInputRequestEmbeddingOptionItems
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Transcription,
        /// <summary>
        ///
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncVideoInputRequestEmbeddingOptionItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncVideoInputRequestEmbeddingOptionItems value)
        {
            return value switch
            {
                AsyncVideoInputRequestEmbeddingOptionItems.Audio => "audio",
                AsyncVideoInputRequestEmbeddingOptionItems.Transcription => "transcription",
                AsyncVideoInputRequestEmbeddingOptionItems.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncVideoInputRequestEmbeddingOptionItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AsyncVideoInputRequestEmbeddingOptionItems.Audio,
                "transcription" => AsyncVideoInputRequestEmbeddingOptionItems.Transcription,
                "visual" => AsyncVideoInputRequestEmbeddingOptionItems.Visual,
                _ => null,
            };
        }
    }
}