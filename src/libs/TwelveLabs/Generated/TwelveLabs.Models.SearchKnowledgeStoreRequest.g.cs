
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Request body for searching a knowledge store.<br/>
    /// To paginate, set the `page_token` parameter to the `next_page_token` field returned in the previous response and send the request again. The token identifies the original search, so any search fields you send are ignored.
    /// </summary>
    public sealed partial class SearchKnowledgeStoreRequest
    {
        /// <summary>
        /// The search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.KnowledgeStoreSearchQuery Query { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Filter { get; set; }

        /// <summary>
        /// Specifies how videos are matched. Videos are the only type of item with configurable options, set in the `search_options.video` field. Images are always matched on their visual content and have no options to configure.<br/>
        /// To choose which types of items to search, use the `filter.asset_type` field. If you provide options in the `search_options.video` field when the `filter.asset_type` field excludes videos, the platform returns a `400` error.<br/>
        /// If you omit this field, videos are matched on their visual content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_options")]
        public global::TwelveLabs.SearchKnowledgeStoreOptions? SearchOptions { get; set; }

        /// <summary>
        /// Controls how the platform groups matches in the response.<br/>
        /// - `none`: Returns individual matches ordered by relevance.<br/>
        /// - `item`: Groups matches under their parent item.<br/>
        /// **Default**: `none`.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SearchKnowledgeStoreRequestGroupByJsonConverter))]
        public global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? GroupBy { get; set; }

        /// <summary>
        /// The maximum number of results per page. A result is one entry in the `data` array. With the `group_by` parameter set to its default of `none`, each result is an individual match: a video clip or an image. When set to `item`, each result is one item: a video with all its matching clips, or an image.<br/>
        /// **Default**: `10`. **Max**: `50`.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Pagination token used to retrieve the next page of results. Omit it on the first request. To fetch the next page, set it to the `next_page_token` field returned in the previous response and send the request again.<br/>
        /// If a token is malformed or unrecognized, the platform returns a `400` error. If a token has expired, the platform returns a `410` error (make a new search request to obtain a fresh page token).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Set to `true` to include metadata in each result. Each result includes a `metadata` object with these fields:<br/>
        /// - `system`: System-generated metadata, such as duration and resolution.<br/>
        /// - `user`: The custom metadata of the source asset.<br/>
        /// - `item`: The custom metadata of the knowledge store item.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_metadata")]
        public bool? IncludeMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="filter">
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
        /// </param>
        /// <param name="searchOptions">
        /// Specifies how videos are matched. Videos are the only type of item with configurable options, set in the `search_options.video` field. Images are always matched on their visual content and have no options to configure.<br/>
        /// To choose which types of items to search, use the `filter.asset_type` field. If you provide options in the `search_options.video` field when the `filter.asset_type` field excludes videos, the platform returns a `400` error.<br/>
        /// If you omit this field, videos are matched on their visual content.
        /// </param>
        /// <param name="groupBy">
        /// Controls how the platform groups matches in the response.<br/>
        /// - `none`: Returns individual matches ordered by relevance.<br/>
        /// - `item`: Groups matches under their parent item.<br/>
        /// **Default**: `none`.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="pageSize">
        /// The maximum number of results per page. A result is one entry in the `data` array. With the `group_by` parameter set to its default of `none`, each result is an individual match: a video clip or an image. When set to `item`, each result is one item: a video with all its matching clips, or an image.<br/>
        /// **Default**: `10`. **Max**: `50`.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="pageToken">
        /// Pagination token used to retrieve the next page of results. Omit it on the first request. To fetch the next page, set it to the `next_page_token` field returned in the previous response and send the request again.<br/>
        /// If a token is malformed or unrecognized, the platform returns a `400` error. If a token has expired, the platform returns a `410` error (make a new search request to obtain a fresh page token).
        /// </param>
        /// <param name="includeMetadata">
        /// Set to `true` to include metadata in each result. Each result includes a `metadata` object with these fields:<br/>
        /// - `system`: System-generated metadata, such as duration and resolution.<br/>
        /// - `user`: The custom metadata of the source asset.<br/>
        /// - `item`: The custom metadata of the knowledge store item.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreRequest(
            global::TwelveLabs.KnowledgeStoreSearchQuery query,
            global::TwelveLabs.SearchKnowledgeStoreFilter? filter,
            global::TwelveLabs.SearchKnowledgeStoreOptions? searchOptions,
            global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? groupBy,
            int? pageSize,
            string? pageToken,
            bool? includeMetadata)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Filter = filter;
            this.SearchOptions = searchOptions;
            this.GroupBy = groupBy;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.IncludeMetadata = includeMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreRequest" /> class.
        /// </summary>
        public SearchKnowledgeStoreRequest()
        {
        }

    }
}