
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AsyncAudioInputRequestEmbeddingOptionItems
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AsyncAudioInputRequestEmbeddingOptionItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AsyncAudioInputRequestEmbeddingOptionItems value)
        {
            return value switch
            {
                AsyncAudioInputRequestEmbeddingOptionItems.Audio => "audio",
                AsyncAudioInputRequestEmbeddingOptionItems.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AsyncAudioInputRequestEmbeddingOptionItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AsyncAudioInputRequestEmbeddingOptionItems.Audio,
                "transcription" => AsyncAudioInputRequestEmbeddingOptionItems.Transcription,
                _ => null,
            };
        }
    }
}