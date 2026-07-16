
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Natural-language instructions that the platform converts into a JSON Schema internally.
    /// </summary>
    public sealed partial class EnrichmentConfigVariant2
    {
        /// <summary>
        /// Must be `"description"`. Identifies this as the natural-language variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigDescriptionTypeJsonConverter))]
        public global::TwelveLabs.EnrichmentConfigDescriptionType Type { get; set; }

        /// <summary>
        /// A natural-language description of what knowledge should be extracted from the videos.<br/>
        /// The platform converts this into a JSON Schema internally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfigVariant2" /> class.
        /// </summary>
        /// <param name="description">
        /// A natural-language description of what knowledge should be extracted from the videos.<br/>
        /// The platform converts this into a JSON Schema internally.
        /// </param>
        /// <param name="type">
        /// Must be `"description"`. Identifies this as the natural-language variant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichmentConfigVariant2(
            string description,
            global::TwelveLabs.EnrichmentConfigDescriptionType type)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfigVariant2" /> class.
        /// </summary>
        public EnrichmentConfigVariant2()
        {
        }

    }
}