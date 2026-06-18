
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeAsyncBatchesListResponse200
    {
        /// <summary>
        /// An array of batch objects. Each object includes item counts for each item status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse> Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.PageInfo PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeAsyncBatchesListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array of batch objects. Each object includes item counts for each item status.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeAsyncBatchesListResponse200(
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeBatchStatusResponse> data,
            global::TwelveLabs.PageInfo pageInfo)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.PageInfo = pageInfo ?? throw new global::System.ArgumentNullException(nameof(pageInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeAsyncBatchesListResponse200" /> class.
        /// </summary>
        public AnalyzeAsyncBatchesListResponse200()
        {
        }

    }
}