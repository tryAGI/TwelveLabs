#nullable enable

namespace TwelveLabs
{
    public partial interface ITwelveLabsClient
    {
        /// <summary>
        /// Sync analysis<br/>
        /// This method synchronously analyzes your videos and generates fully customizable text based on your prompts.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without waiting for asynchronous processing<br/>
        /// - Stream text fragments in real-time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
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
        /// This method synchronously analyzes your videos and generates fully customizable text based on your prompts.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without waiting for asynchronous processing<br/>
        /// - Stream text fragments in real-time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="videoId">
        /// The unique identifier of the video to analyze.<br/>
        /// &lt;Info&gt; This parameter will be deprecated and removed in a future version. Use the [`video`](/v1.3/api-reference/analyze-videos/sync-analysis#request.body.video) parameter instead.&lt;/Info&gt;
        /// </param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
        /// </param>
        /// <param name="prompt">
        /// A prompt that guides the model on the desired format or content.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Even though the model behind this endpoint is trained to a high degree of accuracy, the preciseness of the generated text may vary based on the nature and quality of the video and the clarity of the prompt.<br/>
        /// - Your prompts can be instructive or descriptive, or you can also phrase them as questions.<br/>
        /// - The maximum length of a prompt is 2,000 tokens.<br/>
        /// &lt;/Note&gt;<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
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
        /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// **Min**: 1 **Max:** 4096
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeResponse200> AnalyzeAsync(
            string xApiKey,
            string prompt,
            string? videoId = default,
            global::TwelveLabs.VideoContext? video = default,
            double? temperature = default,
            bool? stream = default,
            global::TwelveLabs.ResponseFormat? responseFormat = default,
            int? maxTokens = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}