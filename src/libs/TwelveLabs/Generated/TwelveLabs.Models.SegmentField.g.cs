
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A custom field to extract for each segment.<br/>
    /// **Timestamp fields** (Pegasus 1.5 only)<br/>
    /// Set `type` to `timestamp` and provide a `format` to control the format of the returned value on each segment. See the `format` property for supported values.<br/>
    /// Each segment includes automatic `start_time` and `end_time` keys (floats in seconds) that mark the segment boundary. These names, along with `metadata`, are reserved and cannot be used for `timestamp` fields.
    /// </summary>
    public sealed partial class SegmentField
    {
        /// <summary>
        /// The name of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The data type of the field.<br/>
        /// When set to `timestamp`, the `format` property is required and controls the format of the returned value. Requires the `model_name` parameter set to `pegasus1.5`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SegmentFieldTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.SegmentFieldType Type { get; set; }

        /// <summary>
        /// Instructions that guide the model on what this field should contain and how to extract it from the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The output format for `timestamp` fields. Required when `type` is `timestamp`. Must be omitted for any other type.<br/>
        /// | `format` | Example output |<br/>
        /// |----------|----------------|<br/>
        /// | `seconds` | `10.5` (JSON number in seconds) |<br/>
        /// | `hh:mm:ss` | `"00:01:23"` (rounded to the nearest second; negative values are converted to `"00:00:00"`) |<br/>
        /// | `hh:mm:ss.fff` | `"00:01:23.500"` (millisecond precision) |<br/>
        /// *Validation errors*<br/>
        /// The platform returns `400 parameter_invalid` (with field path `response_format.segment_definitions.fields.format`) when:<br/>
        /// - `type` is `timestamp` and `format` is missing, empty, or not one of the supported values.<br/>
        /// - `type` is not `timestamp` and `format` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SegmentFieldFormatJsonConverter))]
        public global::TwelveLabs.SegmentFieldFormat? Format { get; set; }

        /// <summary>
        /// Allowed values for this field. Maximum 100 values. Not supported when `type` is `timestamp`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Required when `type` is `array`. Specifies the type of array elements. Not supported when `type` is `timestamp`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::TwelveLabs.SegmentFieldItems? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentField" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the field.
        /// </param>
        /// <param name="type">
        /// The data type of the field.<br/>
        /// When set to `timestamp`, the `format` property is required and controls the format of the returned value. Requires the `model_name` parameter set to `pegasus1.5`.
        /// </param>
        /// <param name="description">
        /// Instructions that guide the model on what this field should contain and how to extract it from the video.
        /// </param>
        /// <param name="format">
        /// The output format for `timestamp` fields. Required when `type` is `timestamp`. Must be omitted for any other type.<br/>
        /// | `format` | Example output |<br/>
        /// |----------|----------------|<br/>
        /// | `seconds` | `10.5` (JSON number in seconds) |<br/>
        /// | `hh:mm:ss` | `"00:01:23"` (rounded to the nearest second; negative values are converted to `"00:00:00"`) |<br/>
        /// | `hh:mm:ss.fff` | `"00:01:23.500"` (millisecond precision) |<br/>
        /// *Validation errors*<br/>
        /// The platform returns `400 parameter_invalid` (with field path `response_format.segment_definitions.fields.format`) when:<br/>
        /// - `type` is `timestamp` and `format` is missing, empty, or not one of the supported values.<br/>
        /// - `type` is not `timestamp` and `format` is set.
        /// </param>
        /// <param name="enum">
        /// Allowed values for this field. Maximum 100 values. Not supported when `type` is `timestamp`.
        /// </param>
        /// <param name="items">
        /// Required when `type` is `array`. Specifies the type of array elements. Not supported when `type` is `timestamp`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentField(
            string name,
            global::TwelveLabs.SegmentFieldType type,
            string description,
            global::TwelveLabs.SegmentFieldFormat? format,
            global::System.Collections.Generic.IList<string>? @enum,
            global::TwelveLabs.SegmentFieldItems? items)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Format = format;
            this.Enum = @enum;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentField" /> class.
        /// </summary>
        public SegmentField()
        {
        }

    }
}