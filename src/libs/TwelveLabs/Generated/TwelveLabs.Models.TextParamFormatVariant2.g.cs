
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Structured JSON output conforming to a provided schema.
    /// </summary>
    public sealed partial class TextParamFormatVariant2
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
        /// The JSON Schema object defining the structure of the response. The schema must adhere to the [JSON Schema Draft 2020-12](https://json-schema.org/draft/2020-12) specification.<br/>
        /// **Supported data types**<br/>
        /// - `array`<br/>
        /// - `boolean`<br/>
        /// - `integer`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `object`<br/>
        /// - `string`<br/>
        /// **Automatic schema changes**<br/>
        /// The platform adds all object properties to `required` and sets `additionalProperties` to `false` on every object. You do not need to include `required` or `additionalProperties` in your schema.<br/>
        /// **Unsupported keywords**<br/>
        /// The following keywords are not supported and may produce incomplete or malformed output without returning an error. Remove them from your schema or replace them with the alternatives below:<br/>
        /// | Keyword | Recommended alternative |<br/>
        /// |---------|------------------------|<br/>
        /// | `oneOf` | Use `anyOf` instead |<br/>
        /// | `default` | Omit — the platform makes all properties required, so defaults have no effect |<br/>
        /// | `if` / `then` / `else` | No alternative — omit |<br/>
        /// | `not` | No alternative — omit |<br/>
        /// | `patternProperties` | Use `properties` instead |<br/>
        /// | `contains` | No alternative — omit |<br/>
        /// | `prefixItems` | No alternative — omit |<br/>
        /// **Subschema references**<br/>
        /// You can reference subschemas using `$ref` with these requirements:<br/>
        /// - Define subschemas within `$defs` at the root of the schema.<br/>
        /// - External URIs and relative-path references are not supported.<br/>
        /// For details, see the [JSON Schema documentation on $defs](https://json-schema.org/understanding-json-schema/structuring#defs).<br/>
        /// **Scale guidance**<br/>
        /// These are best-practice guidelines, not enforced limits — the platform does not reject schemas that exceed them:<br/>
        /// - Keep nesting to 5 levels of objects or fewer.<br/>
        /// - Keep the total number of properties across all objects to 100 or fewer.<br/>
        /// Schemas that exceed these values may degrade output quality.<br/>
        /// **Response validation**<br/>
        /// Check the `status` field on the response to verify the output is complete:<br/>
        /// - When `status` is `completed`, the response completed normally, and the JSON is valid and complete.<br/>
        /// - When `status` is `incomplete`, the platform truncated the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Specifies whether Jockey must strictly follow the provided schema. This field is accepted and reserved for future use. It does not affect the behavior of Jockey.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextParamFormatVariant2" /> class.
        /// </summary>
        /// <param name="name">
        /// A name identifying the schema.
        /// </param>
        /// <param name="schema">
        /// The JSON Schema object defining the structure of the response. The schema must adhere to the [JSON Schema Draft 2020-12](https://json-schema.org/draft/2020-12) specification.<br/>
        /// **Supported data types**<br/>
        /// - `array`<br/>
        /// - `boolean`<br/>
        /// - `integer`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `object`<br/>
        /// - `string`<br/>
        /// **Automatic schema changes**<br/>
        /// The platform adds all object properties to `required` and sets `additionalProperties` to `false` on every object. You do not need to include `required` or `additionalProperties` in your schema.<br/>
        /// **Unsupported keywords**<br/>
        /// The following keywords are not supported and may produce incomplete or malformed output without returning an error. Remove them from your schema or replace them with the alternatives below:<br/>
        /// | Keyword | Recommended alternative |<br/>
        /// |---------|------------------------|<br/>
        /// | `oneOf` | Use `anyOf` instead |<br/>
        /// | `default` | Omit — the platform makes all properties required, so defaults have no effect |<br/>
        /// | `if` / `then` / `else` | No alternative — omit |<br/>
        /// | `not` | No alternative — omit |<br/>
        /// | `patternProperties` | Use `properties` instead |<br/>
        /// | `contains` | No alternative — omit |<br/>
        /// | `prefixItems` | No alternative — omit |<br/>
        /// **Subschema references**<br/>
        /// You can reference subschemas using `$ref` with these requirements:<br/>
        /// - Define subschemas within `$defs` at the root of the schema.<br/>
        /// - External URIs and relative-path references are not supported.<br/>
        /// For details, see the [JSON Schema documentation on $defs](https://json-schema.org/understanding-json-schema/structuring#defs).<br/>
        /// **Scale guidance**<br/>
        /// These are best-practice guidelines, not enforced limits — the platform does not reject schemas that exceed them:<br/>
        /// - Keep nesting to 5 levels of objects or fewer.<br/>
        /// - Keep the total number of properties across all objects to 100 or fewer.<br/>
        /// Schemas that exceed these values may degrade output quality.<br/>
        /// **Response validation**<br/>
        /// Check the `status` field on the response to verify the output is complete:<br/>
        /// - When `status` is `completed`, the response completed normally, and the JSON is valid and complete.<br/>
        /// - When `status` is `incomplete`, the platform truncated the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// A description of the schema.
        /// </param>
        /// <param name="strict">
        /// Specifies whether Jockey must strictly follow the provided schema. This field is accepted and reserved for future use. It does not affect the behavior of Jockey.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextParamFormatVariant2(
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
        /// Initializes a new instance of the <see cref="TextParamFormatVariant2" /> class.
        /// </summary>
        public TextParamFormatVariant2()
        {
        }

    }
}