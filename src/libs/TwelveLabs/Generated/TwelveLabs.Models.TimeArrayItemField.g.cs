
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A field inside a `time_array` item.<br/>
    /// The platform adds `start_time` and `end_time` keys to every event automatically. You cannot declare fields with these names. A `time_array` field cannot contain another `time_array` field. The `format` property is not accepted on per-event fields.
    /// </summary>
    public sealed partial class TimeArrayItemField
    {
        /// <summary>
        /// The name of the field inside each event object. Must be unique within the item. The names `start_time`, `end_time`, and `metadata` are reserved and rejected with a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The data type of this field. It does not accept `timestamp` or `time_array`. When set to the `array` value, the `items` object is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TimeArrayItemFieldTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.TimeArrayItemFieldType Type { get; set; }

        /// <summary>
        /// Instructions that guide the model on what this field should contain in each event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Allowed values for this field. Maximum 100 values. Only supported when `type` is `string`; any other type returns a `400` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// The element type for an `array` field. Required when `type` is `array`; not supported on any other type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::TwelveLabs.TimeArrayItemFieldItems? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeArrayItemField" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the field inside each event object. Must be unique within the item. The names `start_time`, `end_time`, and `metadata` are reserved and rejected with a `400` error.
        /// </param>
        /// <param name="type">
        /// The data type of this field. It does not accept `timestamp` or `time_array`. When set to the `array` value, the `items` object is required.
        /// </param>
        /// <param name="description">
        /// Instructions that guide the model on what this field should contain in each event.
        /// </param>
        /// <param name="enum">
        /// Allowed values for this field. Maximum 100 values. Only supported when `type` is `string`; any other type returns a `400` error.
        /// </param>
        /// <param name="items">
        /// The element type for an `array` field. Required when `type` is `array`; not supported on any other type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeArrayItemField(
            string name,
            global::TwelveLabs.TimeArrayItemFieldType type,
            string description,
            global::System.Collections.Generic.IList<string>? @enum,
            global::TwelveLabs.TimeArrayItemFieldItems? items)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Enum = @enum;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeArrayItemField" /> class.
        /// </summary>
        public TimeArrayItemField()
        {
        }

    }
}