
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The scope for which the embedding was generated.<br/>
    /// **Values**:<br/>
    /// - `clip`: Embedding for a segment. For video and audio input, one embedding per detected segment.<br/>
    /// - `page`: Embedding for one page of a document. The platform returns this value only for PDF files embedded asynchronously.<br/>
    /// - `asset`: Embedding for the entire file. For video and audio input, use this scope for content up to 10-30 seconds to maintain optimal performance.<br/>
    /// - `null`: For text embeddings and images embedded synchronously.<br/>
    /// When you request the `local` scope, the platform returns `clip` for audio and video, and `page` for PDF files. For audio, video, and document input, the `metadata.embedding_scopes` field contains the scopes you requested.
    /// </summary>
    public enum EmbeddingDataEmbeddingScope
    {
        /// <summary>
        /// Embedding for the entire file. For video and audio input, use this scope for content up to 10-30 seconds to maintain optimal performance.
        /// </summary>
        Asset,
        /// <summary>
        /// Embedding for a segment. For video and audio input, one embedding per detected segment.
        /// </summary>
        Clip,
        /// <summary>
        /// Embedding for one page of a document. The platform returns this value only for PDF files embedded asynchronously.
        /// </summary>
        Page,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDataEmbeddingScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDataEmbeddingScope value)
        {
            return value switch
            {
                EmbeddingDataEmbeddingScope.Asset => "asset",
                EmbeddingDataEmbeddingScope.Clip => "clip",
                EmbeddingDataEmbeddingScope.Page => "page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDataEmbeddingScope? ToEnum(string value)
        {
            return value switch
            {
                "asset" => EmbeddingDataEmbeddingScope.Asset,
                "clip" => EmbeddingDataEmbeddingScope.Clip,
                "page" => EmbeddingDataEmbeddingScope.Page,
                _ => null,
            };
        }
    }
}