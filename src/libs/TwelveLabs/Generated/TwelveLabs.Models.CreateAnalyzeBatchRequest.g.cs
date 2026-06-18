
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Defines a batch creation request. The `model_name` and `analysis_mode` fields apply to every item in the batch. You cannot override these fields per item. You can set every other field in the `defaults` object and override it per item.
    /// </summary>
    public sealed partial class CreateAnalyzeBatchRequest
    {
        /// <summary>
        /// The video understanding model to use for every item in this batch. Batch analysis requires Pegasus 1.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestModelNameJsonConverter))]
        public global::TwelveLabs.CreateAnalyzeBatchRequestModelName ModelName { get; set; }

        /// <summary>
        /// The analysis approach for every item in this batch.<br/>
        /// - `general`: Generate text from each video based on the prompt (the item's `prompt` field if set, otherwise `defaults.prompt`). Supports structured JSON output by using `json_schema` in the `response_format.type` field.<br/>
        /// - `time_based_metadata`: Extract timestamped metadata by using `segment_definitions` in the `response_format.type` field.<br/>
        /// Batches with mixed modes are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.CreateAnalyzeBatchRequestAnalysisModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode AnalysisMode { get; set; }

        /// <summary>
        /// Default values applied to every item that does not override them. Every field is optional. Items in the `requests` array override these values. To override the `prompt` or `response_format` field, provide the full object on the item. You cannot change only some of its nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::TwelveLabs.BatchDefaults? Defaults { get; set; }

        /// <summary>
        /// The analysis requests in the batch. Provide 1 to 1,000 requests, with a combined video duration of up to 2,000 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest> Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnalyzeBatchRequest" /> class.
        /// </summary>
        /// <param name="analysisMode">
        /// The analysis approach for every item in this batch.<br/>
        /// - `general`: Generate text from each video based on the prompt (the item's `prompt` field if set, otherwise `defaults.prompt`). Supports structured JSON output by using `json_schema` in the `response_format.type` field.<br/>
        /// - `time_based_metadata`: Extract timestamped metadata by using `segment_definitions` in the `response_format.type` field.<br/>
        /// Batches with mixed modes are not supported.
        /// </param>
        /// <param name="requests">
        /// The analysis requests in the batch. Provide 1 to 1,000 requests, with a combined video duration of up to 2,000 hours.
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to use for every item in this batch. Batch analysis requires Pegasus 1.5.
        /// </param>
        /// <param name="defaults">
        /// Default values applied to every item that does not override them. Every field is optional. Items in the `requests` array override these values. To override the `prompt` or `response_format` field, provide the full object on the item. You cannot change only some of its nested fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAnalyzeBatchRequest(
            global::TwelveLabs.CreateAnalyzeBatchRequestAnalysisMode analysisMode,
            global::System.Collections.Generic.IList<global::TwelveLabs.BatchItemRequest> requests,
            global::TwelveLabs.CreateAnalyzeBatchRequestModelName modelName,
            global::TwelveLabs.BatchDefaults? defaults)
        {
            this.ModelName = modelName;
            this.AnalysisMode = analysisMode;
            this.Defaults = defaults;
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnalyzeBatchRequest" /> class.
        /// </summary>
        public CreateAnalyzeBatchRequest()
        {
        }

    }
}