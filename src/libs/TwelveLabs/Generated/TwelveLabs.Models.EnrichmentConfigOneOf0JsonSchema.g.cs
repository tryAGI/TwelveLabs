
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A JSON Schema that defines the structure of metadata to extract from each video shot.<br/>
    /// The schema must be a valid JSON Schema object (draft 2020-12 or compatible).<br/>
    /// Top-level `type` must be `"object"` with a `properties` map — primitive or array<br/>
    /// top-level types are not supported. Keep schemas focused; deeply nested or overly<br/>
    /// complex schemas may degrade extraction quality.
    /// </summary>
    public sealed partial class EnrichmentConfigOneOf0JsonSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}