
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Requires the `model_name` parameter set to `pegasus1.5`. Not supported when the `analysis_mode` parameter is `time_based_metadata`. Mutually exclusive with the `prompt` parameter.
    /// </summary>
    public sealed partial class AnalyzePromptV2
    {
        /// <summary>
        /// The text of the prompt. Use `&lt;@name&gt;` placeholders to reference images declared in `media_sources` (Example: `"Is there a &lt;@tiger-1&gt; in the video?"`). For Pegasus 1.5, this text counts toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputText { get; set; }

        /// <summary>
        /// Reference images for the `&lt;@name&gt;` placeholders in the prompt. Maximum 4 sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_sources")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? MediaSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzePromptV2" /> class.
        /// </summary>
        /// <param name="inputText">
        /// The text of the prompt. Use `&lt;@name&gt;` placeholders to reference images declared in `media_sources` (Example: `"Is there a &lt;@tiger-1&gt; in the video?"`). For Pegasus 1.5, this text counts toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </param>
        /// <param name="mediaSources">
        /// Reference images for the `&lt;@name&gt;` placeholders in the prompt. Maximum 4 sources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzePromptV2(
            string inputText,
            global::System.Collections.Generic.IList<global::TwelveLabs.SMEMediaSource>? mediaSources)
        {
            this.InputText = inputText ?? throw new global::System.ArgumentNullException(nameof(inputText));
            this.MediaSources = mediaSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzePromptV2" /> class.
        /// </summary>
        public AnalyzePromptV2()
        {
        }

    }
}