
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to specific items in the knowledge store.<br/>
    /// Filter by type of item (the `asset_type` field), by specific items (the `item_id` field), or by capture location (the `location` field). For `asset_type` and `item_id`, use `eq` to match a single value or `in` to match any value in a list. For `location`, provide the center and radius of a circle. When you specify multiple fields, the platform applies all conditions together.<br/>
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
    /// ```json<br/>
    /// {<br/>
    ///     "location": {<br/>
    ///         "latitude": 37.5665,<br/>
    ///         "longitude": 126.978,<br/>
    ///         "radius_meters": 5000<br/>
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
        /// Narrows results to items captured within a circle. An item matches when the GPS coordinates embedded in its source media are within `radius_meters` of the center, measured as &lt;a href="https://en.wikipedia.org/wiki/Great-circle_distance" target="_blank"&gt;great-circle distance&lt;/a&gt;. Items with no coordinates never match. To read the GPS coordinates of the source media, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint. The coordinates are the `geospatial_latitude` and `geospatial_longitude` fields of the `technical_metadata` object.<br/>
        /// If the circle matches more than 10,000 items, the platform returns a `422` error with the `metadata_filter_too_broad` code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::TwelveLabs.GeoCircleFilter? Location { get; set; }

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
        /// <param name="location">
        /// Narrows results to items captured within a circle. An item matches when the GPS coordinates embedded in its source media are within `radius_meters` of the center, measured as &lt;a href="https://en.wikipedia.org/wiki/Great-circle_distance" target="_blank"&gt;great-circle distance&lt;/a&gt;. Items with no coordinates never match. To read the GPS coordinates of the source media, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint. The coordinates are the `geospatial_latitude` and `geospatial_longitude` fields of the `technical_metadata` object.<br/>
        /// If the circle matches more than 10,000 items, the platform returns a `422` error with the `metadata_filter_too_broad` code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreFilter(
            global::TwelveLabs.AssetTypeFilter? assetType,
            global::TwelveLabs.ItemIdFilter? itemId,
            global::TwelveLabs.GeoCircleFilter? location)
        {
            this.AssetType = assetType;
            this.ItemId = itemId;
            this.Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreFilter" /> class.
        /// </summary>
        public SearchKnowledgeStoreFilter()
        {
        }

    }
}