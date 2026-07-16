
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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::TwelveLabs.SearchKnowledgeStoreFilter? Filter { get; set; }

        /// <summary>
        /// Specifies how videos are matched. Videos are the only type of item with configurable options, set in the `search_options.video` field. Images are always matched on their visual content and have no options to configure.<br/>
        /// To choose which types of items to search, use the `filter.asset_type` field. Providing options in the `search_options.video` field when the `filter.asset_type` field excludes videos returns a `400` error.<br/>
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
        /// A malformed or unrecognized token returns a `400` error. A token that has expired returns a `410` error (make a new search request to obtain a fresh page token).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Set to `true` to include metadata in each result. Each result includes a `metadata` object with a `system` field (platform-derived file properties such as duration and resolution) and a `user` field (metadata you attached to the item).<br/>
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
        /// </param>
        /// <param name="searchOptions">
        /// Specifies how videos are matched. Videos are the only type of item with configurable options, set in the `search_options.video` field. Images are always matched on their visual content and have no options to configure.<br/>
        /// To choose which types of items to search, use the `filter.asset_type` field. Providing options in the `search_options.video` field when the `filter.asset_type` field excludes videos returns a `400` error.<br/>
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
        /// A malformed or unrecognized token returns a `400` error. A token that has expired returns a `410` error (make a new search request to obtain a fresh page token).
        /// </param>
        /// <param name="includeMetadata">
        /// Set to `true` to include metadata in each result. Each result includes a `metadata` object with a `system` field (platform-derived file properties such as duration and resolution) and a `user` field (metadata you attached to the item).<br/>
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