
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The request parameters for this task.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParams
    {
        /// <summary>
        /// The analysis approach for this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsAnalysisModeJsonConverter))]
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? AnalysisMode { get; set; }

        /// <summary>
        /// The natural-language prompt for this task. Present only when `analysis_mode` is `general` and the task was created with `prompt` (not `prompt_v2`).<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Truncated to the first 30 characters.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The structured prompt for this task. Present only when `analysis_mode` is `general` and the task was created with `prompt_v2`. When present, the response excludes the flat `prompt` field.<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): `input_text` is truncated to the first 30 characters.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>? PromptV2 { get; set; }

        /// <summary>
        /// The response format for this task. Present only when the request included a response format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>? ResponseFormat { get; set; }

        /// <summary>
        /// The temperature value for this analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// The minimum segment duration you set, in seconds. Present when `analysis_mode` is `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_segment_duration")]
        public double? MinSegmentDuration { get; set; }

        /// <summary>
        /// The maximum segment duration you set, in seconds. Present when `analysis_mode` is `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_duration")]
        public double? MaxSegmentDuration { get; set; }

        /// <summary>
        /// The start of the analysis window, in seconds. Present only when the task was created with `start_time`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// The end of the analysis window, in seconds. Present only when the task was created with `end_time`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public double? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParams" /> class.
        /// </summary>
        /// <param name="analysisMode">
        /// The analysis approach for this task.
        /// </param>
        /// <param name="prompt">
        /// The natural-language prompt for this task. Present only when `analysis_mode` is `general` and the task was created with `prompt` (not `prompt_v2`).<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): Truncated to the first 30 characters.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full text.
        /// </param>
        /// <param name="promptV2">
        /// The structured prompt for this task. Present only when `analysis_mode` is `general` and the task was created with `prompt_v2`. When present, the response excludes the flat `prompt` field.<br/>
        /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): `input_text` is truncated to the first 30 characters.<br/>
        /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full text.
        /// </param>
        /// <param name="responseFormat">
        /// The response format for this task. Present only when the request included a response format.
        /// </param>
        /// <param name="temperature">
        /// The temperature value for this analysis.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens for the response.
        /// </param>
        /// <param name="minSegmentDuration">
        /// The minimum segment duration you set, in seconds. Present when `analysis_mode` is `time_based_metadata`.
        /// </param>
        /// <param name="maxSegmentDuration">
        /// The maximum segment duration you set, in seconds. Present when `analysis_mode` is `time_based_metadata`.
        /// </param>
        /// <param name="startTime">
        /// The start of the analysis window, in seconds. Present only when the task was created with `start_time`.
        /// </param>
        /// <param name="endTime">
        /// The end of the analysis window, in seconds. Present only when the task was created with `end_time`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParams(
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? analysisMode,
            string? prompt,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2, object>? promptV2,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>? responseFormat,
            double? temperature,
            int? maxTokens,
            double? minSegmentDuration,
            double? maxSegmentDuration,
            double? startTime,
            double? endTime)
        {
            this.AnalysisMode = analysisMode;
            this.Prompt = prompt;
            this.PromptV2 = promptV2;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MinSegmentDuration = minSegmentDuration;
            this.MaxSegmentDuration = maxSegmentDuration;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParams" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParams()
        {
        }
    }
}