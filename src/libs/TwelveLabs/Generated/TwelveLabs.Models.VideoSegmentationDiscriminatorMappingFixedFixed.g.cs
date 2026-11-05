
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration for fixed segmentation. This object is required when `strategy` is `fixed`.
    /// </summary>
    public sealed partial class VideoSegmentationDiscriminatorMappingFixedFixed
    {
        /// <summary>
        /// The duration in seconds for each segment.<br/>
        /// The platform divides the video into segments of this exact length. The final segment may be shorter if the video duration is not evenly divisible.<br/>
        /// Marengo 3.0 ignores the fractional part of this value. For example, it treats `2.5` as `2`.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `10`.<br/>
        /// **Example**: With `duration_sec: 5`, a 12-second video produces segments: [0-5s], [5-10s], [10-12s].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationDiscriminatorMappingFixedFixed" /> class.
        /// </summary>
        /// <param name="durationSec">
        /// The duration in seconds for each segment.<br/>
        /// The platform divides the video into segments of this exact length. The final segment may be shorter if the video duration is not evenly divisible.<br/>
        /// Marengo 3.0 ignores the fractional part of this value. For example, it treats `2.5` as `2`.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `10`.<br/>
        /// **Example**: With `duration_sec: 5`, a 12-second video produces segments: [0-5s], [5-10s], [10-12s].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentationDiscriminatorMappingFixedFixed(
            double durationSec)
        {
            this.DurationSec = durationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationDiscriminatorMappingFixedFixed" /> class.
        /// </summary>
        public VideoSegmentationDiscriminatorMappingFixedFixed()
        {
        }

    }
}