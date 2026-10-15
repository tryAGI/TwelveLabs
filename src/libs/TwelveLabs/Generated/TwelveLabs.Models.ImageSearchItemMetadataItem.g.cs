
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The custom metadata of the knowledge store item. It is separate from the custom metadata of the source asset. A change to the custom metadata of the source asset does not change this field. The same key can have different values in the `user` field and in the `item` field. The `item_metadata` field of the knowledge store item contains the same metadata. This field is absent when no item metadata has been set.
    /// </summary>
    public sealed partial class ImageSearchItemMetadataItem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}