#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoresClient
    {
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Use the `query.text` field to specify your natural-language query. Use the `filter` parameter to choose which items to search. Use the `search_options` parameter to choose how the platform matches videos.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.SearchKnowledgeStoreResponse> SearchAsync(
            string knowledgeStoreId,

            global::TwelveLabs.SearchKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Use the `query.text` field to specify your natural-language query. Use the `filter` parameter to choose which items to search. Use the `search_options` parameter to choose how the platform matches videos.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.SearchKnowledgeStoreResponse>> SearchAsResponseAsync(
            string knowledgeStoreId,

            global::TwelveLabs.SearchKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Use the `query.text` field to specify your natural-language query. Use the `filter` parameter to choose which items to search. Use the `search_options` parameter to choose how the platform matches videos.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="filter">
        /// Narrows results to specific items in the knowledge store. Omit the filter to search all items.<br/>
        /// You can filter with these fields:<br/>
        /// - `asset_type`: The type of item. Use `eq` to match one type. Use `in` to match any type in a list.<br/>
        /// - `item_id`: Specific items. Use `eq` to match one item or `in` to match any item in a list. Use `nin` to exclude any item in a list. You cannot use `eq` and `in` together. You can use `nin` on its own or with either `eq` or `in`. If an item is listed in `nin` and selected by `eq` or `in`, the platform excludes it.<br/>
        /// - `item_collection_id`: Specific item collections. Use `eq` to match the items in one item collection. Use `in` with a list of item collections to match the items in any of them. If an item collection is not in the knowledge store, the platform returns a `404` error with the `resource_not_exists` code. If the identifier of an item collection is not valid, the platform returns a `400` error with the `parameter_invalid` code.<br/>
        /// - `user_metadata`: Custom metadata. Map each key to `eq`, `in`, or inclusive numeric or date bounds with `gte` and `lte`.<br/>
        /// - `enrichment`: Enrichment values that the platform extracts. Map each key to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
        /// - `created_at`: Creation time. Use `gte` to set the earliest time and `lte` to set the latest time. You can use one or both.<br/>
        /// - `location`: Capture location. Provide the center and the radius of a circle.<br/>
        /// - `tags`: Item tags. Map each key under `tags.metadata` to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
        /// An item must match all of the fields and metadata keys that you specify. The `tags` field also limits which clips of an item the search returns.<br/>
        /// When you use any of the `item_collection_id`, `user_metadata`, `enrichment`, `created_at`, or `location` fields, the platform counts the items that match those conditions together, including metadata ranges and the items that you include or exclude with the `item_id` field. If more than 10,000 items match, the platform returns a `422` error with the `metadata_filter_too_broad` code. To reduce the count, add conditions or use the `item_id` field. The `asset_type` field does not reduce the count. When you use the `tags` field, the platform does not count items, and this limit does not apply. It counts the matching tags instead, as the `tags` field describes.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.SearchKnowledgeStoreResponse> SearchAsync(
            string knowledgeStoreId,
            global::TwelveLabs.KnowledgeStoreSearchQuery query,
            global::TwelveLabs.SearchKnowledgeStoreFilter? filter = default,
            global::TwelveLabs.SearchKnowledgeStoreOptions? searchOptions = default,
            global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? groupBy = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}