
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A heartbeat frame the server sends about every 10 seconds when no other<br/>
    /// event has been emitted, for example while a tool call is still running.<br/>
    /// It carries no response data. Use it to keep the connection alive and to<br/>
    /// detect stalled streams; otherwise you can ignore it.<br/>
    /// `sequence_number` uses the same counter as all other event types. If you<br/>
    /// skip keepalive frames, the numbers you see will have gaps; these gaps do<br/>
    /// not mean events were dropped.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant12
    {
        /// <summary>
        /// Always `keepalive`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamKeepAliveEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamKeepAliveEventType Type { get; set; }

        /// <summary>
        /// The event's position in the stream's single monotonic sequence, used to order events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant12" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The event's position in the stream's single monotonic sequence, used to order events.
        /// </param>
        /// <param name="type">
        /// Always `keepalive`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant12(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamKeepAliveEventType type)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant12" /> class.
        /// </summary>
        public ResponseStreamEventVariant12()
        {
        }

    }
}