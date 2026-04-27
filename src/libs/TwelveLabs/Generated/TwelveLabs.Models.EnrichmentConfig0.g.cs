
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnrichmentConfig0
    {
        /// <summary>
        /// A JSON Schema that defines the structure of metadata to extract from each video shot.<br/>
        /// The schema must be a valid JSON Schema object (draft 2020-12 or compatible).<br/>
        /// Top-level `type` must be `"object"` with a `properties` map — primitive or array<br/>
        /// top-level types are not supported. Keep schemas focused; deeply nested or overly<br/>
        /// complex schemas may degrade extraction quality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.EnrichmentConfigOneOf0JsonSchema JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfig0" /> class.
        /// </summary>
        /// <param name="jsonSchema">
        /// A JSON Schema that defines the structure of metadata to extract from each video shot.<br/>
        /// The schema must be a valid JSON Schema object (draft 2020-12 or compatible).<br/>
        /// Top-level `type` must be `"object"` with a `properties` map — primitive or array<br/>
        /// top-level types are not supported. Keep schemas focused; deeply nested or overly<br/>
        /// complex schemas may degrade extraction quality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichmentConfig0(
            global::TwelveLabs.EnrichmentConfigOneOf0JsonSchema jsonSchema)
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfig0" /> class.
        /// </summary>
        public EnrichmentConfig0()
        {
        }
    }
}