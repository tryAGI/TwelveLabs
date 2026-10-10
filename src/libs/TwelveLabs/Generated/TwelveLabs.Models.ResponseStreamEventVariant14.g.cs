
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Progress for a web-search call. Included only when the request sets `include: ["intermediate_outputs"]`.<br/>
    /// The `item_id` links to the corresponding `jockey:web_search` output item.
    /// </summary>
    public sealed partial class ResponseStreamEventVariant14
    {
        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseStreamWebSearchProgressEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.ResponseStreamWebSearchProgressEventType Type { get; set; }

        /// <summary>
        /// The event's position in the stream's single monotonic sequence, used to order events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The identifier of the `jockey:web_search` output item within this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The zero-based index of the output item in the response's `output` array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant14" /> class.
        /// </summary>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="sequenceNumber">
        /// The event's position in the stream's single monotonic sequence, used to order events.
        /// </param>
        /// <param name="itemId">
        /// The identifier of the `jockey:web_search` output item within this response.
        /// </param>
        /// <param name="outputIndex">
        /// The zero-based index of the output item in the response's `output` array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseStreamEventVariant14(
            global::TwelveLabs.ResponseStreamWebSearchProgressEventType type,
            int sequenceNumber,
            string itemId,
            int outputIndex)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseStreamEventVariant14" /> class.
        /// </summary>
        public ResponseStreamEventVariant14()
        {
        }

    }
}