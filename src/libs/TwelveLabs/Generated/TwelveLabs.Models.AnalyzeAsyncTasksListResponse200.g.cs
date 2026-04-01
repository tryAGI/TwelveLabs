
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeAsyncTasksListResponse200
    {
        /// <summary>
        /// An array that contains up to `page_limit` analysis tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="AnalyzeAsyncTasksListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array that contains up to `page_limit` analysis tasks.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeAsyncTasksListResponse200(
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponse> data,
            global::TwelveLabs.PageInfo pageInfo)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.PageInfo = pageInfo ?? throw new global::System.ArgumentNullException(nameof(pageInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeAsyncTasksListResponse200" /> class.
        /// </summary>
        public AnalyzeAsyncTasksListResponse200()
        {
        }
    }
}