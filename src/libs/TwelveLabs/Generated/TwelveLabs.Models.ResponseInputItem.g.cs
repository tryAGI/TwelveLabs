
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An input item following the Open Responses specification. Currently supports the `message` type.
    /// </summary>
    public sealed partial class ResponseInputItem
    {
        /// <summary>
        /// The type of input item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseInputItemTypeJsonConverter))]
        public global::TwelveLabs.ResponseInputItemType Type { get; set; }

        /// <summary>
        /// The role of the message author. Only `user` is currently supported.<br/>
        /// Additional roles may be added in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseInputItemRoleJsonConverter))]
        public global::TwelveLabs.ResponseInputItemRole? Role { get; set; }

        /// <summary>
        /// The message content as a plain text string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of input item.
        /// </param>
        /// <param name="role">
        /// The role of the message author. Only `user` is currently supported.<br/>
        /// Additional roles may be added in the future.
        /// </param>
        /// <param name="content">
        /// The message content as a plain text string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseInputItem(
            global::TwelveLabs.ResponseInputItemType type,
            global::TwelveLabs.ResponseInputItemRole? role,
            string? content)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputItem" /> class.
        /// </summary>
        public ResponseInputItem()
        {
        }
    }
}