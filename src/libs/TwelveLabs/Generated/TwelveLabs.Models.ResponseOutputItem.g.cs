
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An item in the response output. Items are polymorphic and discriminated by the `type` field.
    /// </summary>
    public sealed partial class ResponseOutputItem
    {
        /// <summary>
        /// The type of output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseOutputItemType Type { get; set; }

        /// <summary>
        /// A unique identifier for this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStatus Status { get; set; }

        /// <summary>
        /// The role of the message author. Present when `type` is `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseOutputItemRoleJsonConverter))]
        public global::TwelveLabs.ResponseOutputItemRole? Role { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseOutputItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of output item.
        /// </param>
        /// <param name="id">
        /// A unique identifier for this item.
        /// </param>
        /// <param name="status">
        /// The status of the response.
        /// </param>
        /// <param name="role">
        /// The role of the message author. Present when `type` is `message`.
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
        public ResponseOutputItem(
            global::TwelveLabs.ResponseOutputItemType type,
            string id,
            global::TwelveLabs.ResponseStatus status,
            global::TwelveLabs.ResponseOutputItemRole? role,
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
            this.Content = content;
            this.Name = name;
            this.CallId = callId;
            this.Arguments = arguments;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItem" /> class.
        /// </summary>
        public ResponseOutputItem()
        {
        }
    }
}