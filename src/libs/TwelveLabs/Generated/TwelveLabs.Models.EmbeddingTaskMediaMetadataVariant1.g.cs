
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for audio embeddings.
    /// </summary>
    public sealed partial class EmbeddingTaskMediaMetadataVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EmbeddingTaskMediaMetadataInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.EmbeddingTaskMediaMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// The `embedding_option` values used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EmbeddingOptions { get; set; }

        /// <summary>
        /// The `embedding_scope` values used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems> EmbeddingScopes { get; set; }

        /// <summary>
        /// The duration of the audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The start offset in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset_sec")]
        public double? StartOffsetSec { get; set; }

        /// <summary>
        /// The end offset in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset_sec")]
        public double? EndOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskMediaMetadataVariant1" /> class.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="embeddingOptions">
        /// The `embedding_option` values used to generate the embedding.
        /// </param>
        /// <param name="embeddingScopes">
        /// The `embedding_scope` values used to generate the embedding.
        /// </param>
        /// <param name="duration">
        /// The duration of the audio in seconds.
        /// </param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the audio file.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the audio file.
        /// </param>
        /// <param name="startOffsetSec">
        /// The start offset in seconds.
        /// </param>
        /// <param name="endOffsetSec">
        /// The end offset in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingTaskMediaMetadataVariant1(
            global::TwelveLabs.EmbeddingTaskMediaMetadataInputType inputType,
            global::System.Collections.Generic.IList<string> embeddingOptions,
            global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingAudioMetadataEmbeddingScopesItems> embeddingScopes,
            double duration,
            string? inputUrl,
            string? inputFilename,
            double? startOffsetSec,
            double? endOffsetSec)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.EmbeddingOptions = embeddingOptions ?? throw new global::System.ArgumentNullException(nameof(embeddingOptions));
            this.EmbeddingScopes = embeddingScopes ?? throw new global::System.ArgumentNullException(nameof(embeddingScopes));
            this.Duration = duration;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskMediaMetadataVariant1" /> class.
        /// </summary>
        public EmbeddingTaskMediaMetadataVariant1()
        {
        }

    }
}