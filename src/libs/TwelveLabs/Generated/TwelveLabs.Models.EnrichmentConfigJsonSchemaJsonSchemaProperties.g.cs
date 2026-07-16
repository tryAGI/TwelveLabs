
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A map of property names to their JSON Schema definitions. Each property<br/>
    /// must include a field named `description`. The platform uses this field to guide extraction<br/>
    /// quality. Omitting it returns a `422` error.
    /// </summary>
    public sealed partial class EnrichmentConfigJsonSchemaJsonSchemaProperties
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}