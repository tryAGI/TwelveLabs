
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A progress entry with a summary and its latest observed status.<br/>
    /// Activity status is independent of response status. Activities are not<br/>
    /// stored in saved message history.
    /// </summary>
    public sealed partial class ResponseStreamActivityEventActivity
    {
        /// <summary>
        /// Stable identifier of the activity within this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The latest observed lifecycle state of this activity.<br/>
        /// **Values**:<br/>
        /// - `in_progress`: The activity is running.<br/>
        /// - `completed`: The activity finished.<br/>
        /// - `incomplete`: The activity stopped before finishing.<br/>
        /// - `failed`: The activity failed. A failed activity does not necessarily cause the response to fail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamActivityEventActivityStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStreamActivityEventActivityStatus Status { get; set; }

        /// <summary>
        /// Short progress summary. Later snapshots may update the summary or status. Snapshots without a summary are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// Snapshot revision for this activity, starting at 1 and increasing by 1 for each emitted snapshot. Present only in stream events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamActivityEventActivity" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the activity within this response.
        /// </param>
        /// <param name="status">
        /// The latest observed lifecycle state of this activity.<br/>
        /// **Values**:<br/>
        /// - `in_progress`: The activity is running.<br/>
        /// - `completed`: The activity finished.<br/>
        /// - `incomplete`: The activity stopped before finishing.<br/>
        /// - `failed`: The activity failed. A failed activity does not necessarily cause the response to fail.
        /// </param>
        /// <param name="summary">
        /// Short progress summary. Later snapshots may update the summary or status. Snapshots without a summary are omitted.
        /// </param>
        /// <param name="revision">
        /// Snapshot revision for this activity, starting at 1 and increasing by 1 for each emitted snapshot. Present only in stream events.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamActivityEventActivity(
            string id,
            global::TwelveLabs.ResponseStreamActivityEventActivityStatus status,
            string summary,
            int revision)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamActivityEventActivity" /> class.
        /// </summary>
        public ResponseStreamActivityEventActivity()
        {
        }

    }
}