
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The response format for this task. Present only when the request included a response format.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParamsResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeJsonConverter))]
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type { get; set; }

        /// <summary>
        /// The JSON schema for this task. Present only when `type` is `json_schema`.<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Omitted.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>? JsonSchema { get; set; }

        /// <summary>
        /// The segment definitions for this task. Present only when `type` is `segment_definitions`.<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Returns only the first element.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_definitions")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? SegmentDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="jsonSchema">
        /// The JSON schema for this task. Present only when `type` is `json_schema`.<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Omitted.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full schema.
        /// </param>
        /// <param name="segmentDefinitions">
        /// The segment definitions for this task. Present only when `type` is `segment_definitions`.<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Returns only the first element.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParamsResponseFormat(
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? type,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatJsonSchema, object>? jsonSchema,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? segmentDefinitions)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
            this.SegmentDefinitions = segmentDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsResponseFormat" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParamsResponseFormat()
        {
        }
    }
}