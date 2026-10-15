
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata attached to an image knowledge store item in search results.
    /// </summary>
    public sealed partial class ImageSearchItemMetadata
    {
        /// <summary>
        /// System-generated metadata for the source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public global::TwelveLabs.ImageSearchSystemMetadata? System { get; set; }

        /// <summary>
        /// The custom metadata of the source asset. The `metadata` field of the knowledge store item contains the same metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? User { get; set; }

        /// <summary>
        /// The custom metadata of the knowledge store item. It is separate from the custom metadata of the source asset. A change to the custom metadata of the source asset does not change this field. The same key can have different values in the `user` field and in the `item` field. The `item_metadata` field of the knowledge store item contains the same metadata. This field is absent when no item metadata has been set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchItemMetadata" /> class.
        /// </summary>
        /// <param name="system">
        /// System-generated metadata for the source image.
        /// </param>
        /// <param name="user">
        /// The custom metadata of the source asset. The `metadata` field of the knowledge store item contains the same metadata.
        /// </param>
        /// <param name="item">
        /// The custom metadata of the knowledge store item. It is separate from the custom metadata of the source asset. A change to the custom metadata of the source asset does not change this field. The same key can have different values in the `user` field and in the `item` field. The `item_metadata` field of the knowledge store item contains the same metadata. This field is absent when no item metadata has been set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSearchItemMetadata(
            global::TwelveLabs.ImageSearchSystemMetadata? system,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? user,
            global::System.Collections.Generic.Dictionary<string, global::TwelveLabs.KnowledgeStoreMetadataValue>? item)
        {
            this.System = system;
            this.User = user;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSearchItemMetadata" /> class.
        /// </summary>
        public ImageSearchItemMetadata()
        {
        }

    }
}