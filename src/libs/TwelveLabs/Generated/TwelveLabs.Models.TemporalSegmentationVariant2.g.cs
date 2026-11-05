
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Divides the file into equal-length segments. Use this for consistent timing.
    /// </summary>
    public sealed partial class TemporalSegmentationVariant2
    {
        /// <summary>
        /// Discriminator value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TemporalSegmentationVariant2StrategyJsonConverter))]
        public global::TwelveLabs.TemporalSegmentationVariant2Strategy Strategy { get; set; }

        /// <summary>
        /// Configuration for fixed segmentation. If you omit this object or the `duration_sec` field, the duration defaults to 6 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed")]
        public global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? Fixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationVariant2" /> class.
        /// </summary>
        /// <param name="strategy">
        /// Discriminator value: fixed
        /// </param>
        /// <param name="fixed">
        /// Configuration for fixed segmentation. If you omit this object or the `duration_sec` field, the duration defaults to 6 seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemporalSegmentationVariant2(
            global::TwelveLabs.TemporalSegmentationVariant2Strategy strategy,
            global::TwelveLabs.TemporalSegmentationDiscriminatorMappingFixedFixed? @fixed)
        {
            this.Strategy = strategy;
            this.Fixed = @fixed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationVariant2" /> class.
        /// </summary>
        public TemporalSegmentationVariant2()
        {
        }

    }
}