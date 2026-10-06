#nullable enable

namespace TwelveLabs
{
    public partial interface IAnalyzeAsyncTasksClient
    {
        /// <summary>
        /// Create an async analysis task<br/>
        /// This method analyzes a video or one or more images asynchronously. Each request must contain a video or one or more images, but not both.<br/>
        /// The method supports two analysis modes:<br/>
        /// - **General analysis**: Prompt-based text generation with a video or one or more images.<br/>
        /// - **Video segmentation**: Timestamped metadata with custom segment definitions.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// **Videos**<br/>
        /// - The video can be up to 2 hours long, or up to 4 hours when you analyze only a portion of it. You can analyze between 1 second and 2 hours of the video. HLS and base64 videos are limited to 2 hours.<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// **Images**<br/>
        /// - You can provide one to twenty images per request.<br/>
        /// - Formats: JPEG, PNG, WebP, GIF, and BMP.<br/>
        /// - Maximum size: 20 MB per image.<br/>
        /// - Maximum pixel count: 16,777,216 pixels per image (width × height).<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Generate custom text from your video or one or more images using a prompt (general analysis)<br/>
        /// - Extract timestamped metadata with custom segment definitions from your video<br/>
        /// - Analyze videos longer than 1 hour, or a portion of a video up to 4 hours long<br/>
        /// - Process videos or images asynchronously without blocking your application<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos or images for which you need immediate results or real-time streaming. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// Analyzing content asynchronously requires three steps:<br/>
        /// 1. Create an analysis task using this method. The platform returns a task identifier.<br/>
        /// 2. Poll the status of the task using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint. Wait until the status is `ready`, `failed`, or `canceled`.<br/>
        /// 3. When the status is `ready`, retrieve the results using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint.<br/>
        /// On the Free plan, you have a total of 600 minutes (10 hours) shared across indexing, analysis, and segmentation. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.CreateAnalyzeTaskResponse> CreateAsync(

            global::TwelveLabs.CreateAsyncAnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async analysis task<br/>
        /// This method analyzes a video or one or more images asynchronously. Each request must contain a video or one or more images, but not both.<br/>
        /// The method supports two analysis modes:<br/>
        /// - **General analysis**: Prompt-based text generation with a video or one or more images.<br/>
        /// - **Video segmentation**: Timestamped metadata with custom segment definitions.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// **Videos**<br/>
        /// - The video can be up to 2 hours long, or up to 4 hours when you analyze only a portion of it. You can analyze between 1 second and 2 hours of the video. HLS and base64 videos are limited to 2 hours.<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// **Images**<br/>
        /// - You can provide one to twenty images per request.<br/>
        /// - Formats: JPEG, PNG, WebP, GIF, and BMP.<br/>
        /// - Maximum size: 20 MB per image.<br/>
        /// - Maximum pixel count: 16,777,216 pixels per image (width × height).<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Generate custom text from your video or one or more images using a prompt (general analysis)<br/>
        /// - Extract timestamped metadata with custom segment definitions from your video<br/>
        /// - Analyze videos longer than 1 hour, or a portion of a video up to 4 hours long<br/>
        /// - Process videos or images asynchronously without blocking your application<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos or images for which you need immediate results or real-time streaming. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// Analyzing content asynchronously requires three steps:<br/>
        /// 1. Create an analysis task using this method. The platform returns a task identifier.<br/>
        /// 2. Poll the status of the task using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint. Wait until the status is `ready`, `failed`, or `canceled`.<br/>
        /// 3. When the status is `ready`, retrieve the results using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint.<br/>
        /// On the Free plan, you have a total of 600 minutes (10 hours) shared across indexing, analysis, and segmentation. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.CreateAnalyzeTaskResponse>> CreateAsResponseAsync(

