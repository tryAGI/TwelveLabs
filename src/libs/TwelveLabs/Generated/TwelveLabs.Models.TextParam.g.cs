
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Controls the output text format for the response.
    /// </summary>
    public sealed partial class TextParam
    {
        /// <summary>
        /// The output format for the response text. Defaults to plain text.<br/>
        /// Use `json_schema` to receive a structured JSON object conforming to a provided schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TextParamFormatJsonConverter))]
        public global::TwelveLabs.TextParamFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextParam" /> class.
        /// </summary>
        /// <param name="format">
        /// The output format for the response text. Defaults to plain text.<br/>
        /// Use `json_schema` to receive a structured JSON object conforming to a provided schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextParam(
            global::TwelveLabs.TextParamFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextParam" /> class.
        /// </summary>
        public TextParam()
        {
        }
    }
}