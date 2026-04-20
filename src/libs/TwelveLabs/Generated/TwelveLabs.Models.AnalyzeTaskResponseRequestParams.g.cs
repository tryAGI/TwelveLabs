
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The parameters you sent when creating this task. Only present for tasks created with `model_name` set to `pegasus1.5`.
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
        /// The response format you configured. Present only when you included it in the request.
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
        /// <param name="responseFormat">
        /// The response format you configured. Present only when you included it in the request.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParams(
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsAnalysisMode? analysisMode,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormat, object>? responseFormat,
            double? temperature,
            int? maxTokens,
            double? minSegmentDuration,
            double? maxSegmentDuration)
        {
            this.AnalysisMode = analysisMode;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MinSegmentDuration = minSegmentDuration;
            this.MaxSegmentDuration = maxSegmentDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParams" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParams()
        {
        }
    }
}