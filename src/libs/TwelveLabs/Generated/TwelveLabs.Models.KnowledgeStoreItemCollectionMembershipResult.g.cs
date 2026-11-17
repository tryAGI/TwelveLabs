
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The result for one identifier in a request that adds items to or removes items from an item collection.
    /// </summary>
    public sealed partial class KnowledgeStoreItemCollectionMembershipResult
    {
        /// <summary>
        /// The unique identifier of the item, as sent in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Whether the platform added, removed, or skipped the item. When a request adds items, the value is `added` or `skipped`. When a request removes items, the value is `removed` or `skipped`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemCollectionMembershipResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResultStatus Status { get; set; }

        /// <summary>
        /// The reason the platform skipped this identifier. Present only when `status` is `skipped`.<br/>
        /// - `already_member`: The item is already in the collection.<br/>
        /// - `not_member`: The item is not in the collection.<br/>
        /// - `duplicate`: The identifier appears earlier in the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.KnowledgeStoreItemCollectionMembershipResultReasonJsonConverter))]
        public global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResultReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemCollectionMembershipResult" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The unique identifier of the item, as sent in the request.
        /// </param>
        /// <param name="status">
        /// Whether the platform added, removed, or skipped the item. When a request adds items, the value is `added` or `skipped`. When a request removes items, the value is `removed` or `skipped`.
        /// </param>
        /// <param name="reason">
        /// The reason the platform skipped this identifier. Present only when `status` is `skipped`.<br/>
        /// - `already_member`: The item is already in the collection.<br/>
        /// - `not_member`: The item is not in the collection.<br/>
        /// - `duplicate`: The identifier appears earlier in the same request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreItemCollectionMembershipResult(
            string itemId,
            global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResultStatus status,
            global::TwelveLabs.KnowledgeStoreItemCollectionMembershipResultReason? reason)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreItemCollectionMembershipResult" /> class.
        /// </summary>
        public KnowledgeStoreItemCollectionMembershipResult()
        {
        }

    }
}