
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Emitted when a content part is finalized.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant9
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamContentPartDoneEventTypeJsonConverter))]
        public global::TwelveLabs.ResponseStreamContentPartDoneEventType Type { get; set; }

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
        /// The completed content part. The `annotations` array is populated.<br/>
        /// Citations do not stream in with the text. You receive all of them on this<br/>
        /// event, when the content part is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        public global::TwelveLabs.ResponseOutputContentPart? Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant9" /> class.
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
        /// <param name="part">
        /// The completed content part. The `annotations` array is populated.<br/>
        /// Citations do not stream in with the text. You receive all of them on this<br/>
        /// event, when the content part is complete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant9(
            int sequenceNumber,
            global::TwelveLabs.ResponseStreamContentPartDoneEventType type,
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
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant9" /> class.
        /// </summary>
        public ResponseStreamEventVariant9()
        {
        }

    }
}