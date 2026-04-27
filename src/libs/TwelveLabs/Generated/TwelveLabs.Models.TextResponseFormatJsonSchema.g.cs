
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Structured JSON output conforming to a provided schema.
    /// </summary>
    public sealed partial class TextResponseFormatJsonSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TextResponseFormatJsonSchemaTypeJsonConverter))]
        public global::TwelveLabs.TextResponseFormatJsonSchemaType Type { get; set; }

        /// <summary>
        /// A name identifying the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The JSON Schema object defining the structure of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// When `true`, the model always follows the exact schema.<br/>
        /// **Note:** This field is accepted and reserved for future use. It does not currently affect model behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatJsonSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// A name identifying the schema.
        /// </param>
        /// <param name="schema">
        /// The JSON Schema object defining the structure of the response.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// A description of the schema.
        /// </param>
        /// <param name="strict">
        /// When `true`, the model always follows the exact schema.<br/>
        /// **Note:** This field is accepted and reserved for future use. It does not currently affect model behavior.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextResponseFormatJsonSchema(
            string name,
            object schema,
            global::TwelveLabs.TextResponseFormatJsonSchemaType type,
            string? description,
            bool? strict)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatJsonSchema" /> class.
        /// </summary>
        public TextResponseFormatJsonSchema()
        {
        }
    }
}