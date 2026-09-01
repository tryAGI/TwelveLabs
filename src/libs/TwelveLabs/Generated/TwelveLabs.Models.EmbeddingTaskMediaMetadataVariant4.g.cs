
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for image embeddings. Only Marengo 3.5 returns this object.
    /// </summary>
    public sealed partial class EmbeddingTaskMediaMetadataVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.EmbeddingTaskMediaMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the image file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the image file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// The `embedding_option` values used to generate the embedding. Always `["visual"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_options")]
        public global::System.Collections.Generic.IList<string>? EmbeddingOptions { get; set; }

        /// <summary>
        /// The `embedding_scope` values used to generate the embedding. Always `["asset"]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scopes")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? EmbeddingScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskMediaMetadataVariant4" /> class.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the image file.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the image file.
        /// </param>
        /// <param name="embeddingOptions">
        /// The `embedding_option` values used to generate the embedding. Always `["visual"]`.
        /// </param>
        /// <param name="embeddingScopes">
        /// The `embedding_scope` values used to generate the embedding. Always `["asset"]`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingTaskMediaMetadataVariant4(
            global::TwelveLabs.EmbeddingTaskMediaMetadataInputType inputType,
            string? inputUrl,
            string? inputFilename,
            global::System.Collections.Generic.IList<string>? embeddingOptions,
            global::System.Collections.Generic.IList<global::TwelveLabs.AsyncImageMetadataEmbeddingScopesItems>? embeddingScopes)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.EmbeddingOptions = embeddingOptions;
            this.EmbeddingScopes = embeddingScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskMediaMetadataVariant4" /> class.
        /// </summary>
        public EmbeddingTaskMediaMetadataVariant4()
        {
        }

    }
}