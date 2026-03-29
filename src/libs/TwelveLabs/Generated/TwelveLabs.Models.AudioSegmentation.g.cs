
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides the audio into segments.
    /// </summary>
    public sealed partial class AudioSegmentation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AudioSegmentationStrategyJsonConverter))]
        public global::TwelveLabs.AudioSegmentationStrategy Strategy { get; set; }

        /// <summary>
        /// Configuration for fixed segmentation.<br/>
        /// This object is required when the `strategy` field is `fixed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AudioSegmentationFixed Fixed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegmentation" /> class.
        /// </summary>
        /// <param name="fixed">
        /// Configuration for fixed segmentation.<br/>
        /// This object is required when the `strategy` field is `fixed`.
        /// </param>
        /// <param name="strategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSegmentation(
            global::TwelveLabs.AudioSegmentationFixed @fixed,
            global::TwelveLabs.AudioSegmentationStrategy strategy)
        {
            this.Strategy = strategy;
            this.Fixed = @fixed ?? throw new global::System.ArgumentNullException(nameof(@fixed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegmentation" /> class.
        /// </summary>
        public AudioSegmentation()
        {
        }
    }
}