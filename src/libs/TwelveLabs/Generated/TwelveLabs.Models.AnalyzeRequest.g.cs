
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeRequest
    {
        /// <summary>
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.2`: General analysis (prompt-based text generation).<br/>
        /// - `pegasus1.5`: General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, and video segmentation (async only). See the [Pegasus](/v1.3/docs/concepts/models/pegasus#context-window) page for token limits.<br/>
        /// **Default:** `pegasus1.2`<br/>
        /// Default Value: pegasus1.2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzePostRequestBodyContentApplicationJsonSchemaModelNameJsonConverter))]
        public global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? ModelName { get; set; }

        /// <summary>
        /// The unique identifier of the video to analyze. Use this parameter when the `model_name` parameter is `pegasus1.2`. Not supported with `pegasus1.5`.<br/>
        /// &lt;Info&gt; This parameter will be deprecated and removed in a future version. Use the [`video`](/v1.3/api-reference/analyze-videos/sync-analysis#request.body.video) parameter instead.&lt;/Info&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// An object specifying the source of the video content. Include exactly one source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.VideoContextJsonConverter))]
        public global::TwelveLabs.VideoContext? Video { get; set; }

        /// <summary>
        /// A text prompt that guides the model on the desired format or content. Works with both Pegasus 1.2 and Pegasus 1.5. To include reference images in your prompt, use the `prompt_v2` parameter instead (Pegasus 1.5 only). Mutually exclusive with the `prompt_v2` parameter.<br/>
        /// Your prompts can be instructive or descriptive, or you can phrase them as questions. Pegasus 1.2 limits prompts to 2,000 tokens. For Pegasus 1.5, this text counts toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Requires the `model_name` parameter set to `pegasus1.5`. Mutually exclusive with the `prompt` parameter.<br/>
        /// The prompt text and reference images count toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        public global::TwelveLabs.AnalyzePromptV2? PromptV2 { get; set; }

        /// <summary>
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Set this parameter to `true` to enable streaming responses in the &lt;a href="https://github.com/ndjson/ndjson-spec" target="_blank"&gt;NDJSON&lt;/a&gt; format.<br/>
        /// **Default:** `true`<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text. Only the `json_schema` type is supported for synchronous analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::TwelveLabs.SyncResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The maximum response length, in tokens. The allowed range depends on the model:<br/>
        /// | Model | Min | Max | Default |<br/>
        /// |-------|-----|-----|---------|<br/>
        /// | Pegasus 1.2 | 2 | 4,096 | 4,096 |<br/>
        /// | Pegasus 1.5 | 512 | 98,304 | 4,096 |
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Start of the analysis window, as an absolute timestamp in seconds, based on the video's internal metadata. Use with `end_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video's internal start time.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be less than `end_time` and less than the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// End of the analysis window, as an absolute timestamp in seconds, based on the video's internal metadata. Use with `start_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video's internal start time plus its duration.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
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
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.2`: General analysis (prompt-based text generation).<br/>
        /// - `pegasus1.5`: General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, and video segmentation (async only). See the [Pegasus](/v1.3/docs/concepts/models/pegasus#context-window) page for token limits.<br/>
        /// **Default:** `pegasus1.2`<br/>
        /// Default Value: pegasus1.2
        /// </param>
        /// <param name="videoId">
        /// The unique identifier of the video to analyze. Use this parameter when the `model_name` parameter is `pegasus1.2`. Not supported with `pegasus1.5`.<br/>
        /// &lt;Info&gt; This parameter will be deprecated and removed in a future version. Use the [`video`](/v1.3/api-reference/analyze-videos/sync-analysis#request.body.video) parameter instead.&lt;/Info&gt;
        /// </param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
        /// </param>
        /// <param name="prompt">
        /// A text prompt that guides the model on the desired format or content. Works with both Pegasus 1.2 and Pegasus 1.5. To include reference images in your prompt, use the `prompt_v2` parameter instead (Pegasus 1.5 only). Mutually exclusive with the `prompt_v2` parameter.<br/>
        /// Your prompts can be instructive or descriptive, or you can phrase them as questions. Pegasus 1.2 limits prompts to 2,000 tokens. For Pegasus 1.5, this text counts toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </param>
        /// <param name="promptV2">
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Requires the `model_name` parameter set to `pegasus1.5`. Mutually exclusive with the `prompt` parameter.<br/>
        /// The prompt text and reference images count toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="stream">
        /// Set this parameter to `true` to enable streaming responses in the &lt;a href="https://github.com/ndjson/ndjson-spec" target="_blank"&gt;NDJSON&lt;/a&gt; format.<br/>
        /// **Default:** `true`<br/>
        /// Default Value: true
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text. Only the `json_schema` type is supported for synchronous analysis.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum response length, in tokens. The allowed range depends on the model:<br/>
        /// | Model | Min | Max | Default |<br/>
        /// |-------|-----|-----|---------|<br/>
        /// | Pegasus 1.2 | 2 | 4,096 | 4,096 |<br/>
        /// | Pegasus 1.5 | 512 | 98,304 | 4,096 |
        /// </param>
        /// <param name="startTime">
        /// Start of the analysis window, as an absolute timestamp in seconds, based on the video's internal metadata. Use with `end_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video's internal start time.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be less than `end_time` and less than the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="endTime">
        /// End of the analysis window, as an absolute timestamp in seconds, based on the video's internal metadata. Use with `start_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video's internal start time plus its duration.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeRequest(
            global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? modelName,
            string? videoId,
            global::TwelveLabs.VideoContext? video,
            string? prompt,
            global::TwelveLabs.AnalyzePromptV2? promptV2,
            double? temperature,
            bool? stream,
            global::TwelveLabs.SyncResponseFormat? responseFormat,
            int? maxTokens,
            double? startTime,
            double? endTime)
        {
            this.ModelName = modelName;
            this.VideoId = videoId;
            this.Video = video;
            this.Prompt = prompt;
            this.PromptV2 = promptV2;
            this.Temperature = temperature;
            this.Stream = stream;
            this.ResponseFormat = responseFormat;
            this.MaxTokens = maxTokens;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
        public AnalyzeRequest()
        {
        }

    }
}