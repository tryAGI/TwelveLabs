
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
        /// - `pegasus1.2`: Analyzes pre-indexed videos. Provide the `video_id` of your pre-indexed video.<br/>
        /// - `pegasus1.5`: Analyzes videos directly from a URL, asset, or base64 string. Supports both general analysis and video segmentation with custom segment definitions.<br/>
        /// **Default:** `pegasus1.2`<br/>
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
        /// Natural-language instructions for analyzing the video. Required for general analysis (prompt-based text generation). Not supported when `analysis_mode` is `time_based_metadata`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Even though the model behind this endpoint is trained to a high degree of accuracy, the preciseness of the generated text may vary based on the nature and quality of the video and the clarity of the prompt.<br/>
        /// - Your prompts can be instructive or descriptive, or you can also phrase them as questions.<br/>
        /// - The maximum length of a prompt is 2,000 tokens.<br/>
        /// - Provide either `prompt` or `prompt_v2`, not both.<br/>
        /// &lt;/Note&gt;<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Use this instead of the flat `prompt` string for general analysis (prompt-based text generation). Requires `model_name` set to `pegasus1.5`. Not supported when `analysis_mode` is `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        public global::TwelveLabs.AnalyzePromptV2? PromptV2 { get; set; }

        /// <summary>
        /// The analysis approach for this task.<br/>
        /// - `general`: Analyze the video and generate a response based on your prompt. Supports both free-form text and structured output via `response_format`.<br/>
        /// - `time_based_metadata`: Segment the video into time-based intervals and extract custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.<br/>
        /// **Default:** `general`<br/>
        /// Default Value: general
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
        /// The maximum number of tokens to generate. The allowed range depends on the model and analysis mode:<br/>
        /// | Model | Mode | Min | Max | Default |<br/>
        /// |-------|------|-----|-----|---------|<br/>
        /// | Pegasus 1.2 | — | 1 | 4,096 | 4096 |<br/>
        /// | Pegasus 1.5 | `general` | 512 | 65,536 | 4,096 |<br/>
        /// | Pegasus 1.5 | `time_based_metadata` | 2,048 | 65,536 | 32,768 |
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
        /// Minimum duration for each extracted segment, in seconds. Set this value to enforce a minimum segment length. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// **Min:** 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_segment_duration")]
        public double? MinSegmentDuration { get; set; }

        /// <summary>
        /// Maximum duration for each extracted segment, in seconds. Set this value to split long continuous sections into shorter segments. Must be greater than or equal to `min_segment_duration`. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// **Min:** 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_duration")]
        public double? MaxSegmentDuration { get; set; }

        /// <summary>
        /// Start of the analysis window, in seconds. Use with `end_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to `0`.<br/>
        /// - Must be less than `end_time` and less than the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// End of the analysis window, in seconds. Use with `start_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video duration.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public double? EndTime { get; set; }

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
        /// - `pegasus1.2`: Analyzes pre-indexed videos. Provide the `video_id` of your pre-indexed video.<br/>
        /// - `pegasus1.5`: Analyzes videos directly from a URL, asset, or base64 string. Supports both general analysis and video segmentation with custom segment definitions.<br/>
        /// **Default:** `pegasus1.2`<br/>
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
        /// Natural-language instructions for analyzing the video. Required for general analysis (prompt-based text generation). Not supported when `analysis_mode` is `time_based_metadata`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Even though the model behind this endpoint is trained to a high degree of accuracy, the preciseness of the generated text may vary based on the nature and quality of the video and the clarity of the prompt.<br/>
        /// - Your prompts can be instructive or descriptive, or you can also phrase them as questions.<br/>
        /// - The maximum length of a prompt is 2,000 tokens.<br/>
        /// - Provide either `prompt` or `prompt_v2`, not both.<br/>
        /// &lt;/Note&gt;<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
        /// </param>
        /// <param name="promptV2">
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Use this instead of the flat `prompt` string for general analysis (prompt-based text generation). Requires `model_name` set to `pegasus1.5`. Not supported when `analysis_mode` is `time_based_metadata`.
        /// </param>
        /// <param name="analysisMode">
        /// The analysis approach for this task.<br/>
        /// - `general`: Analyze the video and generate a response based on your prompt. Supports both free-form text and structured output via `response_format`.<br/>
        /// - `time_based_metadata`: Segment the video into time-based intervals and extract custom metadata for each segment. Requires `model_name` set to `pegasus1.5` and `response_format.type` set to `segment_definitions`.<br/>
        /// **Default:** `general`<br/>
        /// Default Value: general
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate. The allowed range depends on the model and analysis mode:<br/>
        /// | Model | Mode | Min | Max | Default |<br/>
        /// |-------|------|-----|-----|---------|<br/>
        /// | Pegasus 1.2 | — | 1 | 4,096 | 4096 |<br/>
        /// | Pegasus 1.5 | `general` | 512 | 65,536 | 4,096 |<br/>
        /// | Pegasus 1.5 | `time_based_metadata` | 2,048 | 65,536 | 32,768 |
        /// </param>
        /// <param name="responseFormat">
        /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </param>
        /// <param name="minSegmentDuration">
        /// Minimum duration for each extracted segment, in seconds. Set this value to enforce a minimum segment length. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="maxSegmentDuration">
        /// Maximum duration for each extracted segment, in seconds. Set this value to split long continuous sections into shorter segments. Must be greater than or equal to `min_segment_duration`. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="startTime">
        /// Start of the analysis window, in seconds. Use with `end_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to `0`.<br/>
        /// - Must be less than `end_time` and less than the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="endTime">
        /// End of the analysis window, in seconds. Use with `start_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video duration.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAsyncAnalyzeRequest(
            global::TwelveLabs.VideoContext video,
            global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? modelName,
            string? customId,
            string? prompt,
            global::TwelveLabs.AnalyzePromptV2? promptV2,
            global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? analysisMode,
            double? temperature,
            int? maxTokens,
            global::TwelveLabs.AsyncResponseFormat? responseFormat,
            double? minSegmentDuration,
            double? maxSegmentDuration,
            double? startTime,
            double? endTime)
        {
            this.ModelName = modelName;
            this.CustomId = customId;
            this.Video = video;
            this.Prompt = prompt;
            this.PromptV2 = promptV2;
            this.AnalysisMode = analysisMode;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ResponseFormat = responseFormat;
            this.MinSegmentDuration = minSegmentDuration;
            this.MaxSegmentDuration = maxSegmentDuration;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncAnalyzeRequest" /> class.
        /// </summary>
        public CreateAsyncAnalyzeRequest()
        {
        }
    }
}