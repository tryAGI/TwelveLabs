
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A complete progress snapshot for an activity, included with `stream: true`<br/>
    /// and `include: ["activity_summaries"]`. Update entries by activity ID and<br/>
    /// increasing revision. Revisions start at 1 for each activity and increase<br/>
    /// by 1 for each emitted snapshot. A new snapshot is emitted only when its<br/>
    /// status or summary changes; changes to internal metadata do not emit events.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant15
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamActivityEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamActivityEventType Type { get; set; }

        /// <summary>
        /// The event's position in the stream's single monotonic sequence, used to order events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// A progress entry with a summary and its latest observed status.<br/>
        /// Activity status is independent of response status. Activities are not<br/>
        /// stored in saved message history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStreamActivityEventActivity Activity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant15" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The event's position in the stream's single monotonic sequence, used to order events.
        /// </param>
        /// <param name="activity">
        /// A progress entry with a summary and its latest observed status.<br/>
        /// Activity status is independent of response status. Activities are not<br/>
        /// stored in saved message history.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant15(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamActivityEventActivity activity,
            global::TwelveLabs.ResponseStreamActivityEventType type)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Activity = activity ?? throw new global::System.ArgumentNullException(nameof(activity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant15" /> class.
        /// </summary>
        public ResponseStreamEventVariant15()
        {
        }

    }
}