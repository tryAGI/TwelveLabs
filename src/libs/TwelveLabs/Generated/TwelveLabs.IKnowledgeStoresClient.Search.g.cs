#nullable enable

namespace TwelveLabs
{
    public partial interface IKnowledgeStoresClient
    {
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Provide your natural-language query in the `query.text` field. Use the `filter` parameter to choose which items to search: by type of item (the `asset_type` field) or by specific items (the `item_id` field). Use the optional `search_options` parameter to control how videos are matched (by visual content, audio, or both). If you omit it, videos are matched on their visual content. Images are always matched on their visual content.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.SearchKnowledgeStoreResponse> SearchAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.SearchKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Provide your natural-language query in the `query.text` field. Use the `filter` parameter to choose which items to search: by type of item (the `asset_type` field) or by specific items (the `item_id` field). Use the optional `search_options` parameter to control how videos are matched (by visual content, audio, or both). If you omit it, videos are matched on their visual content. Images are always matched on their visual content.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.SearchKnowledgeStoreResponse>> SearchAsResponseAsync(
            string knowledgeStoreId,
            string xApiKey,

            global::TwelveLabs.SearchKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Provide your natural-language query in the `query.text` field. Use the `filter` parameter to choose which items to search: by type of item (the `asset_type` field) or by specific items (the `item_id` field). Use the optional `search_options` parameter to control how videos are matched (by visual content, audio, or both). If you omit it, videos are matched on their visual content. Images are always matched on their visual content.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="xApiKey"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.SearchKnowledgeStoreResponse> SearchAsync(
            string knowledgeStoreId,
            string xApiKey,
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