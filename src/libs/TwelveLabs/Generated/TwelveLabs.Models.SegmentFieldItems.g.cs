
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The per-item structure of a segment field whose `type` is `array` or `time_array`.<br/>
    /// For an `array` field, the `type` value specifies the scalar element type. For a `time_array` field, use `object` as the `type` value and declare the fields of each event in the `fields` array.
    /// </summary>
    public sealed partial class SegmentFieldItems
    {
        /// <summary>
        /// The item type. For an `array` field, use one of the scalar types (`string`, `number`, `boolean`, `integer`). For a `time_array` field, use `object` and declare the per-event schema in the `fields` array. Setting `object` as the `type` value on a plain `array` field returns a `400` error. Setting the `fields` array on a plain `array` field also returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SegmentFieldItemsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.SegmentFieldItemsType Type { get; set; }

        /// <summary>
        /// The fields to extract from each event. Required when the `type` of the parent field is `time_array`, with at least one entry. Not permitted on any other field type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.TimeArrayItemField>? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentFieldItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The item type. For an `array` field, use one of the scalar types (`string`, `number`, `boolean`, `integer`). For a `time_array` field, use `object` and declare the per-event schema in the `fields` array. Setting `object` as the `type` value on a plain `array` field returns a `400` error. Setting the `fields` array on a plain `array` field also returns a `400` error.
        /// </param>
        /// <param name="fields">
        /// The fields to extract from each event. Required when the `type` of the parent field is `time_array`, with at least one entry. Not permitted on any other field type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentFieldItems(
            global::TwelveLabs.SegmentFieldItemsType type,
            global::System.Collections.Generic.IList<global::TwelveLabs.TimeArrayItemField>? fields)
        {
            this.Type = type;
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentFieldItems" /> class.
        /// </summary>
        public SegmentFieldItems()
        {
        }

    }
}