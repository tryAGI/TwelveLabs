
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata from the source asset. Keys are strings; each value is a string, a number, a boolean, or an array of strings. The platform updates it when the user-defined metadata of the asset changes. To change it, use the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint. To store metadata on the item alone, use `item_metadata`.
    /// </summary>
    public sealed partial class KnowledgeStoreItemMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}