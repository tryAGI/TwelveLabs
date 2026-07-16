
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Emitted when function call arguments are complete.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant11
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamFuncCallArgsDoneEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType Type { get; set; }

        /// <summary>
        /// A monotonically increasing sequence number for ordering events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The unique identifier of the parent output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// The complete JSON-encoded function call arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant11" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// A monotonically increasing sequence number for ordering events.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the parent output item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item.
        /// </param>
        /// <param name="arguments">
        /// The complete JSON-encoded function call arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant11(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamFuncCallArgsDoneEventType type,
            string? itemId,
            int? outputIndex,
            string? arguments)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant11" /> class.
        /// </summary>
        public ResponseStreamEventVariant11()
        {
        }

    }
}