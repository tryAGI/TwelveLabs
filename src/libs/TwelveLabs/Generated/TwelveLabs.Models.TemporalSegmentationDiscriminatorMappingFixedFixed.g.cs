
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration for fixed segmentation. If you omit this object or the `duration_sec` field, the duration defaults to 6 seconds.
    /// </summary>
    public sealed partial class TemporalSegmentationDiscriminatorMappingFixedFixed
    {
        /// <summary>
        /// The duration in seconds for each segment. The platform divides the file into segments of this exact length. The final segment may be shorter if the file duration is not evenly divisible.<br/>
        /// **Default**: `6`.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `10`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_sec")]
        public double? DurationSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationDiscriminatorMappingFixedFixed" /> class.
        /// </summary>
        /// <param name="durationSec">
        /// The duration in seconds for each segment. The platform divides the file into segments of this exact length. The final segment may be shorter if the file duration is not evenly divisible.<br/>
        /// **Default**: `6`.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `10`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemporalSegmentationDiscriminatorMappingFixedFixed(
            double? durationSec)
        {
            this.DurationSec = durationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationDiscriminatorMappingFixedFixed" /> class.
        /// </summary>
        public TemporalSegmentationDiscriminatorMappingFixedFixed()
        {
        }

    }
}