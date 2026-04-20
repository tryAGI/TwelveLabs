
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Controls the response format. When you omit this parameter, you receive unstructured text.<br/>
    /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
    /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
    /// </summary>
    public sealed partial class AsyncResponseFormat
    {
        /// <summary>
        /// The response format to use.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.AsyncResponseFormatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.AsyncResponseFormatType Type { get; set; }

        /// <summary>
        /// Contains the JSON schema that defines the response structure. The schema must adhere to the [JSON Schema Draft 2020-12](https://json-schema.org/draft/2020-12) specification.<br/>
        /// **Supported types**<br/>
        /// - `array`<br/>
        /// - `boolean`<br/>
        /// - `integer`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `object`<br/>
        /// - `string`<br/>
        /// **Supported constraints**<br/>
        /// | Type | Supported keywords | Notes |<br/>
        /// |------|-------------------|-------|<br/>
        /// | `integer` | `maximum`, `exclusiveMaximum`, `minimum`, `exclusiveMinimum`. | - `maximum`: Sets the highest allowed value (inclusive).&lt;br/&gt;- `exclusiveMaximum`: Sets the highest allowed value (exclusive).&lt;br/&gt;-`minimum`: Sets the lowest allowed value (inclusive).&lt;br/&gt;- `exclusiveMinimum`: Sets the lowest allowed value (exclusive).&lt;br/&gt;These constraints are supported only for the `integer` type. |<br/>
        /// | `string` | `pattern`, `format` | - `pattern`: A regular expression that the string must match.&lt;br/&gt;- `format`: Validates predefined formats. It accepts the following values: `uuid`, `date-time`, `date`, and `time`.&lt;br/&gt;See string limitations below. |<br/>
        /// | `object` | `properties`, `required` | - `properties`: Defines object properties and their schemas. - `required`: Specifies mandatory properties.&lt;br/&gt;See object limitations below. |<br/>
        /// | `array` | `items`, `minItems` | `minItems` accepts only `0` or `1` |<br/>
        /// **String limitations**<br/>
        /// The platform validates strings using the `pattern` and `format` constraints only. When you include `minLength` or `maxLength` keywords in your schema, the platform returns an error: "String length constraints (minLength) are not supported."<br/>
        /// **Object limitations**<br/>
        /// When you use the `object` type:<br/>
        /// - The platform always ignores the `additionalProperties` setting.<br/>
        /// - The sequence of the properties is fixed.<br/>
        /// - The first property should be required. If the first property is optional, the platform moves the first required property to the first position.<br/>
        /// **Constant and enumerated values**<br/>
        /// The `const` and `enum` keywords support the following types:<br/>
        /// - `boolean`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `string`<br/>
        /// **Schema composition**<br/>
        /// The platform supports only `anyOf` for [schema composition](https://json-schema.org/understanding-json-schema/reference/combining).<br/>
        /// **Annotations**<br/>
        /// The platform accepts but ignores JSON schema annotations like `title`, `$comments`, and `description`.<br/>
        /// **Subschema references**<br/>
        /// You can reference subschemas using `$ref` with these requirements:<br/>
        /// - Define subschemas within `$defs`.<br/>
        /// - Use valid URIs that point to the internal subschema.<br/>
        /// For details, see the [JSON Schema documentation on $defs](https://json-schema.org/understanding-json-schema/structuring#defs).<br/>
        /// **Response validation**<br/>
        /// Check the `FinishReason` field to verify your JSON response is complete:<br/>
        /// - When `FinishReason` is `stop`, the generation completed normally, and the JSON is valid and complete.<br/>
        /// - When `FinishReason` is `length`, the platform truncates the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::TwelveLabs.AsyncResponseFormatJsonSchema? JsonSchema { get; set; }

        /// <summary>
        /// Define the types of segments to extract from your video. Minimum 1, maximum 10 definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_definitions")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? SegmentDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The response format to use.<br/>
        /// - `json_schema`: Return structured JSON that conforms to your schema.<br/>
        /// - `segment_definitions`: Extract timestamped metadata with custom fields from your video. Requires `model_name` set to `pegasus1.5` and `analysis_mode` set to `time_based_metadata`.
        /// </param>
        /// <param name="jsonSchema">
        /// Contains the JSON schema that defines the response structure. The schema must adhere to the [JSON Schema Draft 2020-12](https://json-schema.org/draft/2020-12) specification.<br/>
        /// **Supported types**<br/>
        /// - `array`<br/>
        /// - `boolean`<br/>
        /// - `integer`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `object`<br/>
        /// - `string`<br/>
        /// **Supported constraints**<br/>
        /// | Type | Supported keywords | Notes |<br/>
        /// |------|-------------------|-------|<br/>
        /// | `integer` | `maximum`, `exclusiveMaximum`, `minimum`, `exclusiveMinimum`. | - `maximum`: Sets the highest allowed value (inclusive).&lt;br/&gt;- `exclusiveMaximum`: Sets the highest allowed value (exclusive).&lt;br/&gt;-`minimum`: Sets the lowest allowed value (inclusive).&lt;br/&gt;- `exclusiveMinimum`: Sets the lowest allowed value (exclusive).&lt;br/&gt;These constraints are supported only for the `integer` type. |<br/>
        /// | `string` | `pattern`, `format` | - `pattern`: A regular expression that the string must match.&lt;br/&gt;- `format`: Validates predefined formats. It accepts the following values: `uuid`, `date-time`, `date`, and `time`.&lt;br/&gt;See string limitations below. |<br/>
        /// | `object` | `properties`, `required` | - `properties`: Defines object properties and their schemas. - `required`: Specifies mandatory properties.&lt;br/&gt;See object limitations below. |<br/>
        /// | `array` | `items`, `minItems` | `minItems` accepts only `0` or `1` |<br/>
        /// **String limitations**<br/>
        /// The platform validates strings using the `pattern` and `format` constraints only. When you include `minLength` or `maxLength` keywords in your schema, the platform returns an error: "String length constraints (minLength) are not supported."<br/>
        /// **Object limitations**<br/>
        /// When you use the `object` type:<br/>
        /// - The platform always ignores the `additionalProperties` setting.<br/>
        /// - The sequence of the properties is fixed.<br/>
        /// - The first property should be required. If the first property is optional, the platform moves the first required property to the first position.<br/>
        /// **Constant and enumerated values**<br/>
        /// The `const` and `enum` keywords support the following types:<br/>
        /// - `boolean`<br/>
        /// - `null`<br/>
        /// - `number`<br/>
        /// - `string`<br/>
        /// **Schema composition**<br/>
        /// The platform supports only `anyOf` for [schema composition](https://json-schema.org/understanding-json-schema/reference/combining).<br/>
        /// **Annotations**<br/>
        /// The platform accepts but ignores JSON schema annotations like `title`, `$comments`, and `description`.<br/>
        /// **Subschema references**<br/>
        /// You can reference subschemas using `$ref` with these requirements:<br/>
        /// - Define subschemas within `$defs`.<br/>
        /// - Use valid URIs that point to the internal subschema.<br/>
        /// For details, see the [JSON Schema documentation on $defs](https://json-schema.org/understanding-json-schema/structuring#defs).<br/>
        /// **Response validation**<br/>
        /// Check the `FinishReason` field to verify your JSON response is complete:<br/>
        /// - When `FinishReason` is `stop`, the generation completed normally, and the JSON is valid and complete.<br/>
        /// - When `FinishReason` is `length`, the platform truncates the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="segmentDefinitions">
        /// Define the types of segments to extract from your video. Minimum 1, maximum 10 definitions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncResponseFormat(
            global::TwelveLabs.AsyncResponseFormatType type,
            global::TwelveLabs.AsyncResponseFormatJsonSchema? jsonSchema,
            global::System.Collections.Generic.IList<global::TwelveLabs.SegmentDefinition>? segmentDefinitions)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
            this.SegmentDefinitions = segmentDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncResponseFormat" /> class.
        /// </summary>
        public AsyncResponseFormat()
        {
        }
    }
}