
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Response when creating a new analysis task.
    /// </summary>
    public sealed partial class CreateAnalyzeTaskResponse
    {
        /// <summary>
        /// The unique identifier of the analysis task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// The current status of the analysis task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AnalyzeTaskStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnalyzeTaskResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// The unique identifier of the analysis task.
        /// </param>
        /// <param name="status">
        /// The current status of the analysis task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAnalyzeTaskResponse(
            string taskId,
            global::TwelveLabs.AnalyzeTaskStatus status)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnalyzeTaskResponse" /> class.
        /// </summary>
        public CreateAnalyzeTaskResponse()
        {
        }
    }
}