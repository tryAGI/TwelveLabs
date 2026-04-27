
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Request body for the Responses endpoint, following the [Open Responses](https://www.openresponses.org/specification) specification.
    /// </summary>
    public sealed partial class ResponseCreateRequest
    {
        /// <summary>
        /// The AI model to use for generating the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseCreateRequestModelJsonConverter))]
        public global::TwelveLabs.ResponseCreateRequestModel Model { get; set; }

        /// <summary>
        /// The unique identifier of the knowledge store this response reasons over.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeStoreId { get; set; }

        /// <summary>
        /// An array of input items following the [Open Responses input items](https://www.openresponses.org/reference#input-items) specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem> Input { get; set; }

        /// <summary>
        /// The session identifier for a multi-turn conversation. Pass the `session_id`<br/>
        /// returned from a previous response to continue that conversation. Omit to start<br/>
        /// a new session.<br/>
        /// When provided, `knowledge_store_id` must match the knowledge store the session<br/>
        /// was originally created against, or the request returns `400`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional guidance for the model, acting as a per-request system prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional fields to include in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseCreateRequestIncludeItems>? Include { get; set; }

        /// <summary>
        /// When `true`, the response is returned as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Controls the output text format for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::TwelveLabs.TextParam? Text { get; set; }

        /// <summary>
        /// Key-value pairs to attach to the request. Up to 16 pairs allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreateRequest" /> class.
        /// </summary>
        /// <param name="knowledgeStoreId">
        /// The unique identifier of the knowledge store this response reasons over.
        /// </param>
        /// <param name="input">
        /// An array of input items following the [Open Responses input items](https://www.openresponses.org/reference#input-items) specification.
        /// </param>
        /// <param name="model">
        /// The AI model to use for generating the response.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for a multi-turn conversation. Pass the `session_id`<br/>
        /// returned from a previous response to continue that conversation. Omit to start<br/>
        /// a new session.<br/>
        /// When provided, `knowledge_store_id` must match the knowledge store the session<br/>
        /// was originally created against, or the request returns `400`.
        /// </param>
        /// <param name="instructions">
        /// Additional guidance for the model, acting as a per-request system prompt.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in the response.
        /// </param>
        /// <param name="stream">
        /// When `true`, the response is returned as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// Controls the output text format for the response.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to attach to the request. Up to 16 pairs allowed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCreateRequest(
            string knowledgeStoreId,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem> input,
            global::TwelveLabs.ResponseCreateRequestModel model,
            string? sessionId,
            string? instructions,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseCreateRequestIncludeItems>? include,
            bool? stream,
            global::TwelveLabs.TextParam? text,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Model = model;
            this.KnowledgeStoreId = knowledgeStoreId ?? throw new global::System.ArgumentNullException(nameof(knowledgeStoreId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.SessionId = sessionId;
            this.Instructions = instructions;
            this.Include = include;
            this.Stream = stream;
            this.Text = text;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreateRequest" /> class.
        /// </summary>
        public ResponseCreateRequest()
        {
        }
    }
}