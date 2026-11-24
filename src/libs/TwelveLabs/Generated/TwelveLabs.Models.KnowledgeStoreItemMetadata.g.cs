
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The custom metadata of the source asset. Keys are strings; each value is a string, a number, a boolean, or an array of strings.<br/>
    /// The platform copies the custom metadata of the asset into this field. The copy has the following limits:<br/>
    /// - Up to 50 key-value pairs. If the asset has more, the platform sorts the keys by Unicode code point and copies the first 50.<br/>
    /// - Keys are strings of up to 128 characters.<br/>
    /// - String values can have up to 8192 characters.<br/>
    /// - The strings in an array can have up to 8192 characters in total.<br/>
    /// The platform does not copy a key or a value over these limits. The asset keeps all its custom metadata.<br/>
    /// The platform updates this field when the custom metadata of the asset changes. If you change a value on the asset to one over a limit, this field contains the earlier value. This field then differs from the asset.<br/>
    /// To work with the custom metadata of the asset:<br/>
    /// - To retrieve it, use the [`GET`](/v1.3/api-reference/upload-content/direct-uploads/retrieve) method of the `/assets/{asset_id}` endpoint and read the `user_metadata` field of the response.<br/>
    /// - To change it, use the [`PATCH`](/v1.3/api-reference/upload-content/direct-uploads/update-user-metadata) method of the `/assets/{asset_id}/user-metadata` endpoint.<br/>
    /// To set custom metadata for the knowledge store item only, use `item_metadata`.
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