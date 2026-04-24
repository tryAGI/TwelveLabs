
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Defines the asynchronous analysis request.
    /// </summary>
    public sealed partial class CreateAsyncAnalyzeRequest
    {
        /// <summary>
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.2` (default): Analyzes pre-indexed videos. Pass a `video_id` to reference your video.<br/>
        /// - `pegasus1.5`: Analyzes videos directly from a URL, asset, or base64 string. Supports video segmentation with custom segment definitions.<br/>
        /// Default Value: pegasus1.2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestModelNameJsonConverter))]
        public global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? ModelName { get; set; }

        /// <summary>
        /// An optional identifier that you set when you create the task. Use this field to correlate tasks across responses, for example, to distinguish tasks by type or environment.<br/>
        /// The platform stores this value unchanged and returns it in the following responses:<br/>
        /// - The [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint<br/>
        /// - The [`GET`](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks) method of the `/analyze/tasks` endpoint<br/>
        /// - The `analyze.task.ready` and `analyze.task.failed` webhook payloads<br/>
        /// **Format**: 1–64 characters. Alphanumeric, hyphens (`-`), and underscores (`_`) only. An empty string is rejected with a `400 Bad Request`.<br/>
        /// This field does not enforce uniqueness. You can submit multiple tasks with the same `custom_id`. To prevent duplicate task creation, use an `Idempotency-Key` header instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// An object specifying the source of the video content. Include exactly one source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.VideoContext Video { get; set; }

        /// <summary>
        /// A natural-language text that provides instructions for analyzing the video. Required for general-mode analysis. Not supported when `analysis_mode` is `time_based_metadata`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Even though the model behind this endpoint is trained to a high degree of accuracy, the preciseness of the generated text may vary based on the nature and quality of the video and the clarity of the prompt.<br/>
        /// - Your prompts can be instructive or descriptive, or you can also phrase them as questions.<br/>
        /// - The maximum length of a prompt is 2,000 tokens.<br/>
        /// &lt;/Note&gt;<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Sets the analysis mode to `time_based_metadata`, which segments your video into time-based intervals and extracts custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAsyncAnalyzeRequestAnalysisModeJsonConverter))]
        public global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? AnalysisMode { get; set; }

        /// <summary>
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate. The allowed range depends on the model:<br/>
        /// - `pegasus1.2`: **Min:** 1, **Max:** 4,096<br/>
        /// - `pegasus1.5`: **Min:** 2,048, **Max:** 32,768, **Default:** 32,768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::TwelveLabs.AsyncResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Minimum duration for each extracted segment, in seconds. Set this to prevent the model from creating very short segments. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_segment_duration")]
        public double? MinSegmentDuration { get; set; }

        /// <summary>
        /// Maximum duration for each extracted segment, in seconds. Set this to break long continuous sections into shorter segments. Must be greater than or equal to `min_segment_duration`. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_duration")]
        public double? MaxSegmentDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncAnalyzeRequest" /> class.
        /// </summary>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.2` (default): Analyzes pre-indexed videos. Pass a `video_id` to reference your video.<br/>
        /// - `pegasus1.5`: Analyzes videos directly from a URL, asset, or base64 string. Supports video segmentation with custom segment definitions.<br/>
        /// Default Value: pegasus1.2
        /// </param>
        /// <param name="customId">
        /// An optional identifier that you set when you create the task. Use this field to correlate tasks across responses, for example, to distinguish tasks by type or environment.<br/>
        /// The platform stores this value unchanged and returns it in the following responses:<br/>
        /// - The [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint<br/>
        /// - The [`GET`](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks) method of the `/analyze/tasks` endpoint<br/>
        /// - The `analyze.task.ready` and `analyze.task.failed` webhook payloads<br/>
        /// **Format**: 1–64 characters. Alphanumeric, hyphens (`-`), and underscores (`_`) only. An empty string is rejected with a `400 Bad Request`.<br/>
        /// This field does not enforce uniqueness. You can submit multiple tasks with the same `custom_id`. To prevent duplicate task creation, use an `Idempotency-Key` header instead.
        /// </param>
        /// <param name="prompt">
        /// A natural-language text that provides instructions for analyzing the video. Required for general-mode analysis. Not supported when `analysis_mode` is `time_based_metadata`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Even though the model behind this endpoint is trained to a high degree of accuracy, the preciseness of the generated text may vary based on the nature and quality of the video and the clarity of the prompt.<br/>
        /// - Your prompts can be instructive or descriptive, or you can also phrase them as questions.<br/>
        /// - The maximum length of a prompt is 2,000 tokens.<br/>
        /// &lt;/Note&gt;<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
        /// </param>
        /// <param name="analysisMode">
        /// Sets the analysis mode to `time_based_metadata`, which segments your video into time-based intervals and extracts custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate. The allowed range depends on the model:<br/>
        /// - `pegasus1.2`: **Min:** 1, **Max:** 4,096<br/>
        /// - `pegasus1.5`: **Min:** 2,048, **Max:** 32,768, **Default:** 32,768
        /// </param>
        /// <param name="responseFormat">
        /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </param>
        /// <param name="minSegmentDuration">
        /// Minimum duration for each extracted segment, in seconds. Set this to prevent the model from creating very short segments. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="maxSegmentDuration">
        /// Maximum duration for each extracted segment, in seconds. Set this to break long continuous sections into shorter segments. Must be greater than or equal to `min_segment_duration`. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAsyncAnalyzeRequest(
            global::TwelveLabs.VideoContext video,
            global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? modelName,
            string? customId,
            string? prompt,
            global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? analysisMode,
            double? temperature,
            int? maxTokens,
            global::TwelveLabs.AsyncResponseFormat? responseFormat,
            double? minSegmentDuration,
            double? maxSegmentDuration)
        {
            this.ModelName = modelName;
            this.CustomId = customId;
            this.Video = video;
            this.Prompt = prompt;
            this.AnalysisMode = analysisMode;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ResponseFormat = responseFormat;
            this.MinSegmentDuration = minSegmentDuration;
            this.MaxSegmentDuration = maxSegmentDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncAnalyzeRequest" /> class.
        /// </summary>
        public CreateAsyncAnalyzeRequest()
        {
        }
    }
}