
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The scope for which the embedding was generated.<br/>
    /// **Values**:<br/>
    /// - `clip`: Embedding for a segment. For video and audio input, one embedding per detected segment.<br/>
    /// - `page`: Embedding for one page of a PDF file embedded asynchronously, or for one quadrant of a page when the request sets [`document.segmentation.spatial.strategy`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task#request.body.document.segmentation.spatial.strategy) to `quadrants`. With that strategy, five entries share the same scope and page numbers, so read the `quadrant` field to tell them apart: the whole-page entry has no `quadrant` value.<br/>
    /// - `chunk`: Embedding for one chunk of whole sentences from a plain text or Markdown file embedded asynchronously. Read the `chunk_index` field for the position of the chunk in the file.<br/>
    /// - `asset`: Embedding for the entire file. For video and audio input, use this scope for content up to 10-30 seconds to maintain optimal performance.<br/>
    /// - `null`: For text embeddings and images embedded synchronously.<br/>
    /// When you request the `local` scope, the platform returns `clip` for audio and video, `page` for PDF files, and `chunk` for plain text and Markdown files. For audio, video, and document input, the `metadata.embedding_scopes` field contains the scopes you requested.
    /// </summary>
    public enum EmbeddingDataEmbeddingScope
    {
        /// <summary>
        /// Embedding for the entire file. For video and audio input, use this scope for content up to 10-30 seconds to maintain optimal performance.
        /// </summary>
        Asset,
        /// <summary>
        /// Embedding for one chunk of whole sentences from a plain text or Markdown file embedded asynchronously. Read the `chunk_index` field for the position of the chunk in the file.
        /// </summary>
        Chunk,
        /// <summary>
        /// Embedding for a segment. For video and audio input, one embedding per detected segment.
        /// </summary>
        Clip,
        /// <summary>
        /// Embedding for one page of a PDF file embedded asynchronously, or for one quadrant of a page when the request sets [`document.segmentation.spatial.strategy`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task#request.body.document.segmentation.spatial.strategy) to `quadrants`. With that strategy, five entries share the same scope and page numbers, so read the `quadrant` field to tell them apart: the whole-page entry has no `quadrant` value.
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
                EmbeddingDataEmbeddingScope.Chunk => "chunk",
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
                "chunk" => EmbeddingDataEmbeddingScope.Chunk,
                "clip" => EmbeddingDataEmbeddingScope.Clip,
                "page" => EmbeddingDataEmbeddingScope.Page,
                _ => null,
            };
        }
    }
}