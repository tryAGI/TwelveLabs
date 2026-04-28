
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaType { get; set; }

        /// <summary>
        /// Present when the source was provided as a URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Present when the source was provided as an asset ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mediaType"></param>
        /// <param name="url">
        /// Present when the source was provided as a URL.
        /// </param>
        /// <param name="assetId">
        /// Present when the source was provided as an asset ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems(
            string name,
            string mediaType,
            string? url,
            string? assetId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Url = url;
            this.AssetId = assetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems()
        {
        }
    }
}