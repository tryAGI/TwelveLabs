
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Searches the public web for content relevant to the request.<br/>
    /// Unknown properties are ignored.
    /// </summary>
    public sealed partial class ResponseToolInputVariant1
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.WebSearchToolInputTypeJsonConverter))]
        public global::TwelveLabs.WebSearchToolInputType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolInputVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseToolInputVariant1(
            global::TwelveLabs.WebSearchToolInputType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolInputVariant1" /> class.
        /// </summary>
        public ResponseToolInputVariant1()
        {
        }

    }
}