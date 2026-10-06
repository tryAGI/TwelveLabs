
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
        /// The unique identifier of the batch that the task was created in. The platform returns this field only for tasks created as part of a batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// The public video source associated with the task. When the video was uploaded using the [`POST`](/v1.3/api-reference/index-content/create) method of the `/tasks` endpoint, the source type is `video_id`. Otherwise, the source type is `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source")]
        public global::TwelveLabs.AnalyzeTaskResponseVideoSource? VideoSource { get; set; }

        /// <summary>
        /// The request parameters for this task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_params")]
        public global::TwelveLabs.AnalyzeTaskResponseRequestParams? RequestParams { get; set; }

        /// <summary>
        /// The current status of the analysis task. The `ready`, `failed`, and `canceled` statuses are final.
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
        /// An object that contains the generated text and additional information. The platform returns this object only when `status` is `ready`. When the task fails or is canceled, the response contains no `result` object, so `generation_id` and `usage` are absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::TwelveLabs.AnalyzeTaskResult? Result { get; set; }

        /// <summary>
        /// A message attached to the task response. The platform sets this field in the following cases:<br/>
        /// - **Task failure**: `status` is `failed`. The `message` field describes the failure reason. With video segmentation, a task can fail because the analysis reached the maximum response length or the context window before it could complete. The response contains no `result` object.<br/>
        /// - **Task cancellation**: `status` is `canceled` and a cancellation reason is available. A task newly canceled through the task cancellation endpoint has `code` set to `user_canceled`; canceling the task again does not change the reason.<br/>
        /// - **Incomplete results warning** (video segmentation): `status` is `ready` and the output for some segments could not be recovered. The `message` field contains the warning that the results may be incomplete. The segments the platform extracted are in `result.data`.<br/>
        /// - **Truncation warning** (general analysis): `status` is `ready` and `result.finish_reason` is `length`. The `message` field describes the truncation cause (either the maximum response length was reached or the context window was reached). The partial output is in `result.data`.<br/>
        /// Not set when `status` is `ready` and `result.finish_reason` is `stop`, except for the incomplete results warning. A canceled task can omit this field when no cancellation reason is available.
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
        /// The current status of the analysis task. The `ready`, `failed`, and `canceled` statuses are final.
        /// </param>
        /// <param name="createdAt">
        /// A string representing the date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the analysis task was created.
        /// </param>
        /// <param name="customId">
        /// The identifier you provided in the `custom_id` field when you created the task, or `null` if you did not set one. This key is always present in the response.
        /// </param>
        /// <param name="batchId">
        /// The unique identifier of the batch that the task was created in. The platform returns this field only for tasks created as part of a batch.
        /// </param>
        /// <param name="videoSource">
        /// The public video source associated with the task. When the video was uploaded using the [`POST`](/v1.3/api-reference/index-content/create) method of the `/tasks` endpoint, the source type is `video_id`. Otherwise, the source type is `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="requestParams">
        /// The request parameters for this task.
        /// </param>
        /// <param name="completedAt">
        /// A string representing the date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the analysis task completed, failed, or was canceled. The platform returns this field only if `status` is `ready`, `failed`, or `canceled`.
        /// </param>
        /// <param name="result">
        /// An object that contains the generated text and additional information. The platform returns this object only when `status` is `ready`. When the task fails or is canceled, the response contains no `result` object, so `generation_id` and `usage` are absent.
        /// </param>
        /// <param name="error">
        /// A message attached to the task response. The platform sets this field in the following cases:<br/>
        /// - **Task failure**: `status` is `failed`. The `message` field describes the failure reason. With video segmentation, a task can fail because the analysis reached the maximum response length or the context window before it could complete. The response contains no `result` object.<br/>
        /// - **Task cancellation**: `status` is `canceled` and a cancellation reason is available. A task newly canceled through the task cancellation endpoint has `code` set to `user_canceled`; canceling the task again does not change the reason.<br/>
        /// - **Incomplete results warning** (video segmentation): `status` is `ready` and the output for some segments could not be recovered. The `message` field contains the warning that the results may be incomplete. The segments the platform extracted are in `result.data`.<br/>
        /// - **Truncation warning** (general analysis): `status` is `ready` and `result.finish_reason` is `length`. The `message` field describes the truncation cause (either the maximum response length was reached or the context window was reached). The partial output is in `result.data`.<br/>
        /// Not set when `status` is `ready` and `result.finish_reason` is `stop`, except for the incomplete results warning. A canceled task can omit this field when no cancellation reason is available.
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
            string? customId,
            string? batchId,
            global::TwelveLabs.AnalyzeTaskResponseVideoSource? videoSource,
            global::TwelveLabs.AnalyzeTaskResponseRequestParams? requestParams,
            global::System.DateTime? completedAt,
            global::TwelveLabs.AnalyzeTaskResult? result,
            global::TwelveLabs.AnalyzeTaskError? error,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? webhooks)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.CustomId = customId;
            this.BatchId = batchId;
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