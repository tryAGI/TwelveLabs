
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
        public global::TwelveLabs.ResponseOutputContentPartType? Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content part.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputContentPart(
            global::TwelveLabs.ResponseOutputContentPartType? type,
            string? text)
        {
            this.Type = type;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputContentPart" /> class.
        /// </summary>
        public ResponseOutputContentPart()
        {
        }
    }
}