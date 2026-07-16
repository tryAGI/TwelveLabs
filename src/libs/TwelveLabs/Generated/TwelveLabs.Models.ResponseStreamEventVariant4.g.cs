
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Wraps a response object. Emitted for `response.created`, `response.in_progress`,<br/>
    /// `response.completed`, and `response.failed` events.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant4
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamResponseEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStreamResponseEventType Type { get; set; }

        /// <summary>
        /// A monotonically increasing sequence number for ordering events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The response object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::TwelveLabs.ResponseObject? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant4" /> class.
        /// </summary>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="sequenceNumber">
        /// A monotonically increasing sequence number for ordering events.
        /// </param>
        /// <param name="response">
        /// The response object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant4(
            global::TwelveLabs.ResponseStreamResponseEventType type,
            int sequenceNumber,
            global::TwelveLabs.ResponseObject? response)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant4" /> class.
        /// </summary>
        public ResponseStreamEventVariant4()
        {
        }

    }
}