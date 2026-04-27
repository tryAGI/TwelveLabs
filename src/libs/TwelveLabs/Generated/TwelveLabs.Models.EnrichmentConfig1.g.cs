
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnrichmentConfig1
    {
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
        /// Initializes a new instance of the <see cref="EnrichmentConfig1" /> class.
        /// </summary>
        /// <param name="description">
        /// A natural-language description of what knowledge should be extracted from the videos.<br/>
        /// The platform converts this into a JSON Schema internally.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichmentConfig1(
            string description)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfig1" /> class.
        /// </summary>
        public EnrichmentConfig1()
        {
        }
    }
}