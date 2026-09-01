
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemporalSegmentationDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TemporalSegmentationDiscriminatorStrategyJsonConverter))]
        public global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationDiscriminator" /> class.
        /// </summary>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemporalSegmentationDiscriminator(
            global::TwelveLabs.TemporalSegmentationDiscriminatorStrategy? strategy)
        {
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationDiscriminator" /> class.
        /// </summary>
        public TemporalSegmentationDiscriminator()
        {
        }

    }
}