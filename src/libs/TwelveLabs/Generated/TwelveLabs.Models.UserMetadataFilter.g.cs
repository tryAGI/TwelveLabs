
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results by custom metadata. Map each key to an object with exactly one of the `eq` or `in` operators. You can specify 1 to 50 keys. An item must match all of the keys that you specify.<br/>
    /// A key matches the custom metadata of the source asset (the `metadata` field of the knowledge store item) and the custom metadata of the knowledge store item (the `item_metadata` field). An item matches a key when the value matches in either field. For the names of these fields in search results, see the [Custom metadata field names](/v1.3/api-reference/knowledge-store-items/the-knowledge-store-item-object#custom-metadata-field-names) section on **The knowledge store item object** page.
    /// </summary>
    public sealed partial class UserMetadataFilter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}