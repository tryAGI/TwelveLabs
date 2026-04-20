
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The response format you configured. Present only when you included it in the request.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseRequestParamsResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AnalyzeTaskResponseRequestParamsResponseFormatTypeJsonConverter))]
        public global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_definitions")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? SegmentDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsResponseFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="segmentDefinitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseRequestParamsResponseFormat(
            global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatType? type,
            global::System.Collections.Generic.IList<global::TwelveLabs.AnalyzeTaskResponseRequestParamsResponseFormatSegmentDefinitionsItems>? segmentDefinitions)
        {
            this.Type = type;
            this.SegmentDefinitions = segmentDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseRequestParamsResponseFormat" /> class.
        /// </summary>
        public AnalyzeTaskResponseRequestParamsResponseFormat()
        {
        }
    }
}