
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Divides the video into segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
    /// </summary>
    public sealed partial class VideoSegmentationVariant1
    {
        /// <summary>
        /// Discriminator value: dynamic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoSegmentationVariant1StrategyJsonConverter))]
        public global::TwelveLabs.VideoSegmentationVariant1Strategy Strategy { get; set; }

        /// <summary>
        /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic Dynamic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationVariant1" /> class.
        /// </summary>
        /// <param name="dynamic">
        /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
        /// </param>
        /// <param name="strategy">
        /// Discriminator value: dynamic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentationVariant1(
            global::TwelveLabs.VideoSegmentationDiscriminatorMappingDynamicDynamic dynamic,
            global::TwelveLabs.VideoSegmentationVariant1Strategy strategy)
        {
            this.Strategy = strategy;
            this.Dynamic = dynamic ?? throw new global::System.ArgumentNullException(nameof(dynamic));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationVariant1" /> class.
        /// </summary>
        public VideoSegmentationVariant1()
        {
        }

    }
}