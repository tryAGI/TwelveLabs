
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A time window within the video, expressed in seconds.
    /// </summary>
    public sealed partial class AnalyzeTimeRange
    {
        /// <summary>
        /// The start of the window, as an absolute timestamp in seconds, based on the video's internal metadata. Must be less than `end_time` and within the video duration.<br/>
        /// Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        /// The end of the window, as an absolute timestamp in seconds, based on the video's internal metadata. Must be greater than `start_time` by at least `2` seconds and within the video duration.<br/>
        /// Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.
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
        /// The start of the window, as an absolute timestamp in seconds, based on the video's internal metadata. Must be less than `end_time` and within the video duration.<br/>
        /// Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.
        /// </param>
        /// <param name="endTime">
        /// The end of the window, as an absolute timestamp in seconds, based on the video's internal metadata. Must be greater than `start_time` by at least `2` seconds and within the video duration.<br/>
        /// Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.
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