
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStreamRequest
    {
        /// <summary>
        /// The unique identifier of the knowledge store to reason over.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeStoreId { get; set; }

        /// <summary>
        /// Provides context to Jockey for this request. Uses [Open Responses input item](https://www.openresponses.org/reference#input-items) conventions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem> Input { get; set; }

        /// <summary>
        /// The session identifier for a multi-turn conversation. Pass the session identifier<br/>
        /// returned from a previous response to continue that conversation. Omit to start<br/>
        /// a new session.<br/>
        /// When provided, the `knowledge_store_id` field must match the knowledge store the session<br/>
        /// was originally created against, or the request returns `400`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional guidance for Jockey, acting as a per-request system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional items to include in the response's `output` array. By default, the `output` array contains only Jockey's final reply.<br/>
        /// **Values**:<br/>
        /// - `intermediate_outputs`: Also includes the steps Jockey took to produce the reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? Include { get; set; }

        /// <summary>
        /// When `true`, the response is returned as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Stream { get; set; }

        /// <summary>
        /// Restricts the request to specific knowledge store items or item collections. The restriction is applied at the prompt level; the knowledge store does not block access to other items. Treat it as a strong preference, not a hard access boundary. Omit to run against every item.<br/>
        /// Selections persist in the session context, and selections sent on later turns are added to that context. You can reference selections from earlier turns in natural language without repeating their `{{sel:N}}` tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selections")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? Selections { get; set; }

        /// <summary>
        /// Controls the output text format for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::TwelveLabs.TextParam? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamRequest" /> class.
        /// </summary>
        /// <param name="knowledgeStoreId">
        /// The unique identifier of the knowledge store to reason over.
        /// </param>
        /// <param name="input">
        /// Provides context to Jockey for this request. Uses [Open Responses input item](https://www.openresponses.org/reference#input-items) conventions.
        /// </param>
        /// <param name="stream">
        /// When `true`, the response is returned as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE).
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for a multi-turn conversation. Pass the session identifier<br/>
        /// returned from a previous response to continue that conversation. Omit to start<br/>
        /// a new session.<br/>
        /// When provided, the `knowledge_store_id` field must match the knowledge store the session<br/>
        /// was originally created against, or the request returns `400`.
        /// </param>
        /// <param name="instructions">
        /// Additional guidance for Jockey, acting as a per-request system prompt.
        /// </param>
        /// <param name="include">
        /// Additional items to include in the response's `output` array. By default, the `output` array contains only Jockey's final reply.<br/>
        /// **Values**:<br/>
        /// - `intermediate_outputs`: Also includes the steps Jockey took to produce the reply.
        /// </param>
        /// <param name="selections">
        /// Restricts the request to specific knowledge store items or item collections. The restriction is applied at the prompt level; the knowledge store does not block access to other items. Treat it as a strong preference, not a hard access boundary. Omit to run against every item.<br/>
        /// Selections persist in the session context, and selections sent on later turns are added to that context. You can reference selections from earlier turns in natural language without repeating their `{{sel:N}}` tokens.
        /// </param>
        /// <param name="text">
        /// Controls the output text format for the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStreamRequest(
            string knowledgeStoreId,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem> input,
            bool stream,
            string? sessionId,
            string? instructions,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? include,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? selections,
            global::TwelveLabs.TextParam? text)
        {
            this.KnowledgeStoreId = knowledgeStoreId ?? throw new global::System.ArgumentNullException(nameof(knowledgeStoreId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.SessionId = sessionId;
            this.Instructions = instructions;
            this.Include = include;
            this.Stream = stream;
            this.Selections = selections;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamRequest" /> class.
        /// </summary>
        public CreateStreamRequest()
        {
        }

    }
}