
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
        /// The identifier you provided in the `custom_id` field when you created the task, or `null` if you did not set one. This key is always present in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// The video source you provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source")]
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? VideoSource { get; set; }

        /// <summary>
        /// The request parameters for this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_params")]
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? RequestParams { get; set; }

        /// <summary>
        /// The current status of the analysis task.<br/>
        /// `ready`, `failed`, and `canceled` are terminal.
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
        /// A string representing the date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the analysis task completed, failed, or was canceled. The platform returns this field only if `status` is `ready`, `failed`, or `canceled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// An object that contains the generated text and additional information. The platform returns this object only when `status` is `ready`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::TwelveLabs.AnalyzeTaskResult? Result { get; set; }

        /// <summary>
        /// A condition attached to the task response. The platform sets this field in two cases:<br/>
        /// - **Task failure**: `status` is `failed`. The `message` field describes the failure reason.<br/>
        /// - **Truncation warning**: `status` is `ready` and `result.finish_reason` is `length`. The `message` field describes the truncation cause (either the maximum response length was reached or the context window was reached). The partial output is in `result.data`.<br/>
        /// Check `status` before treating this field as a failure. This field is not set when `status` is `ready` and `result.finish_reason` is `stop`; it is set when `result.finish_reason` is `length`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::TwelveLabs.AnalyzeTaskError? Error { get; set; }

        /// <summary>
        /// The delivery status of each configured webhook endpoint. The platform omits this field when no webhooks are configured. See the [Webhooks](/v1.3/docs/advanced/webhooks) page for supported events, registration, and reconciliation guidance.
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
        /// The current status of the analysis task.<br/>
        /// `ready`, `failed`, and `canceled` are terminal.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the analysis task was created.
        /// </param>
        /// <param name="customId">
        /// The identifier you provided in the `custom_id` field when you created the task, or `null` if you did not set one. This key is always present in the response.
        /// </param>
        /// <param name="videoSource">
        /// The video source you provided.
        /// </param>
        /// <param name="requestParams">
        /// The request parameters for this task.
        /// </param>
        /// <param name="completedAt">
        /// A string representing the date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the analysis task completed, failed, or was canceled. The platform returns this field only if `status` is `ready`, `failed`, or `canceled`.
        /// </param>
        /// <param name="result">
        /// An object that contains the generated text and additional information. The platform returns this object only when `status` is `ready`.
        /// </param>
        /// <param name="error">
        /// A condition attached to the task response. The platform sets this field in two cases:<br/>
        /// - **Task failure**: `status` is `failed`. The `message` field describes the failure reason.<br/>
        /// - **Truncation warning**: `status` is `ready` and `result.finish_reason` is `length`. The `message` field describes the truncation cause (either the maximum response length was reached or the context window was reached). The partial output is in `result.data`.<br/>
        /// Check `status` before treating this field as a failure. This field is not set when `status` is `ready` and `result.finish_reason` is `stop`; it is set when `result.finish_reason` is `length`.
        /// </param>
        /// <param name="webhooks">
        /// The delivery status of each configured webhook endpoint. The platform omits this field when no webhooks are configured. See the [Webhooks](/v1.3/docs/advanced/webhooks) page for supported events, registration, and reconciliation guidance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponse(
            string taskId,
            global::TwelveLabs.AnalyzeTaskStatus status,
            global::System.DateTime createdAt,
            string? customId,
            global::TwelveLabs.AnalyzeTaskResponseVideoSource? videoSource,
            global::TwelveLabs.AnalyzeTaskResponseRequestParams? requestParams,
            global::System.DateTime? completedAt,
            global::TwelveLabs.AnalyzeTaskResult? result,
            global::TwelveLabs.AnalyzeTaskError? error,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? webhooks)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.CustomId = customId;
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