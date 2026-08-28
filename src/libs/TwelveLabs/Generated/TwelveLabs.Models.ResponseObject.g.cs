
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The response object.
    /// </summary>
    public sealed partial class ResponseObject
    {
        /// <summary>
        /// A unique identifier for this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier of the knowledge store this response was generated against.
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
        /// The object type, always `response`. Carries the same value as `type`, which<br/>
        /// predates it and which the Open Responses specification does not name.<br/>
        /// Both fields are permanent; neither will be removed. Read whichever your client<br/>
        /// already uses.<br/>
        /// This is the only object with an `object` field. Output items, annotations and<br/>
        /// stream events are keyed on `type` alone, so do not expect `object` one level<br/>
        /// down.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseObjectObjectJsonConverter))]
        public global::TwelveLabs.ResponseObjectObject? Object { get; set; }

        /// <summary>
        /// The status. For the meaning of each value, see the<br/>
        /// [Response statuses](/v1.3/api-reference/responses/the-response-object#response-statuses)<br/>
        /// section on **The response object** page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter))]
        public global::TwelveLabs.ResponseStatus? Status { get; set; }

        /// <summary>
        /// Why the response stopped before the answer was whole. Always sent. Non-null only<br/>
        /// when `status` is `incomplete`; `null` on every other status, including<br/>
        /// `in_progress` and `failed` — so `null` means "this answer was not truncated",<br/>
        /// not "this platform does not report the reason".<br/>
        /// A `null` on `status: failed` is not a claim that nothing went wrong. This field<br/>
        /// reports truncation only; a failure is reported by the status itself.<br/>
        /// Values may be added to `reason` as new ways of truncating an answer are<br/>
        /// reported. Treat an unrecognized `reason` as "truncated for a reason this client<br/>
        /// does not know" rather than as an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.ResponseIncompleteDetails, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.ResponseIncompleteDetails, object>? IncompleteDetails { get; set; }

        /// <summary>
        /// The response output items. By default, only the final message is included.<br/>
        /// Set `include` to `["intermediate_outputs"]` in the request to receive function call items.
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
        /// The unique identifier of the knowledge store this response was generated against.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for this conversation. Pass this value in subsequent requests to continue<br/>
        /// the multi-turn conversation.
        /// </param>
        /// <param name="type">
        /// The object type. Always `response`.
        /// </param>
        /// <param name="object">
        /// The object type, always `response`. Carries the same value as `type`, which<br/>
        /// predates it and which the Open Responses specification does not name.<br/>
        /// Both fields are permanent; neither will be removed. Read whichever your client<br/>
        /// already uses.<br/>
        /// This is the only object with an `object` field. Output items, annotations and<br/>
        /// stream events are keyed on `type` alone, so do not expect `object` one level<br/>
        /// down.
        /// </param>
        /// <param name="status">
        /// The status. For the meaning of each value, see the<br/>
        /// [Response statuses](/v1.3/api-reference/responses/the-response-object#response-statuses)<br/>
        /// section on **The response object** page.
        /// </param>
        /// <param name="incompleteDetails">
        /// Why the response stopped before the answer was whole. Always sent. Non-null only<br/>
        /// when `status` is `incomplete`; `null` on every other status, including<br/>
        /// `in_progress` and `failed` — so `null` means "this answer was not truncated",<br/>
        /// not "this platform does not report the reason".<br/>
        /// A `null` on `status: failed` is not a claim that nothing went wrong. This field<br/>
        /// reports truncation only; a failure is reported by the status itself.<br/>
        /// Values may be added to `reason` as new ways of truncating an answer are<br/>
        /// reported. Treat an unrecognized `reason` as "truncated for a reason this client<br/>
        /// does not know" rather than as an error.
        /// </param>
        /// <param name="output">
        /// The response output items. By default, only the final message is included.<br/>
        /// Set `include` to `["intermediate_outputs"]` in the request to receive function call items.
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
            global::TwelveLabs.ResponseObjectObject? @object,
            global::TwelveLabs.ResponseStatus? status,
            global::TwelveLabs.OneOf<global::TwelveLabs.ResponseIncompleteDetails, object>? incompleteDetails,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputItem>? output,
            global::TwelveLabs.ResponseUsage? usage,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.KnowledgeStoreId = knowledgeStoreId;
            this.SessionId = sessionId;
            this.Type = type;
            this.Object = @object;
            this.Status = status;
            this.IncompleteDetails = incompleteDetails;
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