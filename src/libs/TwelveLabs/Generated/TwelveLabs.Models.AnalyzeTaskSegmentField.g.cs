
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A segment field from the request, returned as you provided it.
    /// </summary>
    public sealed partial class AnalyzeTaskSegmentField
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The output format for `timestamp` fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskSegmentFieldFormatJsonConverter))]
        public global::TwelveLabs.AnalyzeTaskSegmentFieldFormat? Format { get; set; }

        /// <summary>
        /// The allowed values for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// The per-item structure of a segment field whose `type` is `array` or `time_array`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::TwelveLabs.AnalyzeTaskSegmentFieldItems? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskSegmentField" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the field.
        /// </param>
        /// <param name="type">
        /// The data type of the field.
        /// </param>
        /// <param name="description"></param>
        /// <param name="format">
        /// The output format for `timestamp` fields.
        /// </param>
        /// <param name="enum">
        /// The allowed values for this field.
        /// </param>
        /// <param name="items">
        /// The per-item structure of a segment field whose `type` is `array` or `time_array`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskSegmentField(
            string name,
            string type,
            string? description,
            global::TwelveLabs.AnalyzeTaskSegmentFieldFormat? format,
            global::System.Collections.Generic.IList<string>? @enum,
            global::TwelveLabs.AnalyzeTaskSegmentFieldItems? items)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description;
            this.Format = format;
            this.Enum = @enum;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskSegmentField" /> class.
        /// </summary>
        public AnalyzeTaskSegmentField()
        {
        }

    }
}