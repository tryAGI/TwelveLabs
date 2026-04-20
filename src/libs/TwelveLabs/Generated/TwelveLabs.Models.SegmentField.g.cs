
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A custom field to extract for each segment.
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
        /// The data type of the field.
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
        /// Allowed values for this field. Maximum 50 values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// Required when `type` is `array`. Specifies the type of array elements.
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
        /// The data type of the field.
        /// </param>
        /// <param name="description">
        /// Instructions that guide the model on what this field should contain and how to extract it from the video.
        /// </param>
        /// <param name="enum">
        /// Allowed values for this field. Maximum 50 values.
        /// </param>
        /// <param name="items">
        /// Required when `type` is `array`. Specifies the type of array elements.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentField(
            string name,
            global::TwelveLabs.SegmentFieldType type,
            string description,
            global::System.Collections.Generic.IList<string>? @enum,
            global::TwelveLabs.SegmentFieldItems? items)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
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