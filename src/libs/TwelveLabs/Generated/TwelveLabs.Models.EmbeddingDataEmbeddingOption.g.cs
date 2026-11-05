
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of the embedding.<br/>
    /// **Values**:<br/>
    /// - `visual`: Embedding based on visual content (a video, a page of a PDF file, or an image embedded asynchronously).<br/>
    /// - `audio`: Embedding based on audio content.<br/>
    /// - `text`: Embedding based on the text content of a PDF, plain text, or Markdown file embedded asynchronously.<br/>
    /// - `transcription`: Embedding based on transcribed speech. Only Marengo 3.0 returns this value.<br/>
    /// - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio input, and only when the `embedding_type` parameter includes the `fused_embedding` value.<br/>
    /// This field is omitted for synchronous text and image inputs.
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
        /// Embedding based on the text content of a PDF, plain text, or Markdown file embedded asynchronously.
        /// </summary>
        Text,
        /// <summary>
        /// Embedding based on transcribed speech. Only Marengo 3.0 returns this value.
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