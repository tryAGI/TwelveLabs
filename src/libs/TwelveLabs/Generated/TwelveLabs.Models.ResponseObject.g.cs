
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The response object, following the [Open Responses](https://www.openresponses.org/specification) specification.
    /// </summary>
    public sealed partial class ResponseObject
    {
        /// <summary>
        /// A unique identifier for this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The knowledge store this response was generated against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_store_id")]
        public string? KnowledgeStoreId { get; set; }

        /// <summary>
        /// The session identifier for this conversation. Pass this value in subsequent requests to continue<br/>
        /// the multi-turn conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The object type. Always `response`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseObjectTypeJsonConverter))]
        public global::TwelveLabs.ResponseObjectType? Type { get; set; }

        /// <summary>
        /// The status of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter))]
        public global::TwelveLabs.ResponseStatus? Status { get; set; }

        /// <summary>
        /// The model used for this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The response output items. By default, only the final message is included.<br/>
        /// Set `include` to `["intermediate_outputs"]` in the request to also receive function call items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? Output { get; set; }

        /// <summary>
        /// Token usage statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::TwelveLabs.ResponseUsage? Usage { get; set; }

        /// <summary>
        /// The timestamp when the response was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObject" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for this response.
        /// </param>
        /// <param name="knowledgeStoreId">
        /// The knowledge store this response was generated against.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for this conversation. Pass this value in subsequent requests to continue<br/>
        /// the multi-turn conversation.
        /// </param>
        /// <param name="type">
        /// The object type. Always `response`.
        /// </param>
        /// <param name="status">
        /// The status of the response.
        /// </param>
        /// <param name="model">
        /// The model used for this response.
        /// </param>
        /// <param name="output">
        /// The response output items. By default, only the final message is included.<br/>
        /// Set `include` to `["intermediate_outputs"]` in the request to also receive function call items.
        /// </param>
        /// <param name="usage">
        /// Token usage statistics.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the response was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseObject(
            string? id,
            string? knowledgeStoreId,
            string? sessionId,
            global::TwelveLabs.ResponseObjectType? type,
            global::TwelveLabs.ResponseStatus? status,
            string? model,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? output,
            global::TwelveLabs.ResponseUsage? usage,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.KnowledgeStoreId = knowledgeStoreId;
            this.SessionId = sessionId;
            this.Type = type;
            this.Status = status;
            this.Model = model;
            this.Output = output;
            this.Usage = usage;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObject" /> class.
        /// </summary>
        public ResponseObject()
        {
        }
    }
}