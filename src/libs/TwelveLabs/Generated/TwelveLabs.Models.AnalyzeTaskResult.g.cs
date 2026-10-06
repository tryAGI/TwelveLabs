
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The analysis results for a completed task.
    /// </summary>
    public sealed partial class AnalyzeTaskResult
    {
        /// <summary>
        /// The unique identifier for the generation session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The generated text for this analysis task. The format depends on the `analysis_mode` used when creating the task:<br/>
        /// - **When `analysis_mode` is not set**: A plain-text string containing the generated text based on the prompt you provided.<br/>
        /// - **When `analysis_mode` is `time_based_metadata`**: A JSON-encoded string containing an object keyed by segment definition (the `id` field). Each key maps to an array of segment objects with the following fields:<br/>
        ///   - `start_time` (number): The start time of the segment in seconds.<br/>
        ///   - `end_time` (number): The end time of the segment in seconds.<br/>
        ///   - `metadata` (object): The custom fields you defined in `segment_definitions[].fields`. The value of a `time_array` field is an array of event objects, one for each event inside the segment. Each event object contains `start_time` and `end_time`, which the platform adds automatically, plus the fields you declared in the `items.fields` array.<br/>
        ///     - Segments are within the duration of the video, and events are within the duration of their segment.<br/>
        ///     - The `min_segment_duration` and `max_segment_duration` values limit segments only, not the events inside them.<br/>
        ///     - Event boundaries use the same format as segment boundaries, set by the `segment_time_format` value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// When the task uses general analysis, `length` means the response reached the maximum response length or the context window. The partial output is in `data`, and a warning is in the task's `error` field.<br/>
        /// With video segmentation and a numeric `max_tokens`, the task fails when the analysis reaches either limit. This field is never `length` for a segmentation task. With `max_tokens` set to `unlimited`, this field is `stop` even when the output is incomplete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.FinishReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.FinishReason FinishReason { get; set; }

        /// <summary>
        /// The number of tokens used in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AnalyzeTaskResultUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResult" /> class.
        /// </summary>
        /// <param name="generationId">
        /// The unique identifier for the generation session.
        /// </param>
        /// <param name="data">
        /// The generated text for this analysis task. The format depends on the `analysis_mode` used when creating the task:<br/>
        /// - **When `analysis_mode` is not set**: A plain-text string containing the generated text based on the prompt you provided.<br/>
        /// - **When `analysis_mode` is `time_based_metadata`**: A JSON-encoded string containing an object keyed by segment definition (the `id` field). Each key maps to an array of segment objects with the following fields:<br/>
        ///   - `start_time` (number): The start time of the segment in seconds.<br/>
        ///   - `end_time` (number): The end time of the segment in seconds.<br/>
        ///   - `metadata` (object): The custom fields you defined in `segment_definitions[].fields`. The value of a `time_array` field is an array of event objects, one for each event inside the segment. Each event object contains `start_time` and `end_time`, which the platform adds automatically, plus the fields you declared in the `items.fields` array.<br/>
        ///     - Segments are within the duration of the video, and events are within the duration of their segment.<br/>
        ///     - The `min_segment_duration` and `max_segment_duration` values limit segments only, not the events inside them.<br/>
        ///     - Event boundaries use the same format as segment boundaries, set by the `segment_time_format` value.
        /// </param>
        /// <param name="finishReason">
        /// When the task uses general analysis, `length` means the response reached the maximum response length or the context window. The partial output is in `data`, and a warning is in the task's `error` field.<br/>
        /// With video segmentation and a numeric `max_tokens`, the task fails when the analysis reaches either limit. This field is never `length` for a segmentation task. With `max_tokens` set to `unlimited`, this field is `stop` even when the output is incomplete.
        /// </param>
        /// <param name="usage">
        /// The number of tokens used in the generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResult(
            string generationId,
            string data,
            global::TwelveLabs.FinishReason finishReason,
            global::TwelveLabs.AnalyzeTaskResultUsage usage)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FinishReason = finishReason;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResult" /> class.
        /// </summary>
        public AnalyzeTaskResult()
        {
        }

    }
}