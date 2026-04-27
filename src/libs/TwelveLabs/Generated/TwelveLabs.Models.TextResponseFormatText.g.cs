
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Plain text output format (default).
    /// </summary>
    public sealed partial class TextResponseFormatText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TextResponseFormatTextTypeJsonConverter))]
        public global::TwelveLabs.TextResponseFormatTextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatText" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextResponseFormatText(
            global::TwelveLabs.TextResponseFormatTextType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatText" /> class.
        /// </summary>
        public TextResponseFormatText()
        {
        }
    }
}