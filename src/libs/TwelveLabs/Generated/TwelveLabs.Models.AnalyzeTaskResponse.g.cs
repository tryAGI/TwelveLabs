
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Represents the status and results of an analysis task.
    /// </summary>
    public sealed partial class AnalyzeTaskResponse
    {
        /// <summary>
        /// The unique identifier of the analysis task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// The video source you provided. Only present for tasks that use direct video input (`url`, `base64_string`, or `asset_id`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>? VideoSource { get; set; }

        /// <summary>
        /// The parameters you sent when creating this task. Only present for tasks created with `model_name` set to `pegasus1.5`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_params")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.OneOfJsonConverter<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>))]
        public global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>? RequestParams { get; set; }

        /// <summary>
        /// The current status of the analysis task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AnalyzeTaskStatus Status { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the analysis task was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A string representing the date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the analysis task was completed or failed. The platform returns this field only if `status` is `ready` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// An object that contains the generated text and additional information. The platform returns this object only when `status` is `ready`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::TwelveLabs.AnalyzeTaskResult? Result { get; set; }

        /// <summary>
        /// Details about why the task failed. The platform returns this object only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::TwelveLabs.AnalyzeTaskError? Error { get; set; }

        /// <summary>
        /// The delivery status of each webhook endpoint. The platform omits this field when no webhooks are configured. You can register webhooks through the Playground. See the [Webhooks](/v1.3/docs/advanced/webhooks) page for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// The unique identifier of the analysis task.
        /// </param>
        /// <param name="status">
        /// The current status of the analysis task.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the analysis task was created.
        /// </param>
        /// <param name="videoSource">
        /// The video source you provided. Only present for tasks that use direct video input (`url`, `base64_string`, or `asset_id`).
        /// </param>
        /// <param name="requestParams">
        /// The parameters you sent when creating this task. Only present for tasks created with `model_name` set to `pegasus1.5`.
        /// </param>
        /// <param name="completedAt">
        /// A string representing the date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the analysis task was completed or failed. The platform returns this field only if `status` is `ready` or `failed`.
        /// </param>
        /// <param name="result">
        /// An object that contains the generated text and additional information. The platform returns this object only when `status` is `ready`.
        /// </param>
        /// <param name="error">
        /// Details about why the task failed. The platform returns this object only when `status` is `failed`.
        /// </param>
        /// <param name="webhooks">
        /// The delivery status of each webhook endpoint. The platform omits this field when no webhooks are configured. You can register webhooks through the Playground. See the [Webhooks](/v1.3/docs/advanced/webhooks) page for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponse(
            string taskId,
            global::TwelveLabs.AnalyzeTaskStatus status,
            global::System.DateTime createdAt,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseVideoSource, object>? videoSource,
            global::TwelveLabs.OneOf<global::TwelveLabs.AnalyzeTaskResponseRequestParams, object>? requestParams,
            global::System.DateTime? completedAt,
            global::TwelveLabs.AnalyzeTaskResult? result,
            global::TwelveLabs.AnalyzeTaskError? error,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? webhooks)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.VideoSource = videoSource;
            this.RequestParams = requestParams;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Result = result;
            this.Error = error;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponse" /> class.
        /// </summary>
        public AnalyzeTaskResponse()
        {
        }
    }
}