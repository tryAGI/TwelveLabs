
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A message, function call, or function result in the response output.
    /// </summary>
    public sealed partial class ResponseOutputItemVariant3
    {
        /// <summary>
        /// The type of output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStandardOutputItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStandardOutputItemType Type { get; set; }

        /// <summary>
        /// An identifier for this item within the response. Examples include<br/>
        /// `msg_0` for a message, `fc_1` for a function call, and `fco_2` for a function result.<br/>
        /// Use the `type` field to identify the item kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The lifecycle status of the output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStandardOutputItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStandardOutputItemStatus Status { get; set; }

        /// <summary>
        /// The role of the message author. Present when `type` is `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStandardOutputItemRoleJsonConverter))]
        public global::TwelveLabs.ResponseStandardOutputItemRole? Role { get; set; }

        /// <summary>
        /// Which part of the turn this message contains. Present when `type` is<br/>
        /// `message`. The `commentary` value identifies an intermediate message,<br/>
        /// and `final_answer` identifies the answer.<br/>
        /// Treat a message without `phase` as the final answer. Treat an<br/>
        /// unrecognized value as intermediate output, not as the answer.<br/>
        /// Intermediate messages are included only with the deprecated<br/>
        /// `include: ["intermediate_outputs"]` option. By default, output contains<br/>
        /// the answer only.<br/>
        /// Activity summaries use the separate `jockey:activity` stream event type and<br/>
        /// do not have a message phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public string? Phase { get; set; }

        /// <summary>
        /// The content parts of the message. Present when `type` is `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? Content { get; set; }

        /// <summary>
        /// The name of the function. Present when `type` is `function_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The unique identifier for the function call. Present when `type` is `function_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The JSON-encoded arguments for the function call. Present when `type` is `function_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The function call output. Present when `type` is `function_call_output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of output item.
        /// </param>
        /// <param name="id">
        /// An identifier for this item within the response. Examples include<br/>
        /// `msg_0` for a message, `fc_1` for a function call, and `fco_2` for a function result.<br/>
        /// Use the `type` field to identify the item kind.
        /// </param>
        /// <param name="status">
        /// The lifecycle status of the output item.
        /// </param>
        /// <param name="role">
        /// The role of the message author. Present when `type` is `message`.
        /// </param>
        /// <param name="phase">
        /// Which part of the turn this message contains. Present when `type` is<br/>
        /// `message`. The `commentary` value identifies an intermediate message,<br/>
        /// and `final_answer` identifies the answer.<br/>
        /// Treat a message without `phase` as the final answer. Treat an<br/>
        /// unrecognized value as intermediate output, not as the answer.<br/>
        /// Intermediate messages are included only with the deprecated<br/>
        /// `include: ["intermediate_outputs"]` option. By default, output contains<br/>
        /// the answer only.<br/>
        /// Activity summaries use the separate `jockey:activity` stream event type and<br/>
        /// do not have a message phase.
        /// </param>
        /// <param name="content">
        /// The content parts of the message. Present when `type` is `message`.
        /// </param>
        /// <param name="name">
        /// The name of the function. Present when `type` is `function_call`.
        /// </param>
        /// <param name="callId">
        /// The unique identifier for the function call. Present when `type` is `function_call`.
        /// </param>
        /// <param name="arguments">
        /// The JSON-encoded arguments for the function call. Present when `type` is `function_call`.
        /// </param>
        /// <param name="output">
        /// The function call output. Present when `type` is `function_call_output`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputItemVariant3(
            global::TwelveLabs.ResponseStandardOutputItemType type,
            string id,
            global::TwelveLabs.ResponseStandardOutputItemStatus status,
            global::TwelveLabs.ResponseStandardOutputItemRole? role,
            string? phase,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseOutputContentPart>? content,
            string? name,
            string? callId,
            string? arguments,
            string? output)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Role = role;
            this.Phase = phase;
            this.Content = content;
            this.Name = name;
            this.CallId = callId;
            this.Arguments = arguments;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemVariant3" /> class.
        /// </summary>
        public ResponseOutputItemVariant3()
        {
        }

    }
}