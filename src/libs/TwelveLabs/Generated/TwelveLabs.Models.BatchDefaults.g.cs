
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Default values applied to every item that does not override them. Every field is optional. Items in the `requests` array override these values. To override the `prompt` or `response_format` field, provide the full object on the item. You cannot change only some of its nested fields.
    /// </summary>
    public sealed partial class BatchDefaults
    {
        /// <summary>
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Not supported when `analysis_mode` is `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::TwelveLabs.BatchPrompt? Prompt { get; set; }

        /// <summary>
        /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::TwelveLabs.AsyncResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate per item. The allowed range depends on the model and analysis mode (see the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint for the per-mode table).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Minimum duration for each extracted segment, in seconds. Applies only when the `analysis_mode` field is `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_segment_duration")]
        public double? MinSegmentDuration { get; set; }

        /// <summary>
        /// Maximum duration for each extracted segment, in seconds. Must be greater than or equal to the `min_segment_duration` field. Applies only when the `analysis_mode` field is `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_segment_duration")]
        public double? MaxSegmentDuration { get; set; }

        /// <summary>
        /// Start of the analysis window, in seconds, applied to every item. Use with `end_time` to analyze only the `[start_time, end_time)` portion of each video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to `0`.<br/>
        /// - Must be less than `end_time`.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// End of the analysis window, in seconds, applied to every item. Use with `start_time` to analyze only the `[start_time, end_time)` portion of each video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video duration.<br/>
        /// - Must be greater than `start_time`.<br/>
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
        /// Initializes a new instance of the <see cref="BatchDefaults" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Not supported when `analysis_mode` is `time_based_metadata`.
        /// </param>
        /// <param name="responseFormat">
        /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate per item. The allowed range depends on the model and analysis mode (see the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint for the per-mode table).
        /// </param>
        /// <param name="minSegmentDuration">
        /// Minimum duration for each extracted segment, in seconds. Applies only when the `analysis_mode` field is `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="maxSegmentDuration">
        /// Maximum duration for each extracted segment, in seconds. Must be greater than or equal to the `min_segment_duration` field. Applies only when the `analysis_mode` field is `time_based_metadata`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="startTime">
        /// Start of the analysis window, in seconds, applied to every item. Use with `end_time` to analyze only the `[start_time, end_time)` portion of each video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to `0`.<br/>
        /// - Must be less than `end_time`.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="endTime">
        /// End of the analysis window, in seconds, applied to every item. Use with `start_time` to analyze only the `[start_time, end_time)` portion of each video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video duration.<br/>
        /// - Must be greater than `start_time`.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchDefaults(
            global::TwelveLabs.BatchPrompt? prompt,
            global::TwelveLabs.AsyncResponseFormat? responseFormat,
            double? temperature,
            int? maxTokens,
            double? minSegmentDuration,
            double? maxSegmentDuration,
            double? startTime,
            double? endTime)
        {
            this.Prompt = prompt;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.MinSegmentDuration = minSegmentDuration;
            this.MaxSegmentDuration = maxSegmentDuration;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDefaults" /> class.
        /// </summary>
        public BatchDefaults()
        {
        }

    }
}