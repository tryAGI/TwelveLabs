#nullable enable

namespace TwelveLabs
{
    public partial interface ITwelveLabsClient
    {
        /// <summary>
        /// Sync analysis<br/>
        /// This method analyzes your videos and returns the results directly in the response. It supports general analysis (prompt-based text generation).<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without polling for task completion<br/>
        /// - Stream text fragments in real time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// - Video segmentation with custom segment definitions. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// On the Free plan, you have a total of 600 minutes (10 hours) shared across indexing, analysis, and segmentation. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeResponse200> AnalyzeAsync(
            string xApiKey,

            global::TwelveLabs.AnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync analysis<br/>
        /// This method analyzes your videos and returns the results directly in the response. It supports general analysis (prompt-based text generation).<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without polling for task completion<br/>
        /// - Stream text fragments in real time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// - Video segmentation with custom segment definitions. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// On the Free plan, you have a total of 600 minutes (10 hours) shared across indexing, analysis, and segmentation. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeResponse200>> AnalyzeAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.AnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync analysis<br/>
        /// This method analyzes your videos and returns the results directly in the response. It supports general analysis (prompt-based text generation).<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without polling for task completion<br/>
        /// - Stream text fragments in real time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// - Video segmentation with custom segment definitions. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// On the Free plan, you have a total of 600 minutes (10 hours) shared across indexing, analysis, and segmentation. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="modelName">
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.5`: General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, and video segmentation (async only). See the [Pegasus](/v1.3/docs/concepts/models/pegasus#context-window) page for token limits.<br/>
        /// **Default:** `pegasus1.5`<br/>
        /// Default Value: pegasus1.5
        /// </param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
        /// </param>
        /// <param name="prompt">
        /// A text prompt that guides the model on the desired format or content. To include reference images in your prompt, use the `prompt_v2` parameter instead. Mutually exclusive with the `prompt_v2` parameter.<br/>
        /// Your prompts can be instructive or descriptive, or you can phrase them as questions. This text counts toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </param>
        /// <param name="promptV2">
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Mutually exclusive with the `prompt` parameter.<br/>
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
        /// The maximum response length, in tokens.<br/>
        /// Default Value: 4096
        /// </param>
        /// <param name="startTime">
        /// Start of the analysis window, as an absolute timestamp in seconds, based on the internal metadata of the video. Use with `end_time` to analyze only a portion of the video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the internal start time of the video.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be less than `end_time` and less than the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="endTime">
        /// End of the analysis window, as an absolute timestamp in seconds, based on the internal metadata of the video. Use with `start_time` to analyze only a portion of the video.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the internal start time of the video plus its duration.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeResponse200> AnalyzeAsync(
            string xApiKey,
            global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? modelName = default,
            global::TwelveLabs.VideoContext? video = default,
            string? prompt = default,
            global::TwelveLabs.AnalyzePromptV2? promptV2 = default,
            double? temperature = default,
            bool? stream = default,
            global::TwelveLabs.SyncResponseFormat? responseFormat = default,
            int? maxTokens = default,
            double? startTime = default,
            double? endTime = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}