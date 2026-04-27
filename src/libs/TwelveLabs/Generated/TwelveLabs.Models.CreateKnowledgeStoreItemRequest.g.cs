
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKnowledgeStoreItemRequest
    {
        /// <summary>
        /// The unique identifier of the video asset to add to the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Key-value pairs to attach to the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeStoreItemRequest" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of the video asset to add to the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to attach to the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKnowledgeStoreItemRequest(
            string assetId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKnowledgeStoreItemRequest" /> class.
        /// </summary>
        public CreateKnowledgeStoreItemRequest()
        {
        }
    }
}