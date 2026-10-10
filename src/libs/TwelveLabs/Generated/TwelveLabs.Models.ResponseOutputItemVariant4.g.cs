
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A web-search call that Jockey ran, with its status and available action details.<br/>
    /// These items appear only with `include: ["intermediate_outputs"]` in the request.<br/>
    /// The `jockey:web_search` type follows the [Open Responses extension naming convention](https://www.openresponses.org/specification#extending-tools).<br/>
    /// Use this type in request `tools` to enable search. In response `output`, it identifies one call.<br/>
    /// If the response fails, the call keeps its last reported status. Response failure does not imply call completion.<br/>
    /// This item does not contain retrieved page contents or a separate search-results payload.<br/>
    /// Web sources cited by the answer appear in the message's `content[].annotations`.<br/>
    /// Use `session_id` to continue a conversation; this output item is not accepted in `input`.
    /// </summary>
    public sealed partial class ResponseOutputItemVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseWebSearchOutputItemTypeJsonConverter))]
        public global::TwelveLabs.ResponseWebSearchOutputItemType Type { get; set; }

        /// <summary>
        /// A `ws_`-prefixed identifier for this call within the response.<br/>
        /// The same identifier appears in the call's streaming events and the final response.<br/>
        /// IDs can repeat across responses. Use `output_index`, not the ID suffix, to locate an item in `output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The last reported status of the call, or `null` when unavailable.<br/>
        /// Treat `null` or an unrecognized value as an unknown status. Neither confirms that the call completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Details of the action, or `null` when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::TwelveLabs.WebSearchAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemVariant4" /> class.
        /// </summary>
        /// <param name="id">
        /// A `ws_`-prefixed identifier for this call within the response.<br/>
        /// The same identifier appears in the call's streaming events and the final response.<br/>
        /// IDs can repeat across responses. Use `output_index`, not the ID suffix, to locate an item in `output`.
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// The last reported status of the call, or `null` when unavailable.<br/>
        /// Treat `null` or an unrecognized value as an unknown status. Neither confirms that the call completed.
        /// </param>
        /// <param name="action">
        /// Details of the action, or `null` when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputItemVariant4(
            string id,
            global::TwelveLabs.ResponseWebSearchOutputItemType type,
            string? status,
            global::TwelveLabs.WebSearchAction? action)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemVariant4" /> class.
        /// </summary>
        public ResponseOutputItemVariant4()
        {
        }

    }
}