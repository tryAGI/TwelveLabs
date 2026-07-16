
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An input item using [Open Responses input item](https://www.openresponses.org/reference#input-items) conventions.
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
        /// The role of the message author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseInputItemRoleJsonConverter))]
        public global::TwelveLabs.ResponseInputItemRole Role { get; set; }

        /// <summary>
        /// The message text, as a plain string. Must be between 1 and 10,000 characters.<br/>
        /// To narrow the message to a specific knowledge store item or item collection, include a `{{sel:N}}` token in the content, where `N` is the zero-based position in the `selections` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputItem" /> class.
        /// </summary>
        /// <param name="content">
        /// The message text, as a plain string. Must be between 1 and 10,000 characters.<br/>
        /// To narrow the message to a specific knowledge store item or item collection, include a `{{sel:N}}` token in the content, where `N` is the zero-based position in the `selections` array.
        /// </param>
        /// <param name="type">
        /// The type of input item.
        /// </param>
        /// <param name="role">
        /// The role of the message author.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseInputItem(
            string content,
            global::TwelveLabs.ResponseInputItemType type,
            global::TwelveLabs.ResponseInputItemRole role)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputItem" /> class.
        /// </summary>
        public ResponseInputItem()
        {
        }

    }
}