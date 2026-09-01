
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Configuration for dynamic segmentation. This object is required when `strategy` is `dynamic`.
    /// </summary>
    public sealed partial class TemporalSegmentationDiscriminatorMappingDynamicDynamic
    {
        /// <summary>
        /// The minimum duration in seconds for each segment.<br/>
        /// The platform divides the file into segments that are at least this long. Segments adapt to scene changes and content boundaries and may be longer than the minimum.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `5`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_duration_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinDurationSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationDiscriminatorMappingDynamicDynamic" /> class.
        /// </summary>
        /// <param name="minDurationSec">
        /// The minimum duration in seconds for each segment.<br/>
        /// The platform divides the file into segments that are at least this long. Segments adapt to scene changes and content boundaries and may be longer than the minimum.<br/>
        /// **Min**: `2`.<br/>
        /// **Max**: `5`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemporalSegmentationDiscriminatorMappingDynamicDynamic(
            int minDurationSec)
        {
            this.MinDurationSec = minDurationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalSegmentationDiscriminatorMappingDynamicDynamic" /> class.
        /// </summary>
        public TemporalSegmentationDiscriminatorMappingDynamicDynamic()
        {
        }

    }
}