            global::TwelveLabs.CreateAsyncAnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async analysis task<br/>
        /// This method analyzes a video or one or more images asynchronously. Each request must contain a video or one or more images, but not both.<br/>
        /// The method supports two analysis modes:<br/>
        /// - **General analysis**: Prompt-based text generation with a video or one or more images.<br/>
        /// - **Video segmentation**: Timestamped metadata with custom segment definitions.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// **Videos**<br/>
        /// - The video can be up to 2 hours long, or up to 4 hours when you analyze only a portion of it. You can analyze between 1 second and 2 hours of the video. HLS and base64 videos are limited to 2 hours.<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// **Images**<br/>
        /// - You can provide one to twenty images per request.<br/>
        /// - Formats: JPEG, PNG, WebP, GIF, and BMP.<br/>
        /// - Maximum size: 20 MB per image.<br/>
        /// - Maximum pixel count: 16,777,216 pixels per image (width × height).<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Generate custom text from your video or one or more images using a prompt (general analysis)<br/>
        /// - Extract timestamped metadata with custom segment definitions from your video<br/>
        /// - Analyze videos longer than 1 hour, or a portion of a video up to 4 hours long<br/>
        /// - Process videos or images asynchronously without blocking your application<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos or images for which you need immediate results or real-time streaming. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// Analyzing content asynchronously requires three steps:<br/>
        /// 1. Create an analysis task using this method. The platform returns a task identifier.<br/>
        /// 2. Poll the status of the task using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint. Wait until the status is `ready`, `failed`, or `canceled`.<br/>
        /// 3. When the status is `ready`, retrieve the results using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint.<br/>
        /// On the Free plan, you have a total of 600 minutes (10 hours) shared across indexing, analysis, and segmentation. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="modelName">
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.6`: For details about this version, see the [Pegasus 1.6](/v1.3/docs/concepts/models/pegasus/pegasus-1-6) page.<br/>
        /// - `pegasus1.5`: For details about this version, see the [Pegasus 1.5](/v1.3/docs/concepts/models/pegasus/pegasus-1-5) page.<br/>
        /// **Default:** `pegasus1.5`<br/>
        /// Default Value: pegasus1.5
        /// </param>
        /// <param name="customId">
        /// An optional identifier that you set when you create the task. Use this field to correlate tasks across responses, for example, to distinguish tasks by type or environment.<br/>
        /// The platform stores this value unchanged and returns it in the following responses:<br/>
        /// - The [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint<br/>
        /// - The [`GET`](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks) method of the `/analyze/tasks` endpoint<br/>
        /// - The `analyze.task.ready`, `analyze.task.failed`, and `analyze.task.canceled` webhook payloads<br/>
        /// **Format**: 1–64 characters. Alphanumeric, hyphens (`-`), and underscores (`_`) only. An empty string is rejected with a `400 Bad Request`.<br/>
        /// This field does not enforce uniqueness. You can submit multiple tasks with the same `custom_id`. To prevent duplicate task creation, use an `Idempotency-Key` header instead.
        /// </param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source. Mutually exclusive with the `image` parameter.
        /// </param>
        /// <param name="image">
        /// A list of up to twenty objects containing the images to analyze. For each image, include exactly one source. Requires Pegasus 1.6. Using any other model returns a `parameter_invalid` error.<br/>
        /// Mutually exclusive with the `video` and `prompt_v2` parameters. The `prompt` parameter is required when you provide images.
        /// </param>
        /// <param name="prompt">
        /// Natural-language instructions for analyzing the video or one or more images. Required for general analysis (prompt-based text generation). Not supported when `analysis_mode` is `time_based_metadata`. To include reference images in your prompt, use the `prompt_v2` parameter instead. Mutually exclusive with the `prompt_v2` parameter.<br/>
        /// Your prompts can be instructive or descriptive, or you can phrase them as questions. This text counts toward the [context window](/v1.3/docs/concepts/models/pegasus/pegasus-1-6#context-window).<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
        /// </param>
        /// <param name="promptV2">
        /// A structured prompt that uses `&lt;@name&gt;` placeholders to reference images. Mutually exclusive with the `prompt` and `image` parameters.<br/>
        /// The prompt text and reference images count toward the [context window](/v1.3/docs/concepts/models/pegasus/pegasus-1-6#context-window).
        /// </param>
        /// <param name="analysisMode">
        /// The analysis mode for this task.<br/>
        /// - `general`: Analyze the video and generate a response based on your prompt. Supports both free-form text and structured output via `response_format`.<br/>
        /// - `time_based_metadata`: Segment the video into time-based intervals and extract custom metadata for each segment. Requires `response_format.type` set to `segment_definitions`.<br/>
        /// **Default:** `general`<br/>
        /// Default Value: general
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum response length, in tokens. Provide an integer or the `unlimited` value.<br/>
        /// The allowed integer range and default depend on the analysis mode:<br/>
        /// | Mode | Min | Max | Default |<br/>
        /// |------|-----|-----|---------|<br/>
        /// | `general` | 512 | 98,304 | 4,096 |<br/>
        /// | `time_based_metadata` | 2,048 | 98,304 | 32,768 |<br/>
        /// - **Integer**: With video segmentation, the task fails if the output exceeds the limit. No partial output is returned.<br/>
        /// - **Unlimited**: Removes the token limit from video segmentation. It requires `analysis_mode` set to `time_based_metadata` and `model_name` set to `pegasus1.6`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        ///   The platform extracts as many segments as it can. If it stops before extracting every segment, the task still completes with the `status` field set to `ready`. The `error` field contains the warning that the results may be incomplete.
        /// </param>
        /// <param name="responseFormat">
        /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `analysis_mode` set to `time_based_metadata`.
        /// </param>
        /// <param name="minSegmentDuration">
        /// Minimum duration for each extracted segment, in seconds. Set this value to enforce a minimum segment length. Requires `analysis_mode` set to `time_based_metadata`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="maxSegmentDuration">
        /// Maximum duration for each extracted segment, in seconds. Set this value to split long continuous sections into shorter segments. Must be greater than or equal to `min_segment_duration`. Requires `analysis_mode` set to `time_based_metadata`. Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// **Min:** 2
        /// </param>
        /// <param name="startTime">
        /// Start of the analysis window, as an absolute timestamp in seconds, based on the internal metadata of the video. Use with `end_time` to analyze only a portion of the video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the internal start time of the video.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be less than `end_time` and the video duration.<br/>
        /// - The window (`end_time - start_time`) must be at least 1 second and at most 2 hours. The video may be up to 4 hours as long as the window stays within that limit.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// - Together with `end_time`, this parameter determines the billable video duration. If you omit both, billing uses the full video duration. For details, see the [Frequently asked questions](/v1.3/docs/resources/frequently-asked-questions#how-is-video-segmentation-priced) page.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="endTime">
        /// End of the analysis window, as an absolute timestamp in seconds, based on the internal metadata of the video. Use with `start_time` to analyze only a portion of the video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the internal start time of the video plus its duration.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration.<br/>
        /// - The window (`end_time - start_time`) must be at least 1 second and at most 2 hours. The video may be up to 4 hours as long as the window stays within that limit.<br/>
        /// - Mutually exclusive with `response_format.segment_definitions[].time_ranges`.<br/>
        /// - Together with `start_time`, this parameter determines the billable video duration. If you omit both, billing uses the full video duration. For details, see the [Frequently asked questions](/v1.3/docs/resources/frequently-asked-questions#how-is-video-segmentation-priced) page.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.CreateAnalyzeTaskResponse> CreateAsync(
            global::TwelveLabs.CreateAsyncAnalyzeRequestModelName? modelName = default,
            string? customId = default,
            global::TwelveLabs.VideoContext? video = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeImageInput>? image = default,
            string? prompt = default,
            global::TwelveLabs.AnalyzePromptV2? promptV2 = default,
            global::TwelveLabs.CreateAsyncAnalyzeRequestAnalysisMode? analysisMode = default,
            double? temperature = default,
            global::TwelveLabs.CreateAsyncAnalyzeRequestMaxTokens? maxTokens = default,
            global::TwelveLabs.AsyncResponseFormat? responseFormat = default,
            double? minSegmentDuration = default,
            double? maxSegmentDuration = default,
            double? startTime = default,
            double? endTime = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}