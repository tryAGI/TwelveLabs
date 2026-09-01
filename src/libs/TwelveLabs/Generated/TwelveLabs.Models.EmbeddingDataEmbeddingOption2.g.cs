
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
    public sealed partial class EmbeddingDataEmbeddingOption2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}