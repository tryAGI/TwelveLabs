
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A batch object that includes item counts for each item status.
    /// </summary>
    public sealed partial class AnalyzeBatchStatusResponse
    {
        /// <summary>
        /// The unique identifier of the batch. Use this value to retrieve the batch status or results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchId { get; set; }

        /// <summary>
        /// The analysis mode applied to every item in this batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeBatchSummaryAnalysisModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AnalyzeBatchSummaryAnalysisMode AnalysisMode { get; set; }

        /// <summary>
        /// The model used for every item in this batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The status of a batch. For the meaning of each value, see the [Batch statuses](/v1.3/api-reference/analyze-videos/batch-analysis/the-batch-object#batch-statuses) section on the **The batch object** page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.BatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.BatchStatus Status { get; set; }

        /// <summary>
        /// The number of items submitted in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalItems { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format, when the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format, when the batch expires (the `created_at` field value plus 24 hours). Unfinished items at expiration are canceled. Items that finished before then remain retrievable for 30 days after creation, when the batch and its results are deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format, when the batch status became `completed`. Present only when the status is `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format, when the batch status became `canceled`. Present only when the status is `canceled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled_at")]
        public global::System.DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format, when the batch status became `expired`. Present only when the status is `expired`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired_at")]
        public global::System.DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// The number of items in the `queued` status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int QueuedItems { get; set; }

        /// <summary>
        /// The number of items in the `processing` status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProcessingItems { get; set; }

        /// <summary>
        /// The number of items that completed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadyItems { get; set; }

        /// <summary>
        /// The number of items that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedItems { get; set; }

        /// <summary>
        /// The number of items that were canceled, either because the batch was canceled while the item was in the `queued` status, or because the batch expired before the item finished processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CanceledItems { get; set; }

        /// <summary>
        /// The delivery status of each webhook endpoint for the batch completion notification. Present only after the platform sends the webhook notifications. To register webhooks, see the [Webhooks](/v1.3/docs/advanced/webhooks) page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeBatchStatusResponse" /> class.
        /// </summary>
        /// <param name="batchId">
        /// The unique identifier of the batch. Use this value to retrieve the batch status or results.
        /// </param>
        /// <param name="analysisMode">
        /// The analysis mode applied to every item in this batch.
        /// </param>
        /// <param name="modelName">
        /// The model used for every item in this batch.
        /// </param>
        /// <param name="status">
        /// The status of a batch. For the meaning of each value, see the [Batch statuses](/v1.3/api-reference/analyze-videos/batch-analysis/the-batch-object#batch-statuses) section on the **The batch object** page.
        /// </param>
        /// <param name="totalItems">
        /// The number of items submitted in the batch.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in the RFC 3339 format, when the batch was created.
        /// </param>
        /// <param name="expiresAt">
        /// The date and time, in the RFC 3339 format, when the batch expires (the `created_at` field value plus 24 hours). Unfinished items at expiration are canceled. Items that finished before then remain retrievable for 30 days after creation, when the batch and its results are deleted.
        /// </param>
        /// <param name="queuedItems">
        /// The number of items in the `queued` status.
        /// </param>
        /// <param name="processingItems">
        /// The number of items in the `processing` status.
        /// </param>
        /// <param name="readyItems">
        /// The number of items that completed successfully.
        /// </param>
        /// <param name="failedItems">
        /// The number of items that failed.
        /// </param>
        /// <param name="canceledItems">
        /// The number of items that were canceled, either because the batch was canceled while the item was in the `queued` status, or because the batch expired before the item finished processing.
        /// </param>
        /// <param name="completedAt">
        /// The date and time, in the RFC 3339 format, when the batch status became `completed`. Present only when the status is `completed`.
        /// </param>
        /// <param name="canceledAt">
        /// The date and time, in the RFC 3339 format, when the batch status became `canceled`. Present only when the status is `canceled`.
        /// </param>
        /// <param name="expiredAt">
        /// The date and time, in the RFC 3339 format, when the batch status became `expired`. Present only when the status is `expired`.
        /// </param>
        /// <param name="webhooks">
        /// The delivery status of each webhook endpoint for the batch completion notification. Present only after the platform sends the webhook notifications. To register webhooks, see the [Webhooks](/v1.3/docs/advanced/webhooks) page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeBatchStatusResponse(
            string batchId,
            global::TwelveLabs.AnalyzeBatchSummaryAnalysisMode analysisMode,
            string modelName,
            global::TwelveLabs.BatchStatus status,
            int totalItems,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt,
            int queuedItems,
            int processingItems,
            int readyItems,
            int failedItems,
            int canceledItems,
            global::System.DateTime? completedAt,
            global::System.DateTime? canceledAt,
            global::System.DateTime? expiredAt,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskWebhookInfo>? webhooks)
        {
            this.BatchId = batchId ?? throw new global::System.ArgumentNullException(nameof(batchId));
            this.AnalysisMode = analysisMode;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Status = status;
            this.TotalItems = totalItems;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.CompletedAt = completedAt;
            this.CanceledAt = canceledAt;
            this.ExpiredAt = expiredAt;
            this.QueuedItems = queuedItems;
            this.ProcessingItems = processingItems;
            this.ReadyItems = readyItems;
            this.FailedItems = failedItems;
            this.CanceledItems = canceledItems;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeBatchStatusResponse" /> class.
        /// </summary>
        public AnalyzeBatchStatusResponse()
        {
        }

    }
}