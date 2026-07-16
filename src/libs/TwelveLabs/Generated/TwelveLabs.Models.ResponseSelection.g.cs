
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A reference to a specific knowledge store item or item collection to include in the request.
    /// </summary>
    public sealed partial class ResponseSelection
    {
        /// <summary>
        /// The type of resource to select.<br/>
        /// **Values**:<br/>
        /// - `item`: A single knowledge store item.<br/>
        /// - `collection`: A knowledge store item collection. All items in the collection are included in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseSelectionKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseSelectionKind Kind { get; set; }

        /// <summary>
        /// The unique identifier of the selected resource. Must use the prefix that matches the `kind` field:<br/>
        /// `ksi_` for items and `ksic_` for collections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSelection" /> class.
        /// </summary>
        /// <param name="kind">
        /// The type of resource to select.<br/>
        /// **Values**:<br/>
        /// - `item`: A single knowledge store item.<br/>
        /// - `collection`: A knowledge store item collection. All items in the collection are included in the request.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the selected resource. Must use the prefix that matches the `kind` field:<br/>
        /// `ksi_` for items and `ksic_` for collections.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSelection(
            global::TwelveLabs.ResponseSelectionKind kind,
            string id)
        {
            this.Kind = kind;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSelection" /> class.
        /// </summary>
        public ResponseSelection()
        {
        }

    }
}