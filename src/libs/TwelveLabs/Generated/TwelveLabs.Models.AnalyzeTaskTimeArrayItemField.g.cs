
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A field inside a `time_array` item, returned as you provided it.
    /// </summary>
    public sealed partial class AnalyzeTaskTimeArrayItemField
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
        /// The allowed values for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        /// The element type for an `array` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::TwelveLabs.AnalyzeTaskTimeArrayItemFieldItems? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskTimeArrayItemField" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the field.
        /// </param>
        /// <param name="type">
        /// The data type of the field.
        /// </param>
        /// <param name="description"></param>
        /// <param name="enum">
        /// The allowed values for this field.
        /// </param>
        /// <param name="items">
        /// The element type for an `array` field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskTimeArrayItemField(
            string name,
            string type,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            global::TwelveLabs.AnalyzeTaskTimeArrayItemFieldItems? items)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description;
            this.Enum = @enum;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskTimeArrayItemField" /> class.
        /// </summary>
        public AnalyzeTaskTimeArrayItemField()
        {
        }

    }
}