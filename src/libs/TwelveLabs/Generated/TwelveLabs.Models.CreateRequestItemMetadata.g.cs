
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata for the item, as user-defined key-value pairs. It has the following limits:<br/>
    /// - Up to 50 pairs.<br/>
    /// - Keys are strings of up to 128 characters.<br/>
    /// - String values can have up to 8192 characters.<br/>
    /// - The strings in an array can have up to 8192 characters in total.<br/>
    /// Values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected.<br/>
    /// An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.<br/>
    /// To change it after you create the item, use the [`PATCH`](/v1.3/api-reference/knowledge-store-items/update-item-metadata) or [`PUT`](/v1.3/api-reference/knowledge-store-items/replace-item-metadata) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}/item-metadata` endpoint.
    /// </summary>
    public sealed partial class CreateRequestItemMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}