
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems>? Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_sources")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems>? MediaSources { get; set; }

        /// <summary>
        /// The time ranges for this segment definition. Present only when the task was created with `time_ranges`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_ranges")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? TimeRanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="fields"></param>
        /// <param name="mediaSources"></param>
        /// <param name="timeRanges">
        /// The time ranges for this segment definition. Present only when the task was created with `time_ranges`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems(
            string id,
            string description,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsFieldsItems>? fields,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItemsMediaSourcesItems>? mediaSources,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTimeRange>? timeRanges)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Fields = fields;
            this.MediaSources = mediaSources;
            this.TimeRanges = timeRanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems()
        {
        }
    }
}