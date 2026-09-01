
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
    public sealed partial class EmbeddingDataEmbeddingScope2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}