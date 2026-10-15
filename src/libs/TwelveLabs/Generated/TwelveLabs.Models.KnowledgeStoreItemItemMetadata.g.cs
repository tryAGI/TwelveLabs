
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The custom metadata of the knowledge store item. Keys are strings; each value is a string, a number, a boolean, or an array of strings. It is separate from the custom metadata of the source asset. A change to the custom metadata of the source asset does not change this field. The same key can have different values in the `metadata` field and in the `item_metadata` field. You set it when you create the item or change it with the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint. This field is absent when no item metadata has been set.
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