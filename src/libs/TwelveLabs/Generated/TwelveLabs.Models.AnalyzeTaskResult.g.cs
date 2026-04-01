
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis results for a completed task.
    /// </summary>
    public sealed partial class AnalyzeTaskResult
    {
        /// <summary>
        /// The unique identifier for the generation session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The generated text based on the prompt you provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The reason for the generation to finish.<br/>
        /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
        /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.FinishReason FinishReason { get; set; }

        /// <summary>
        /// The number of tokens used in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AnalyzeTaskResultUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResult" /> class.
        /// </summary>
        /// <param name="generationId">
        /// The unique identifier for the generation session.
        /// </param>
        /// <param name="data">
        /// The generated text based on the prompt you provided.
        /// </param>
        /// <param name="finishReason">
        /// The reason for the generation to finish.<br/>
        /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
        /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="usage">
        /// The number of tokens used in the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResult(
            string generationId,
            string data,
            global::TwelveLabs.FinishReason finishReason,
            global::TwelveLabs.AnalyzeTaskResultUsage usage)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FinishReason = finishReason;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResult" /> class.
        /// </summary>
        public AnalyzeTaskResult()
        {
        }
    }
}