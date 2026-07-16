
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Emitted when text streaming for a content part completes.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant8
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamOutputTextDoneEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamOutputTextDoneEventType Type { get; set; }

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
        /// The index of the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The complete text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant8" /> class.
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
        /// <param name="contentIndex">
        /// The index of the content part.
        /// </param>
        /// <param name="text">
        /// The complete text content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant8(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamOutputTextDoneEventType type,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            string? text)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant8" /> class.
        /// </summary>
        public ResponseStreamEventVariant8()
        {
        }

    }
}