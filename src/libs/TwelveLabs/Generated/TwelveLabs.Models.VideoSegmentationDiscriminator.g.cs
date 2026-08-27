
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoSegmentationDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoSegmentationDiscriminatorStrategyJsonConverter))]
        public global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationDiscriminator" /> class.
        /// </summary>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentationDiscriminator(
            global::TwelveLabs.VideoSegmentationDiscriminatorStrategy? strategy)
        {
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationDiscriminator" /> class.
        /// </summary>
        public VideoSegmentationDiscriminator()
        {
        }

    }
}