
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Metadata that the platform extracts from the whole item, as defined by the enrichment configuration of the knowledge store. It holds the properties whose `granularity` is `video` for a video, or `image` for an image. Properties whose `granularity` is `shot` do not appear in this field. Keys are the property names; each value matches its property definition. A property with no value is omitted. The field is present only when the item is `ready` and holds at least one value.
    /// </summary>
    public sealed partial class KnowledgeStoreItemEnrichedMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}