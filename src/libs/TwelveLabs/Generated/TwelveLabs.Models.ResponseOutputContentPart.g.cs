
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
        /// The text content. It may contain citation markers, each a number in square<br/>
        /// brackets such as `[1]`. The `start_index` and `end_index` fields of a citation<br/>
        /// indicate the location of its marker. To resolve a marker, find the citation at<br/>
        /// that location. Not every marker has a matching citation; when a marker has<br/>
        /// none, treat it as a citation you cannot display, not as an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Citations that tie spans of the `text` field to what they cite, in order of<br/>
        /// appearance. Always present, and may be empty.<br/>
        /// The `start_index` and `end_index` fields locate the marker within the<br/>
        /// `text` field of this content part, not within the whole response.<br/>
        /// Different citations can cover the same or overlapping video ranges. Each<br/>
        /// marker in the `text` field still resolves to at most one citation.
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
        /// The text content. It may contain citation markers, each a number in square<br/>
        /// brackets such as `[1]`. The `start_index` and `end_index` fields of a citation<br/>
        /// indicate the location of its marker. To resolve a marker, find the citation at<br/>
        /// that location. Not every marker has a matching citation; when a marker has<br/>
        /// none, treat it as a citation you cannot display, not as an error.
        /// </param>
        /// <param name="annotations">
        /// Citations that tie spans of the `text` field to what they cite, in order of<br/>
        /// appearance. Always present, and may be empty.<br/>
        /// The `start_index` and `end_index` fields locate the marker within the<br/>
        /// `text` field of this content part, not within the whole response.<br/>
        /// Different citations can cover the same or overlapping video ranges. Each<br/>
        /// marker in the `text` field still resolves to at most one citation.
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