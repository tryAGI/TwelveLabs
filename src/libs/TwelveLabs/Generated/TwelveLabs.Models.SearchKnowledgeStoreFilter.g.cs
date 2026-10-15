
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to specific items in the knowledge store. Omit the filter to search all items.<br/>
    /// You can filter with these fields:<br/>
    /// - `asset_type`: The type of item. Use `eq` to match one type. Use `in` to match any type in a list.<br/>
    /// - `item_id`: Specific items. Use `eq` to match one item. Use `in` to match any item in a list.<br/>
    /// - `user_metadata`: Custom metadata. Map each key to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
    /// - `enrichment`: Enrichment values that the platform extracts. Map each key to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
    /// - `created_at`: Creation time. Use `gte` to set the earliest time and `lte` to set the latest time. You can use one or both.<br/>
    /// - `location`: Capture location. Provide the center and the radius of a circle.<br/>
    /// - `tags`: Item tags. Map each key under `tags.metadata` to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
    /// An item must match all of the fields that you specify. The `tags` field also limits which clips of an item the search returns.<br/>
    /// When you use any of the `user_metadata`, `enrichment`, `created_at`, or `location` fields, the platform counts the items that match those conditions together. If more than 10,000 items match, the platform returns a `422` error with the `metadata_filter_too_broad` code. To reduce the count, add conditions or use the `item_id` field. The `asset_type` field does not reduce the count. When you use the `tags` field, the platform does not count items, and this limit does not apply. It counts the matching tags instead, as the `tags` field describes.<br/>
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
    ///     "user_metadata": {<br/>
    ///         "category": {<br/>
    ///             "eq": "tutorial"<br/>
    ///         }<br/>
    ///     },<br/>
    ///     "created_at": {<br/>
    ///         "gte": "2026-09-01T00:00:00Z"<br/>
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
    /// ```json<br/>
    /// {<br/>
    ///     "tags": {<br/>
    ///         "metadata": {<br/>
    ///             "event": {<br/>
    ///                 "eq": "goal"<br/>
    ///             }<br/>
    ///         }<br/>
    ///     }<br/>
    /// }<br/>
    /// ```
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
        /// Narrows results by custom metadata. Map each key to an object with exactly one of the `eq` or `in` operators. You can specify 1 to 50 keys. An item must match all of the keys that you specify.<br/>
        /// A key matches the custom metadata of the source asset (the `metadata` field of the knowledge store item) and the custom metadata of the knowledge store item (the `item_metadata` field). An item matches a key when the value matches in either field. For the names of these fields in search results, see the [Custom metadata field names](/v1.3/api-reference/knowledge-store-items/the-knowledge-store-item-object#custom-metadata-field-names) section on **The knowledge store item object** page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? UserMetadata { get; set; }

        /// <summary>
        /// Narrows results by enrichment values. The platform extracts these values as the enrichment configuration of the knowledge store defines (the `ingestion_config.enrichment_config` field).<br/>
        /// Map each top-level property that the enrichment configuration defines to an object with exactly one of the `eq` or `in` operators. You can specify 1 to 50 keys. If you specify a key that the enrichment configuration does not define, the platform returns a `400` error.<br/>
        /// The `granularity` keyword of a property sets how often the platform extracts its value. The keyword also sets which items the key matches:<br/>
        /// - `video`: One value for each video. The key matches video items only.<br/>
        /// - `image`: One value for each image. The key matches image items only.<br/>
        /// - `shot`: One value for each shot of a video. A shot is a continuous part of a video between two scene changes. The key matches video items only. If you specify more than one `shot` key, one shot must have all of the values. For example, a filter with the keys `topic` and `sentiment` at the `shot` granularity matches a video only when one shot has both values.<br/>
        /// An item must match all of the keys that you specify. A filter with a `video` key and an `image` key matches no items, because an item is a video or an image.<br/>
        /// Use the filter to choose which items to search. The search can return any clip of a matching item, including clips that do not match the filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? Enrichment { get; set; }

        /// <summary>
        /// Narrows results by the creation time of the item. Use `gte` to set the earliest time and `lte` to set the latest time. You can use one or both. When you use both, the `gte` time must be equal to or earlier than the `lte` time.<br/>
        /// The creation time is the time when you create the item with the [`POST`](/v1.3/api-reference/knowledge-store-items/create) method of the `/knowledge-stores/{knowledge_store_id}/items` endpoint. It is not the time when the item reaches the `ready` status. To read the creation time of an item, use the [`GET`](/v1.3/api-reference/knowledge-store-items/retrieve) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint. The time is in the `created_at` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::TwelveLabs.CreatedAtFilter? CreatedAt { get; set; }

        /// <summary>
        /// Narrows results to items captured within a circle. An item matches when the GPS coordinates embedded in its source media are within `radius_meters` of the center, measured as &lt;a href="https://en.wikipedia.org/wiki/Great-circle_distance" target="_blank"&gt;great-circle distance&lt;/a&gt;. Items with no coordinates never match. To read the GPS coordinates of the source media, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint. The coordinates are the `geospatial_latitude` and `geospatial_longitude` fields of the `technical_metadata` object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::TwelveLabs.GeoCircleFilter? Location { get; set; }

        /// <summary>
        /// Narrows results to the moments and ranges that matching tags mark on video items. A tag matches when its `tag_metadata` field matches the `metadata` field. Only video items have tags, so images do not appear in the results.<br/>
        /// The search returns only the clips within a matching tag:<br/>
        /// - For a tag on a range, a clip matches when it lies entirely within the range. A clip that extends past either end of the range does not appear in the results.<br/>
        /// - For a tag on a single moment, a clip matches when it contains that moment.<br/>
        /// A clip within more than one matching tag appears once. With the `group_by` parameter set to `item`, each item groups only its clips within matching tags. When you specify other fields of the filter, a tag counts only when its item matches every other field. The `asset_type` field does not reduce the count. If more than 100 tags match, the platform returns a `422` error with the `metadata_filter_too_broad` code.<br/>
        /// To tag a moment or a range of a video item, use the [`POST`](/v1.3/api-reference/knowledge-store-items/item-tags/create) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/tags` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::TwelveLabs.TagFilter? Tags { get; set; }

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
        /// <param name="userMetadata">
        /// Narrows results by custom metadata. Map each key to an object with exactly one of the `eq` or `in` operators. You can specify 1 to 50 keys. An item must match all of the keys that you specify.<br/>
        /// A key matches the custom metadata of the source asset (the `metadata` field of the knowledge store item) and the custom metadata of the knowledge store item (the `item_metadata` field). An item matches a key when the value matches in either field. For the names of these fields in search results, see the [Custom metadata field names](/v1.3/api-reference/knowledge-store-items/the-knowledge-store-item-object#custom-metadata-field-names) section on **The knowledge store item object** page.
        /// </param>
        /// <param name="enrichment">
        /// Narrows results by enrichment values. The platform extracts these values as the enrichment configuration of the knowledge store defines (the `ingestion_config.enrichment_config` field).<br/>
        /// Map each top-level property that the enrichment configuration defines to an object with exactly one of the `eq` or `in` operators. You can specify 1 to 50 keys. If you specify a key that the enrichment configuration does not define, the platform returns a `400` error.<br/>
        /// The `granularity` keyword of a property sets how often the platform extracts its value. The keyword also sets which items the key matches:<br/>
        /// - `video`: One value for each video. The key matches video items only.<br/>
        /// - `image`: One value for each image. The key matches image items only.<br/>
        /// - `shot`: One value for each shot of a video. A shot is a continuous part of a video between two scene changes. The key matches video items only. If you specify more than one `shot` key, one shot must have all of the values. For example, a filter with the keys `topic` and `sentiment` at the `shot` granularity matches a video only when one shot has both values.<br/>
        /// An item must match all of the keys that you specify. A filter with a `video` key and an `image` key matches no items, because an item is a video or an image.<br/>
        /// Use the filter to choose which items to search. The search can return any clip of a matching item, including clips that do not match the filter.
        /// </param>
        /// <param name="createdAt">
        /// Narrows results by the creation time of the item. Use `gte` to set the earliest time and `lte` to set the latest time. You can use one or both. When you use both, the `gte` time must be equal to or earlier than the `lte` time.<br/>
        /// The creation time is the time when you create the item with the [`POST`](/v1.3/api-reference/knowledge-store-items/create) method of the `/knowledge-stores/{knowledge_store_id}/items` endpoint. It is not the time when the item reaches the `ready` status. To read the creation time of an item, use the [`GET`](/v1.3/api-reference/knowledge-store-items/retrieve) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint. The time is in the `created_at` field.
        /// </param>
        /// <param name="location">
        /// Narrows results to items captured within a circle. An item matches when the GPS coordinates embedded in its source media are within `radius_meters` of the center, measured as &lt;a href="https://en.wikipedia.org/wiki/Great-circle_distance" target="_blank"&gt;great-circle distance&lt;/a&gt;. Items with no coordinates never match. To read the GPS coordinates of the source media, use the [`GET`](/v1.3/api-reference/manage-assets/retrieve) method of the `/assets/{asset_id}` endpoint. The coordinates are the `geospatial_latitude` and `geospatial_longitude` fields of the `technical_metadata` object.
        /// </param>
        /// <param name="tags">
        /// Narrows results to the moments and ranges that matching tags mark on video items. A tag matches when its `tag_metadata` field matches the `metadata` field. Only video items have tags, so images do not appear in the results.<br/>
        /// The search returns only the clips within a matching tag:<br/>
        /// - For a tag on a range, a clip matches when it lies entirely within the range. A clip that extends past either end of the range does not appear in the results.<br/>
        /// - For a tag on a single moment, a clip matches when it contains that moment.<br/>
        /// A clip within more than one matching tag appears once. With the `group_by` parameter set to `item`, each item groups only its clips within matching tags. When you specify other fields of the filter, a tag counts only when its item matches every other field. The `asset_type` field does not reduce the count. If more than 100 tags match, the platform returns a `422` error with the `metadata_filter_too_broad` code.<br/>
        /// To tag a moment or a range of a video item, use the [`POST`](/v1.3/api-reference/knowledge-store-items/item-tags/create) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/tags` endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreFilter(
            global::TwelveLabs.AssetTypeFilter? assetType,
            global::TwelveLabs.ItemIdFilter? itemId,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? userMetadata,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.MetadataValueFilter>? enrichment,
            global::TwelveLabs.CreatedAtFilter? createdAt,
            global::TwelveLabs.GeoCircleFilter? location,
            global::TwelveLabs.TagFilter? tags)
        {
            this.AssetType = assetType;
            this.ItemId = itemId;
            this.UserMetadata = userMetadata;
            this.Enrichment = enrichment;
            this.CreatedAt = createdAt;
            this.Location = location;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreFilter" /> class.
        /// </summary>
        public SearchKnowledgeStoreFilter()
        {
        }

    }
}