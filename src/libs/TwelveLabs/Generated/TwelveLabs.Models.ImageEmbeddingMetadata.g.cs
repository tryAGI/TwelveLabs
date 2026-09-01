
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object containing metadata associated with the embedding. Only Marengo 3.5 returns this object.
    /// </summary>
    public sealed partial class ImageEmbeddingMetadata
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
        /// The `embedding_option` values used to generate the embedding. Always `["visual"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_embedding_option")]
        public global::System.Collections.Generic.IList<string>? ImageEmbeddingOption { get; set; }

        /// <summary>
        /// The `embedding_scope` values used to generate the embedding. Always `["asset"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_embedding_scope")]
        public global::System.Collections.Generic.IList<string>? ImageEmbeddingScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingMetadata" /> class.
        /// </summary>
        /// <param name="inputUrl">
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </param>
        /// <param name="imageEmbeddingOption">
        /// The `embedding_option` values used to generate the embedding. Always `["visual"]`.
        /// </param>
        /// <param name="imageEmbeddingScope">
        /// The `embedding_scope` values used to generate the embedding. Always `["asset"]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEmbeddingMetadata(
            string? inputUrl,
            string? inputFilename,
            global::System.Collections.Generic.IList<string>? imageEmbeddingOption,
            global::System.Collections.Generic.IList<string>? imageEmbeddingScope)
        {
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.ImageEmbeddingOption = imageEmbeddingOption;
            this.ImageEmbeddingScope = imageEmbeddingScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingMetadata" /> class.
        /// </summary>
        public ImageEmbeddingMetadata()
        {
        }

    }
}