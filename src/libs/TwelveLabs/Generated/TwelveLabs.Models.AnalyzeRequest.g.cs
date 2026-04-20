
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeRequest
    {
        /// <summary>
        /// The unique identifier of the video to analyze.<br/>
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
        /// A prompt that guides the model on the desired format or content.<br/>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

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
        /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::TwelveLabs.SyncResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.<br/>
        /// **Min**: 1 **Max:** 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
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
        /// <param name="videoId">
        /// The unique identifier of the video to analyze.<br/>
        /// &lt;Info&gt; This parameter will be deprecated and removed in a future version. Use the [`video`](/v1.3/api-reference/analyze-videos/sync-analysis#request.body.video) parameter instead.&lt;/Info&gt;
        /// </param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeRequest(
            string prompt,
            string? videoId,
            global::TwelveLabs.VideoContext? video,
            double? temperature,
            bool? stream,
            global::TwelveLabs.SyncResponseFormat? responseFormat,
            int? maxTokens)
        {
            this.VideoId = videoId;
            this.Video = video;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Temperature = temperature;
            this.Stream = stream;
            this.ResponseFormat = responseFormat;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeRequest" /> class.
        /// </summary>
        public AnalyzeRequest()
        {
        }
    }
}