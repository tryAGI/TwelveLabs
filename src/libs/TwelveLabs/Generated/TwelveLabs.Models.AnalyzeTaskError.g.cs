
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A message attached to an analysis response. The platform uses this object in three cases:<br/>
    /// - **Task failure** — set on `AnalyzeTaskResponse.error` when `status` is `failed`. The `message` field describes the failure.<br/>
    /// - **Truncation: maximum response length reached** — set on the response `error` when `finish_reason` is `length` because `output_tokens` reached the requested `max_tokens` value. The `message` field advises increasing the `max_tokens` value.<br/>
    /// - **Truncation: context window reached** — set on the response `error` when `finish_reason` is `length` because the input and response reached the [context window](/v1.3/docs/concepts/models/pegasus#context-window). The `message` field advises reducing the input size or decreasing the `max_tokens` value.<br/>
    /// For truncation cases, the partial output is in `result.data` (async) or `data` (sync). Check `finish_reason` instead of parsing the message text.
    /// </summary>
    public sealed partial class AnalyzeTaskError
    {
        /// <summary>
        /// A human-readable message. One of:<br/>
        /// - **Failure** (async, `status: failed`): describes the failure reason, e.g., `"Video duration exceeds maximum allowed duration"`.<br/>
        /// - **Truncation: maximum response length reached** (`finish_reason: length`, `output_tokens &gt;= max_tokens`): `"output truncated: the generation reached the configured max_tokens. The partial output is returned; raise max_tokens (up to 98304) if you need a longer response."`.<br/>
        /// - **Truncation: context window reached** (`finish_reason: length`, model stopped before reaching `max_tokens`): `"output truncated: combined input and output tokens reached the model's context limit. The partial output is returned; consider reducing input size (shorter prompt, smaller video clip, fewer media bindings) or lowering max_tokens."`.<br/>
        /// The exact text is not part of the contract — SDKs should not parse it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable message. One of:<br/>
        /// - **Failure** (async, `status: failed`): describes the failure reason, e.g., `"Video duration exceeds maximum allowed duration"`.<br/>
        /// - **Truncation: maximum response length reached** (`finish_reason: length`, `output_tokens &gt;= max_tokens`): `"output truncated: the generation reached the configured max_tokens. The partial output is returned; raise max_tokens (up to 98304) if you need a longer response."`.<br/>
        /// - **Truncation: context window reached** (`finish_reason: length`, model stopped before reaching `max_tokens`): `"output truncated: combined input and output tokens reached the model's context limit. The partial output is returned; consider reducing input size (shorter prompt, smaller video clip, fewer media bindings) or lowering max_tokens."`.<br/>
        /// The exact text is not part of the contract — SDKs should not parse it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskError" /> class.
        /// </summary>
        public AnalyzeTaskError()
        {
        }

    }
}