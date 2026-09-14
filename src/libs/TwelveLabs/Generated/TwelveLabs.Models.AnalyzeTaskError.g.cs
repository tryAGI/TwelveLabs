
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A message attached to an analysis response. The platform uses this object in the following cases:<br/>
    /// - **Task failure** — set on `AnalyzeTaskResponse.error` when `status` is `failed`. The `message` field describes the failure.<br/>
    /// - **Truncation warning (general analysis)** — set on the response `error` when `finish_reason` is `length`, because either `output_tokens` reached the requested `max_tokens` value or the input and response reached the [context window](/v1.3/docs/concepts/models/pegasus#context-window). To obtain the full output, increase the `max_tokens` value or reduce the input size. The partial output is in `result.data` for asynchronous analysis and in `data` for synchronous analysis.<br/>
    /// - With general analysis, check `finish_reason` instead of parsing the message text. With video segmentation, check `status`.
    /// </summary>
    public sealed partial class AnalyzeTaskError
    {
        /// <summary>
        /// A human-readable message. One of:<br/>
        /// - **Other failures** (async, `status: failed`): the message describes the failure reason. Example: `"Video duration exceeds maximum allowed duration"`.<br/>
        /// - **Failure: maximum response length reached** (`time_based_metadata`, `status: failed`): `"analysis failed: the time_based_metadata output reached the configured max_tokens before a complete result was produced. Raise max_tokens if it is below the per-model maximum; otherwise narrow the request (fewer segment_definitions or fields, a larger min_segment_duration, or a shorter analysis window)."`.<br/>
        /// - **Failure: context window reached** (`time_based_metadata`, `status: failed`): `"analysis failed: the time_based_metadata output reached the model's context limit (combined input and output tokens) before a complete result was produced. Narrow the request (fewer segment_definitions or fields, a larger min_segment_duration, a shorter analysis window, fewer media bindings) or lower max_tokens to leave more room for the input."`.<br/>
        /// - **Truncation: maximum response length reached** (`general`, `finish_reason: length`, `output_tokens &gt;= max_tokens`): `"output truncated: the generation reached the configured max_tokens. The partial output is returned; raise max_tokens if you need a longer response."`.<br/>
        /// - **Truncation: context window reached** (`general`, `finish_reason: length`, model stopped before reaching `max_tokens`): `"output truncated: combined input and output tokens reached the model's context limit. The partial output is returned; consider reducing input size (shorter prompt, smaller video clip, fewer media bindings) or lowering max_tokens."`.<br/>
        /// The exact text is not part of the contract. Do not parse it.
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
        /// - **Other failures** (async, `status: failed`): the message describes the failure reason. Example: `"Video duration exceeds maximum allowed duration"`.<br/>
        /// - **Failure: maximum response length reached** (`time_based_metadata`, `status: failed`): `"analysis failed: the time_based_metadata output reached the configured max_tokens before a complete result was produced. Raise max_tokens if it is below the per-model maximum; otherwise narrow the request (fewer segment_definitions or fields, a larger min_segment_duration, or a shorter analysis window)."`.<br/>
        /// - **Failure: context window reached** (`time_based_metadata`, `status: failed`): `"analysis failed: the time_based_metadata output reached the model's context limit (combined input and output tokens) before a complete result was produced. Narrow the request (fewer segment_definitions or fields, a larger min_segment_duration, a shorter analysis window, fewer media bindings) or lower max_tokens to leave more room for the input."`.<br/>
        /// - **Truncation: maximum response length reached** (`general`, `finish_reason: length`, `output_tokens &gt;= max_tokens`): `"output truncated: the generation reached the configured max_tokens. The partial output is returned; raise max_tokens if you need a longer response."`.<br/>
        /// - **Truncation: context window reached** (`general`, `finish_reason: length`, model stopped before reaching `max_tokens`): `"output truncated: combined input and output tokens reached the model's context limit. The partial output is returned; consider reducing input size (shorter prompt, smaller video clip, fewer media bindings) or lowering max_tokens."`.<br/>
        /// The exact text is not part of the contract. Do not parse it.
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