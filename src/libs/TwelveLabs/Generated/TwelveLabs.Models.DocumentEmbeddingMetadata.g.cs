
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object containing metadata associated with the embedding. Only Marengo 3.5 returns this object.
    /// </summary>
    public sealed partial class DocumentEmbeddingMetadata
    {
        /// <summary>
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// The `embedding_option` values used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_embedding_option")]
        public global::System.Collections.Generic.IList<string>? DocumentEmbeddingOption { get; set; }

        /// <summary>
        /// The `embedding_scope` values used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_embedding_scope")]
        public global::System.Collections.Generic.IList<string>? DocumentEmbeddingScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentEmbeddingMetadata" /> class.
        /// </summary>
        /// <param name="inputUrl">
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </param>
        /// <param name="documentEmbeddingOption">
        /// The `embedding_option` values used to generate the embedding.
        /// </param>
        /// <param name="documentEmbeddingScope">
        /// The `embedding_scope` values used to generate the embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentEmbeddingMetadata(
            string? inputUrl,
            string? inputFilename,
            global::System.Collections.Generic.IList<string>? documentEmbeddingOption,
            global::System.Collections.Generic.IList<string>? documentEmbeddingScope)
        {
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.DocumentEmbeddingOption = documentEmbeddingOption;
            this.DocumentEmbeddingScope = documentEmbeddingScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentEmbeddingMetadata" /> class.
        /// </summary>
        public DocumentEmbeddingMetadata()
        {
        }

    }
}