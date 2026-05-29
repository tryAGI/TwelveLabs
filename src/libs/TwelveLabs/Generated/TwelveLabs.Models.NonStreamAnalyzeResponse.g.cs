
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// When the value of the `stream` parameter is set to `false`, the response is as follows:
    /// </summary>
    public sealed partial class NonStreamAnalyzeResponse
    {
        /// <summary>
        /// Unique identifier of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The generated text based on the prompt you provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// The reason the generation stopped.<br/>
        /// - `stop`: The generation reached the end of the output text.<br/>
        /// - `length`: The response reached the maximum response length or the context window. For JSON responses, this may return truncated JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.FinishReasonJsonConverter))]
        public global::TwelveLabs.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// The number of tokens used in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::TwelveLabs.TokenUsage? Usage { get; set; }

        /// <summary>
        /// A warning. Present when `finish_reason` is `length` — the response reached the maximum response length or the [context window](/v1.3/docs/concepts/models/pegasus#context-window). The partial output is returned in `data`. Pegasus 1.2 also returns this field when `finish_reason` is `length`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::TwelveLabs.AnalyzeTaskError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NonStreamAnalyzeResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the response.
        /// </param>
        /// <param name="data">
        /// The generated text based on the prompt you provided.
        /// </param>
        /// <param name="finishReason">
        /// The reason the generation stopped.<br/>
        /// - `stop`: The generation reached the end of the output text.<br/>
        /// - `length`: The response reached the maximum response length or the context window. For JSON responses, this may return truncated JSON that fails to parse.
        /// </param>
        /// <param name="usage">
        /// The number of tokens used in the generation.
        /// </param>
        /// <param name="error">
        /// A warning. Present when `finish_reason` is `length` — the response reached the maximum response length or the [context window](/v1.3/docs/concepts/models/pegasus#context-window). The partial output is returned in `data`. Pegasus 1.2 also returns this field when `finish_reason` is `length`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NonStreamAnalyzeResponse(
            string? id,
            string? data,
            global::TwelveLabs.FinishReason? finishReason,
            global::TwelveLabs.TokenUsage? usage,
            global::TwelveLabs.AnalyzeTaskError? error)
        {
            this.Id = id;
            this.Data = data;
            this.FinishReason = finishReason;
            this.Usage = usage;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NonStreamAnalyzeResponse" /> class.
        /// </summary>
        public NonStreamAnalyzeResponse()
        {
        }

    }
}