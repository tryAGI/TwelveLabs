
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetsListResponse200
    {
        /// <summary>
        /// An array containing the assets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.Asset>? Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public global::TwelveLabs.PageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array containing the assets.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetsListResponse200(
            global::System.Collections.Generic.IList<global::TwelveLabs.Asset>? data,
            global::TwelveLabs.PageInfo? pageInfo)
        {
            this.Data = data;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsListResponse200" /> class.
        /// </summary>
        public AssetsListResponse200()
        {
        }
    }
}