
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A content part within a message output item.
    /// </summary>
    public sealed partial class ResponseOutputContentPart
    {
        /// <summary>
        /// The type of content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ResponseOutputContentPartTypeJsonConverter))]
        public global::TwelveLabs.ResponseOutputContentPartType Type { get; set; }

        /// <summary>
        /// The text content. Media citations use numbered markers such as `[1]`.<br/>
        /// A web citation can cover text that is not a marker. Its span can also<br/>
        /// cover a provider marker, such as `\ue200cite\ue202turn0search1\ue201`<br/>
        /// (shown with Unicode escapes). Use the `start_index` and `end_index`<br/>
        /// fields of an annotation to locate the text that it covers, and its<br/>
        /// `url` to render a web source link. The annotation identifies the<br/>
        /// source; the marker text does not. Treat a marker without a matching<br/>
        /// annotation as a citation you cannot display, not as a response error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Contains the citations. Each citation identifies a span of the `text`<br/>
        /// field and the source it cites. Always present, and may be empty.<br/>
        /// The `start_index` and `end_index` fields locate the cited span within the<br/>
        /// `text` field of this content part, not within the whole response. Both<br/>
        /// bounds are inclusive and count Unicode code points.<br/>
        /// Text spans can overlap or be identical, including across citation types.<br/>
        /// A web citation can cover a numbered media marker. Resolve each annotation<br/>
        /// independently; do not assume disjoint spans or array order by offset.<br/>
        /// Different video citations can also cover overlapping video time ranges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation> Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputContentPart" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content. Media citations use numbered markers such as `[1]`.<br/>
        /// A web citation can cover text that is not a marker. Its span can also<br/>
        /// cover a provider marker, such as `\ue200cite\ue202turn0search1\ue201`<br/>
        /// (shown with Unicode escapes). Use the `start_index` and `end_index`<br/>
        /// fields of an annotation to locate the text that it covers, and its<br/>
        /// `url` to render a web source link. The annotation identifies the<br/>
        /// source; the marker text does not. Treat a marker without a matching<br/>
        /// annotation as a citation you cannot display, not as a response error.
        /// </param>
        /// <param name="annotations">
        /// Contains the citations. Each citation identifies a span of the `text`<br/>
        /// field and the source it cites. Always present, and may be empty.<br/>
        /// The `start_index` and `end_index` fields locate the cited span within the<br/>
        /// `text` field of this content part, not within the whole response. Both<br/>
        /// bounds are inclusive and count Unicode code points.<br/>
        /// Text spans can overlap or be identical, including across citation types.<br/>
        /// A web citation can cover a numbered media marker. Resolve each annotation<br/>
        /// independently; do not assume disjoint spans or array order by offset.<br/>
        /// Different video citations can also cover overlapping video time ranges.
        /// </param>
        /// <param name="type">
        /// The type of content part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputContentPart(
            string text,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseAnnotation> annotations,
            global::TwelveLabs.ResponseOutputContentPartType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputContentPart" /> class.
        /// </summary>
        public ResponseOutputContentPart()
        {
        }

    }
}