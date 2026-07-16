
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to specific items in the knowledge store.<br/>
    /// Filter by type of item (the `asset_type` field) or by specific identifiers (the `item_id` field). Use `eq` to match a single value or `in` to match any value in a list. When you specify multiple fields, the platform applies all conditions together.<br/>
    /// Examples:<br/>
    /// ```json<br/>
    /// {<br/>
    ///     "asset_type": {<br/>
    ///         "eq": "video"<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// ```json<br/>
    /// {<br/>
    ///     "asset_type": {<br/>
    ///         "in": [<br/>
    ///             "video"<br/>
    ///         ]<br/>
    ///     },<br/>
    ///     "item_id": {<br/>
    ///         "in": [<br/>
    ///             "ksi_069e9870-3c4d-7abc-9012-3456789abcde"<br/>
    ///         ]<br/>
    ///     }<br/>
    /// }<br/>
    /// ```<br/>
    /// Omit the filter to search all items.
    /// </summary>
    public sealed partial class SearchKnowledgeStoreFilter
    {
        /// <summary>
        /// Narrows results by type of item. Provide exactly one operator: `eq` to match one type, or `in` to match any of the listed types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_type")]
        public global::TwelveLabs.AssetTypeFilter? AssetType { get; set; }

        /// <summary>
        /// Narrows results to specific items. Provide exactly one operator: `eq` to match one item, or `in` to match any of the listed items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public global::TwelveLabs.ItemIdFilter? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreFilter" /> class.
        /// </summary>
        /// <param name="assetType">
        /// Narrows results by type of item. Provide exactly one operator: `eq` to match one type, or `in` to match any of the listed types.
        /// </param>
        /// <param name="itemId">
        /// Narrows results to specific items. Provide exactly one operator: `eq` to match one item, or `in` to match any of the listed items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreFilter(
            global::TwelveLabs.AssetTypeFilter? assetType,
            global::TwelveLabs.ItemIdFilter? itemId)
        {
            this.AssetType = assetType;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreFilter" /> class.
        /// </summary>
        public SearchKnowledgeStoreFilter()
        {
        }

    }
}