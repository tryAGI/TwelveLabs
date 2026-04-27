
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration that controls how content added to this knowledge store is processed.<br/>
    /// This field is immutable after creation.
    /// </summary>
    public sealed partial class IngestionConfig
    {
        /// <summary>
        /// Configuration for metadata enrichment. Provide **exactly one** of `json_schema` or `description`.<br/>
        /// - Use `json_schema` for structured extraction — the platform will extract data conforming to the provided schema.<br/>
        /// - Use `description` for natural-language instructions — the platform converts them into a schema internally.
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
        /// Configuration for metadata enrichment. Provide **exactly one** of `json_schema` or `description`.<br/>
        /// - Use `json_schema` for structured extraction — the platform will extract data conforming to the provided schema.<br/>
        /// - Use `description` for natural-language instructions — the platform converts them into a schema internally.
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