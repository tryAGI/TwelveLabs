
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The per-item structure of a segment field whose `type` is `array` or `time_array`.
    /// </summary>
    public sealed partial class AnalyzeTaskSegmentFieldItems
    {
        /// <summary>
        /// The type of the items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The fields of each event. Present only for `time_array` fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskSegmentFieldItems" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the items.
        /// </param>
        /// <param name="fields">
        /// The fields of each event. Present only for `time_array` fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskSegmentFieldItems(
            string type,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskTimeArrayItemField>? fields)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskSegmentFieldItems" /> class.
        /// </summary>
        public AnalyzeTaskSegmentFieldItems()
        {
        }

    }
}