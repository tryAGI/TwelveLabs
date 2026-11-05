
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
    /// </summary>
    public sealed partial class VideoSegmentationDiscriminatorMappingDynamicDynamic
    {
        /// <summary>
        /// The minimum duration in seconds for each segment.<br/>
        /// The platform divides the video into segments that are at least this long. Segments adapt to scene changes and content boundaries and may be longer than the minimum.<br/>
        /// Marengo 3.0 ignores the fractional part of this value. For example, it treats `2.5` as `2`.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `5`.<br/>
        /// **Example**: With `min_duration_sec: 3`, segments might be: [0-3.2s], [3.2-7.8s], [7.8-12.1s]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_duration_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinDurationSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationDiscriminatorMappingDynamicDynamic" /> class.
        /// </summary>
        /// <param name="minDurationSec">
        /// The minimum duration in seconds for each segment.<br/>
        /// The platform divides the video into segments that are at least this long. Segments adapt to scene changes and content boundaries and may be longer than the minimum.<br/>
        /// Marengo 3.0 ignores the fractional part of this value. For example, it treats `2.5` as `2`.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `5`.<br/>
        /// **Example**: With `min_duration_sec: 3`, segments might be: [0-3.2s], [3.2-7.8s], [7.8-12.1s]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegmentationDiscriminatorMappingDynamicDynamic(
            double minDurationSec)
        {
            this.MinDurationSec = minDurationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegmentationDiscriminatorMappingDynamicDynamic" /> class.
        /// </summary>
        public VideoSegmentationDiscriminatorMappingDynamicDynamic()
        {
        }

    }
}