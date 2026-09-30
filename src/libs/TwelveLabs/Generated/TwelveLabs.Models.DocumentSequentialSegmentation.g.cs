
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides a plain text or Markdown file into chunks. For a PDF file, the platform divides by page instead and returns a `400` error if you include this object.<br/>
    /// This object requires the `text` value in the `embedding_option` field and the `local` value in the `embedding_scope` field.
    /// </summary>
    public sealed partial class DocumentSequentialSegmentation
    {
        /// <summary>
        /// The strategy for dividing the text into chunks. Always `sentence`, which groups whole sentences into each chunk, up to the number of sentences in the `max_sentences` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.DocumentSequentialSegmentationStrategyJsonConverter))]
        public global::TwelveLabs.DocumentSequentialSegmentationStrategy Strategy { get; set; }

        /// <summary>
        /// The maximum number of sentences in each chunk. This field has no default.<br/>
        /// Choose a value small enough that every chunk fits in the context window of the model. If a chunk exceeds that window, the task fails, and the platform does not truncate it. How many sentences fit depends on the length of the sentences in your file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sentences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSentences { get; set; }

        /// <summary>
        /// The number of sentences at the end of one chunk that the platform repeats at the start of the next. The overlap preserves the context of the previous chunk. This value must be less than the `max_sentences` value.<br/>
        /// **Default**: 0<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap_sentences")]
        public int? OverlapSentences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSequentialSegmentation" /> class.
        /// </summary>
        /// <param name="maxSentences">
        /// The maximum number of sentences in each chunk. This field has no default.<br/>
        /// Choose a value small enough that every chunk fits in the context window of the model. If a chunk exceeds that window, the task fails, and the platform does not truncate it. How many sentences fit depends on the length of the sentences in your file.
        /// </param>
        /// <param name="strategy">
        /// The strategy for dividing the text into chunks. Always `sentence`, which groups whole sentences into each chunk, up to the number of sentences in the `max_sentences` field.
        /// </param>
        /// <param name="overlapSentences">
        /// The number of sentences at the end of one chunk that the platform repeats at the start of the next. The overlap preserves the context of the previous chunk. This value must be less than the `max_sentences` value.<br/>
        /// **Default**: 0<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentSequentialSegmentation(
            int maxSentences,
            global::TwelveLabs.DocumentSequentialSegmentationStrategy strategy,
            int? overlapSentences)
        {
            this.Strategy = strategy;
            this.MaxSentences = maxSentences;
            this.OverlapSentences = overlapSentences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSequentialSegmentation" /> class.
        /// </summary>
        public DocumentSequentialSegmentation()
        {
        }

    }
}