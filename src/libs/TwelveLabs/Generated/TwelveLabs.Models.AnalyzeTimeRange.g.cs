
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A time window within the video, expressed in seconds.
    /// </summary>
    public sealed partial class AnalyzeTimeRange
    {
        /// <summary>
        /// The start of the window, in seconds. Must be less than `end_time` and within the video duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// The end of the window, in seconds. Must be greater than `start_time` by at least `2` seconds and within the video duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTimeRange" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The start of the window, in seconds. Must be less than `end_time` and within the video duration.
        /// </param>
        /// <param name="endTime">
        /// The end of the window, in seconds. Must be greater than `start_time` by at least `2` seconds and within the video duration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTimeRange(
            double startTime,
            double endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTimeRange" /> class.
        /// </summary>
        public AnalyzeTimeRange()
        {
        }
    }
}