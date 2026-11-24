
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The custom metadata of the source asset. The platform copies the metadata into this field with limits on the number of pairs and on the length of keys and values. The `metadata` field of the knowledge store item contains the same metadata. For the limits, see the [`metadata`](/v1.3/api-reference/knowledge-store-items/retrieve#response.body.metadata) field on the **Retrieve a knowledge store item** page.
    /// </summary>
    public sealed partial class VideoSearchItemMetadataUser
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}