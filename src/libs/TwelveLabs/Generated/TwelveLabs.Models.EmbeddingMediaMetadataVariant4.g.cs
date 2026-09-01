
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata for video embeddings.
    /// </summary>
    public sealed partial class EmbeddingMediaMetadataVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EmbeddingMediaMetadataInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.EmbeddingMediaMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the video file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the video file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Length of each video clip in seconds. Only available for fixed segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_length")]
        public int? ClipLength { get; set; }

        /// <summary>
        /// The `embedding_scope` values used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems> EmbeddingScopes { get; set; }

        /// <summary>
        /// The `embedding_option` values used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EmbeddingOptions { get; set; }

        /// <summary>
        /// The duration of the video in seconds.
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
        /// Initializes a new instance of the <see cref="EmbeddingMediaMetadataVariant4" /> class.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="embeddingScopes">
        /// The `embedding_scope` values used to generate the embedding.
        /// </param>
        /// <param name="embeddingOptions">
        /// The `embedding_option` values used to generate the embedding.
        /// </param>
        /// <param name="duration">
        /// The duration of the video in seconds.
        /// </param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the video file.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the video file.
        /// </param>
        /// <param name="clipLength">
        /// Length of each video clip in seconds. Only available for fixed segmentation.
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
        public EmbeddingMediaMetadataVariant4(
            global::TwelveLabs.EmbeddingMediaMetadataInputType inputType,
            global::System.Collections.Generic.IList<global::TwelveLabs.EmbeddingVideoMetadataEmbeddingScopesItems> embeddingScopes,
            global::System.Collections.Generic.IList<string> embeddingOptions,
            double duration,
            string? inputUrl,
            string? inputFilename,
            int? clipLength,
            double? startOffsetSec,
            double? endOffsetSec)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.ClipLength = clipLength;
            this.EmbeddingScopes = embeddingScopes ?? throw new global::System.ArgumentNullException(nameof(embeddingScopes));
            this.EmbeddingOptions = embeddingOptions ?? throw new global::System.ArgumentNullException(nameof(embeddingOptions));
            this.Duration = duration;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingMediaMetadataVariant4" /> class.
        /// </summary>
        public EmbeddingMediaMetadataVariant4()
        {
        }

    }
}