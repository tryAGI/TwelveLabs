
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An embedding with its metadata.
    /// </summary>
    public sealed partial class EmbeddingData
    {
        /// <summary>
        /// The embedding vector for the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Embedding { get; set; }

        /// <summary>
        /// A per-dimension uncertainty vector with the same length as the `embedding` array. A higher value indicates lower confidence in that dimension. Present when the request sets [`embedding_uncertainty: true`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#request.body.embedding-uncertainty). Only Marengo 3.5 returns this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_uncertainty")]
        public global::System.Collections.Generic.IList<double>? EmbeddingUncertainty { get; set; }

        /// <summary>
        /// The type of the embedding.<br/>
        /// **Values**:<br/>
        /// - `visual`: Embedding based on visual content (a video, a page of a PDF file, or an image embedded asynchronously).<br/>
        /// - `audio`: Embedding based on audio content.<br/>
        /// - `text`: Embedding based on the text content of a PDF, plain text, or Markdown file embedded asynchronously.<br/>
        /// - `transcription`: Embedding based on transcribed speech. Returned only for content embedded with Marengo 3.0.<br/>
        /// - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio input, and only when the `embedding_type` parameter includes the `fused_embedding` value.<br/>
        /// - `null`: For text embeddings and images embedded synchronously.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_option")]
        public global::TwelveLabs.EmbeddingDataEmbeddingOption? EmbeddingOption { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scope")]
        public global::TwelveLabs.EmbeddingDataEmbeddingScope? EmbeddingScope { get; set; }

        /// <summary>
        /// The start time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        public double? StartSec { get; set; }

        /// <summary>
        /// The end time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        public double? EndSec { get; set; }

        /// <summary>
        /// The first page this embedding covers, counting from 1. The platform returns this field only for page-level embeddings of a PDF file, and `null` in every other case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_page_number")]
        public int? StartPageNumber { get; set; }

        /// <summary>
        /// The last page this embedding covers, counting from 1 and including that page. This field matches the `start_page_number` field when the embedding covers a single page. The platform returns this field only for page-level embeddings of a PDF file, and `null` in every other case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_page_number")]
        public int? EndPageNumber { get; set; }

        /// <summary>
        /// The quarter of the page this embedding covers. The platform returns this field only when the request sets [`document.segmentation.spatial.strategy`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task#request.body.document.segmentation.spatial.strategy) to `quadrants`, and only on the four quadrant embeddings of a page. This field is `null` on the whole-page embedding and in every other case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quadrant")]
        public global::TwelveLabs.EmbeddingDataQuadrant? Quadrant { get; set; }

        /// <summary>
        /// The position of this chunk in the file, counting from 0. The platform returns this field only on `chunk`-scope embeddings of a plain text or Markdown file, and `null` in every other case.<br/>
        /// Read this field rather than the position of the entry in the `data` array, which provides no ordering guarantee.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        public int? ChunkIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        /// <param name="embedding">
        /// The embedding vector for the content.
        /// </param>
        /// <param name="embeddingUncertainty">
        /// A per-dimension uncertainty vector with the same length as the `embedding` array. A higher value indicates lower confidence in that dimension. Present when the request sets [`embedding_uncertainty: true`](/v1.3/api-reference/create-embeddings-v2/create-embeddings#request.body.embedding-uncertainty). Only Marengo 3.5 returns this field.
        /// </param>
        /// <param name="embeddingOption">
        /// The type of the embedding.<br/>
        /// **Values**:<br/>
        /// - `visual`: Embedding based on visual content (a video, a page of a PDF file, or an image embedded asynchronously).<br/>
        /// - `audio`: Embedding based on audio content.<br/>
        /// - `text`: Embedding based on the text content of a PDF, plain text, or Markdown file embedded asynchronously.<br/>
        /// - `transcription`: Embedding based on transcribed speech. Returned only for content embedded with Marengo 3.0.<br/>
        /// - `fused`: Embedding based on a combination of the modalities specified in the request. The platform returns this embedding only for video and audio input, and only when the `embedding_type` parameter includes the `fused_embedding` value.<br/>
        /// - `null`: For text embeddings and images embedded synchronously.
        /// </param>
        /// <param name="embeddingScope">
        /// The scope for which the embedding was generated.<br/>
        /// **Values**:<br/>
        /// - `clip`: Embedding for a segment. For video and audio input, one embedding per detected segment.<br/>
        /// - `page`: Embedding for one page of a PDF file embedded asynchronously, or for one quadrant of a page when the request sets [`document.segmentation.spatial.strategy`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task#request.body.document.segmentation.spatial.strategy) to `quadrants`. With that strategy, five entries share the same scope and page numbers, so read the `quadrant` field to tell them apart: the whole-page entry has no `quadrant` value.<br/>
        /// - `chunk`: Embedding for one chunk of whole sentences from a plain text or Markdown file embedded asynchronously. Read the `chunk_index` field for the position of the chunk in the file.<br/>
        /// - `asset`: Embedding for the entire file. For video and audio input, use this scope for content up to 10-30 seconds to maintain optimal performance.<br/>
        /// - `null`: For text embeddings and images embedded synchronously.<br/>
        /// When you request the `local` scope, the platform returns `clip` for audio and video, `page` for PDF files, and `chunk` for plain text and Markdown files. For audio, video, and document input, the `metadata.embedding_scopes` field contains the scopes you requested.
        /// </param>
        /// <param name="startSec">
        /// The start time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </param>
        /// <param name="endSec">
        /// The end time in seconds for this segment. This field is `null` for text and image embeddings.
        /// </param>
        /// <param name="startPageNumber">
        /// The first page this embedding covers, counting from 1. The platform returns this field only for page-level embeddings of a PDF file, and `null` in every other case.
        /// </param>
        /// <param name="endPageNumber">
        /// The last page this embedding covers, counting from 1 and including that page. This field matches the `start_page_number` field when the embedding covers a single page. The platform returns this field only for page-level embeddings of a PDF file, and `null` in every other case.
        /// </param>
        /// <param name="quadrant">
        /// The quarter of the page this embedding covers. The platform returns this field only when the request sets [`document.segmentation.spatial.strategy`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task#request.body.document.segmentation.spatial.strategy) to `quadrants`, and only on the four quadrant embeddings of a page. This field is `null` on the whole-page embedding and in every other case.
        /// </param>
        /// <param name="chunkIndex">
        /// The position of this chunk in the file, counting from 0. The platform returns this field only on `chunk`-scope embeddings of a plain text or Markdown file, and `null` in every other case.<br/>
        /// Read this field rather than the position of the entry in the `data` array, which provides no ordering guarantee.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingData(
            global::System.Collections.Generic.IList<double> embedding,
            global::System.Collections.Generic.IList<double>? embeddingUncertainty,
            global::TwelveLabs.EmbeddingDataEmbeddingOption? embeddingOption,
            global::TwelveLabs.EmbeddingDataEmbeddingScope? embeddingScope,
            double? startSec,
            double? endSec,
            int? startPageNumber,
            int? endPageNumber,
            global::TwelveLabs.EmbeddingDataQuadrant? quadrant,
            int? chunkIndex)
        {
            this.Embedding = embedding ?? throw new global::System.ArgumentNullException(nameof(embedding));
            this.EmbeddingUncertainty = embeddingUncertainty;
            this.EmbeddingOption = embeddingOption;
            this.EmbeddingScope = embeddingScope;
            this.StartSec = startSec;
            this.EndSec = endSec;
            this.StartPageNumber = startPageNumber;
            this.EndPageNumber = endPageNumber;
            this.Quadrant = quadrant;
            this.ChunkIndex = chunkIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingData" /> class.
        /// </summary>
        public EmbeddingData()
        {
        }

    }
}