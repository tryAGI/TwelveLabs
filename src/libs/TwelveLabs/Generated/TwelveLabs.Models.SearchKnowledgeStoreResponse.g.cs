
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The search results. Each entry in the `data` array includes an `asset_type` field that indicates the type of item.
    /// </summary>
    public sealed partial class SearchKnowledgeStoreResponse
    {
        /// <summary>
        /// Search results, ordered by relevance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit> Data { get; set; }

        /// <summary>
        /// Pagination token for the next page. Pass this value as the `page_token` parameter in your next request to retrieve more results. Absent when no more pages exist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The video options applied to this search, including any defaults.<br/>
        /// - **When the search includes videos**: this object contains a `video` field with the modalities used.<br/>
        /// - **When the search is limited to images** (the `filter.asset_type` field excludes videos): no video options apply, and this object is empty.<br/>
        /// Any option you omit is returned with its default value. For example, the `video` field shows `["visual"]` for modalities when you don't set `search_options.video`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_search_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.SearchKnowledgeStoreOptions EffectiveSearchOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Search results, ordered by relevance.
        /// </param>
        /// <param name="effectiveSearchOptions">
        /// The video options applied to this search, including any defaults.<br/>
        /// - **When the search includes videos**: this object contains a `video` field with the modalities used.<br/>
        /// - **When the search is limited to images** (the `filter.asset_type` field excludes videos): no video options apply, and this object is empty.<br/>
        /// Any option you omit is returned with its default value. For example, the `video` field shows `["visual"]` for modalities when you don't set `search_options.video`.
        /// </param>
        /// <param name="nextPageToken">
        /// Pagination token for the next page. Pass this value as the `page_token` parameter in your next request to retrieve more results. Absent when no more pages exist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreResponse(
            global::System.Collections.Generic.IList<global::TwelveLabs.SearchKnowledgeStoreHit> data,
            global::TwelveLabs.SearchKnowledgeStoreOptions effectiveSearchOptions,
            string? nextPageToken)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPageToken = nextPageToken;
            this.EffectiveSearchOptions = effectiveSearchOptions ?? throw new global::System.ArgumentNullException(nameof(effectiveSearchOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreResponse" /> class.
        /// </summary>
        public SearchKnowledgeStoreResponse()
        {
        }

    }
}