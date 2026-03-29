
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration for fixed segmentation. This field is required when `strategy` is `fixed`.
    /// </summary>
    public sealed partial class VideoSegmentation1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoSegmentation1StrategyJsonConverter))]
        public global::TwelveLabs.VideoSegmentation1Strategy Strategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.VideoSegmentationOneOf1Fixed Fixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentation1" /> class.
        /// </summary>
        /// <param name="fixed"></param>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentation1(
            global::TwelveLabs.VideoSegmentationOneOf1Fixed @fixed,
            global::TwelveLabs.VideoSegmentation1Strategy strategy)
        {
            this.Strategy = strategy;
            this.Fixed = @fixed ?? throw new global::System.ArgumentNullException(nameof(@fixed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentation1" /> class.
        /// </summary>
        public VideoSegmentation1()
        {
        }
    }
}