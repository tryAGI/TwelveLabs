
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Defines a type of segment to extract from the video.
    /// </summary>
    public sealed partial class SegmentDefinition
    {
        /// <summary>
        /// A unique identifier for this segment definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Describe what this type of segment looks like in the video. The model uses this text to identify matching segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Custom fields to extract for each segment instance. Maximum 20 fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? Fields { get; set; }

        /// <summary>
        /// Reference images that help the model identify segments. Maximum 4 sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_sources")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? MediaSources { get; set; }

        /// <summary>
        /// Time windows that limit segment extraction to specific parts of the video. Only supported for Pegasus 1.5 with `analysis_mode` set to `time_based_metadata`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Each range must satisfy `end_time &gt; start_time` with a minimum duration of `2` seconds. Both values must fall within the video duration.<br/>
        /// - Ranges within a single definition must not overlap. Touching boundaries are allowed (Example: `[0, 5]` and `[5, 10]`).<br/>
        /// - Mutually exclusive with the top-level `start_time` / `end_time` fields.<br/>
        /// - Mutually exclusive with `min_segment_duration` and `max_segment_duration`.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_ranges")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? TimeRanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentDefinition" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for this segment definition.
        /// </param>
        /// <param name="description">
        /// Describe what this type of segment looks like in the video. The model uses this text to identify matching segments.
        /// </param>
        /// <param name="fields">
        /// Custom fields to extract for each segment instance. Maximum 20 fields.
        /// </param>
        /// <param name="mediaSources">
        /// Reference images that help the model identify segments. Maximum 4 sources.
        /// </param>
        /// <param name="timeRanges">
        /// Time windows that limit segment extraction to specific parts of the video. Only supported for Pegasus 1.5 with `analysis_mode` set to `time_based_metadata`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Each range must satisfy `end_time &gt; start_time` with a minimum duration of `2` seconds. Both values must fall within the video duration.<br/>
        /// - Ranges within a single definition must not overlap. Touching boundaries are allowed (Example: `[0, 5]` and `[5, 10]`).<br/>
        /// - Mutually exclusive with the top-level `start_time` / `end_time` fields.<br/>
        /// - Mutually exclusive with `min_segment_duration` and `max_segment_duration`.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentDefinition(
            string id,
            string description,
            global::System.Collections.Generic.IList<global::TwelveLabs.SegmentField>? fields,
            global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? mediaSources,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? timeRanges)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Fields = fields;
            this.MediaSources = mediaSources;
            this.TimeRanges = timeRanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentDefinition" /> class.
        /// </summary>
        public SegmentDefinition()
        {
        }
    }
}