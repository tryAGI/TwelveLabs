
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Emitted when a content part starts within a message.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant6
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartAddedEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamContentPartAddedEventType Type { get; set; }

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
        /// The index of the content part within the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The content part when it starts. No text has been generated yet, so the<br/>
        /// `annotations` array is empty. This does not mean the content has no<br/>
        /// citations. You receive them on the `response.content_part.done` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        public global::TwelveLabs.ResponseOutputContentPart? Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant6" /> class.
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
        /// The index of the content part within the item.
        /// </param>
        /// <param name="part">
        /// The content part when it starts. No text has been generated yet, so the<br/>
        /// `annotations` array is empty. This does not mean the content has no<br/>
        /// citations. You receive them on the `response.content_part.done` event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant6(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamContentPartAddedEventType type,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            global::TwelveLabs.ResponseOutputContentPart? part)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Part = part;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant6" /> class.
        /// </summary>
        public ResponseStreamEventVariant6()
        {
        }

    }
}