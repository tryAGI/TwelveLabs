
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata stored on this item alone. Keys are strings; each value is a string, a number, a boolean, or an array of strings. The source asset never changes it, so the same key can have a different value in `metadata` and in `item_metadata`. You set it when you create the item or change it with the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint. The field is absent when the item has no item metadata.
    /// </summary>
    public sealed partial class KnowledgeStoreItemItemMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}