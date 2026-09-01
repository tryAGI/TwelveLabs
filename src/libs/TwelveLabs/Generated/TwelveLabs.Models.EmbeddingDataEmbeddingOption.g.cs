
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The modality used to generate this embedding.<br/>
    /// **Values**:<br/>
    /// - `visual`: Embedding based on visual content (a video, a page of a PDF file, or an image embedded asynchronously).<br/>
    /// - `audio`: Embedding based on audio content.<br/>
    /// - `text`: The platform does not return this value.<br/>
    /// - `transcription`: Embedding based on transcribed speech. Returned only for content embedded with Marengo 3.0.<br/>
    /// - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio input, and only when the `embedding_type` parameter includes the `fused_embedding` value.<br/>
    /// - `null`: For text embeddings and images embedded synchronously.
    /// </summary>
    public enum EmbeddingDataEmbeddingOption
    {
        /// <summary>
        /// Embedding based on audio content.
        /// </summary>
        Audio,
        /// <summary>
        /// Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio input, and only when the `embedding_type` parameter includes the `fused_embedding` value.
        /// </summary>
        Fused,
        /// <summary>
        /// The platform does not return this value.
        /// </summary>
        Text,
        /// <summary>
        /// Embedding based on transcribed speech. Returned only for content embedded with Marengo 3.0.
        /// </summary>
        Transcription,
        /// <summary>
        /// Embedding based on visual content (a video, a page of a PDF file, or an image embedded asynchronously).
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDataEmbeddingOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDataEmbeddingOption value)
        {
            return value switch
            {
                EmbeddingDataEmbeddingOption.Audio => "audio",
                EmbeddingDataEmbeddingOption.Fused => "fused",
                EmbeddingDataEmbeddingOption.Text => "text",
                EmbeddingDataEmbeddingOption.Transcription => "transcription",
                EmbeddingDataEmbeddingOption.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDataEmbeddingOption? ToEnum(string value)
        {
            return value switch
            {
                "audio" => EmbeddingDataEmbeddingOption.Audio,
                "fused" => EmbeddingDataEmbeddingOption.Fused,
                "text" => EmbeddingDataEmbeddingOption.Text,
                "transcription" => EmbeddingDataEmbeddingOption.Transcription,
                "visual" => EmbeddingDataEmbeddingOption.Visual,
                _ => null,
            };
        }
    }
}