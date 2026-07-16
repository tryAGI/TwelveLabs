
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Emitted when an output item is finalized.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant10
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputItemDoneEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamOutputItemDoneEventType Type { get; set; }

        /// <summary>
        /// A monotonically increasing sequence number for ordering events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The index of the output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// An item in the response output. Items are polymorphic and discriminated by the `type` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::TwelveLabs.ResponseOutputItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant10" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// A monotonically increasing sequence number for ordering events.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item.
        /// </param>
        /// <param name="item">
        /// An item in the response output. Items are polymorphic and discriminated by the `type` field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant10(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamOutputItemDoneEventType type,
            int? outputIndex,
            global::TwelveLabs.ResponseOutputItem? item)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant10" /> class.
        /// </summary>
        public ResponseStreamEventVariant10()
        {
        }

    }
}