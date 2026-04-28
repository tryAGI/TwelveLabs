
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The structured prompt for this task. Present only when `analysis_mode` is `general` and the task was created with `prompt_v2`. When present, the response excludes the flat `prompt` field.<br/>
    /// - [List](/v1.3/api-reference/analyze-videos/list-async-analysis-tasks): `input_text` is truncated to the first 30 characters.<br/>
    /// - [Retrieve](/v1.3/api-reference/analyze-videos/retrieve-analysis-task): Returns the full text.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParamsPromptV2
    {
        /// <summary>
        /// The prompt text. May contain `&lt;@name&gt;` placeholders that reference entries in `media_sources`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Reference images linked to `&lt;@name&gt;` placeholders in the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_sources")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems>? MediaSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsPromptV2" /> class.
        /// </summary>
        /// <param name="inputText">
        /// The prompt text. May contain `&lt;@name&gt;` placeholders that reference entries in `media_sources`.
        /// </param>
        /// <param name="mediaSources">
        /// Reference images linked to `&lt;@name&gt;` placeholders in the prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParamsPromptV2(
            string? inputText,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsPromptV2MediaSourcesItems>? mediaSources)
        {
            this.InputText = inputText;
            this.MediaSources = mediaSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsPromptV2" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParamsPromptV2()
        {
        }
    }
}