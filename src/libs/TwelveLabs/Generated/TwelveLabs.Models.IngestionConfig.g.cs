
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration that controls how content added to the knowledge store is processed.
    /// </summary>
    public sealed partial class IngestionConfig
    {
        /// <summary>
        /// Metadata enrichment configuration. The `type` field selects one variant:<br/>
        /// - `type: json_schema` - Structured extraction conforming to a provided JSON Schema.<br/>
        /// - `type: description` - Natural-language instructions that the platform converts into a JSON Schema. In a retrieved knowledge store, the `enrichment_config` object has the `type` field set to the `json_schema` value. Its `json_schema` field contains the JSON Schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.EnrichmentConfig EnrichmentConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionConfig" /> class.
        /// </summary>
        /// <param name="enrichmentConfig">
        /// Metadata enrichment configuration. The `type` field selects one variant:<br/>
        /// - `type: json_schema` - Structured extraction conforming to a provided JSON Schema.<br/>
        /// - `type: description` - Natural-language instructions that the platform converts into a JSON Schema. In a retrieved knowledge store, the `enrichment_config` object has the `type` field set to the `json_schema` value. Its `json_schema` field contains the JSON Schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IngestionConfig(
            global::TwelveLabs.EnrichmentConfig enrichmentConfig)
        {
            this.EnrichmentConfig = enrichmentConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestionConfig" /> class.
        /// </summary>
        public IngestionConfig()
        {
        }

    }
}