
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata for the item. Keys are strings; each value is a string, a number, a boolean, or an array of strings.
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