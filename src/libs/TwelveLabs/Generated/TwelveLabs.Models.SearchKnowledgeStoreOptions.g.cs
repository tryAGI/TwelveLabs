
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how videos are matched. Videos are the only type of item with configurable options, set in the `search_options.video` field. Images are always matched on their visual content and have no options to configure.<br/>
    /// To choose which types of items to search, use the `filter.asset_type` field. Providing options in the `search_options.video` field when the `filter.asset_type` field excludes videos returns a `400` error.<br/>
    /// If you omit this field, videos are matched on their visual content.
    /// </summary>
    public sealed partial class SearchKnowledgeStoreOptions
    {
        /// <summary>
        /// Options that control how videos are matched. By default, videos are matched on their visual content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::TwelveLabs.VideoSearchOptions? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreOptions" /> class.
        /// </summary>
        /// <param name="video">
        /// Options that control how videos are matched. By default, videos are matched on their visual content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchKnowledgeStoreOptions(
            global::TwelveLabs.VideoSearchOptions? video)
        {
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchKnowledgeStoreOptions" /> class.
        /// </summary>
        public SearchKnowledgeStoreOptions()
        {
        }

    }
}