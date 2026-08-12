
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Divides the video into segments of equal, predetermined length. Use this for consistent timing.
    /// </summary>
    public sealed partial class VideoSegmentationVariant2
    {
        /// <summary>
        /// Discriminator value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoSegmentationVariant2StrategyJsonConverter))]
        public global::TwelveLabs.VideoSegmentationVariant2Strategy Strategy { get; set; }

        /// <summary>
        /// Configuration for fixed segmentation. This object is required when `strategy` is `fixed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed Fixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationVariant2" /> class.
        /// </summary>
        /// <param name="fixed">
        /// Configuration for fixed segmentation. This object is required when `strategy` is `fixed`.
        /// </param>
        /// <param name="strategy">
        /// Discriminator value: fixed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentationVariant2(
            global::TwelveLabs.VideoSegmentationDiscriminatorMappingFixedFixed @fixed,
            global::TwelveLabs.VideoSegmentationVariant2Strategy strategy)
        {
            this.Strategy = strategy;
            this.Fixed = @fixed ?? throw new global::System.ArgumentNullException(nameof(@fixed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationVariant2" /> class.
        /// </summary>
        public VideoSegmentationVariant2()
        {
        }

    }
}