
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text.
    /// </summary>
    public sealed partial class SyncResponseFormat
    {
        /// <summary>
        /// Set this parameter to "json_schema" to receive structured JSON responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.SyncResponseFormatTypeJsonConverter))]
        public global::TwelveLabs.SyncResponseFormatType Type { get; set; }

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
        /// - `timestamp` (Pegasus 1.5 only)<br/>
        /// **Supported constraints**<br/>
        /// | Type | Supported keywords | Notes |<br/>
        /// |------|-------------------|-------|<br/>
        /// | `integer` | `maximum`, `exclusiveMaximum`, `minimum`, `exclusiveMinimum`. | - `maximum`: Sets the highest allowed value (inclusive).&lt;br/&gt;- `exclusiveMaximum`: Sets the highest allowed value (exclusive).&lt;br/&gt;- `minimum`: Sets the lowest allowed value (inclusive).&lt;br/&gt;- `exclusiveMinimum`: Sets the lowest allowed value (exclusive).&lt;br/&gt;These constraints are supported only for the `integer` type. |<br/>
        /// | `string` | `pattern`, `format` | - `pattern`: A regular expression that the string must match.&lt;br/&gt;- `format`: Validates predefined formats. It accepts the following values: `uuid`, `date-time`, `date`, and `time`.&lt;br/&gt;See string limitations below. |<br/>
        /// | `object` | `properties`, `required` | - `properties`: Defines object properties and their schemas. - `required`: Specifies mandatory properties.&lt;br/&gt;See object limitations below. |<br/>
        /// | `array` | `items`, `minItems` | `minItems` accepts only `0` or `1`.&lt;br/&gt;See array limitations below. |<br/>
        /// | `timestamp` | `format` | `format` (required): Sets the output format. Accepted values: `seconds`, `hh:mm:ss`, `hh:mm:ss.fff`.&lt;br/&gt;See the **Timestamp type** section below. |<br/>
        /// **String limitations**<br/>
        /// When you use the `string` type:<br/>
        /// - The platform validates strings using only `pattern` and `format`. Including `minLength` or `maxLength` causes a 422 error: "String length constraints (minLength) are not supported." Remove these keywords from your schema.<br/>
        /// **Object limitations**<br/>
        /// When you use the `object` type:<br/>
        /// - The platform does not support the `additionalProperties` keyword. Including it causes a 422 error. Remove it from your schema.<br/>
        /// - The platform returns properties in declaration order.<br/>
        /// - Make the first property required. If the first property is optional, the platform moves the first required property to the beginning.<br/>
        /// **Array limitations**<br/>
        /// When you use the `array` type:<br/>
        /// - The platform does not support `uniqueItems` or `maxItems`. Including either keyword causes a 422 error. Remove them from your schema.<br/>
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
        /// **Timestamp type (Pegasus 1.5 only)**<br/>
        /// Declare a property as `{"type": "timestamp", "format": "&lt;format&gt;"}` to control the format of the returned value.<br/>
        /// The `format` field accepts the following values:<br/>
        /// | `format` | Example output | Notes |<br/>
        /// |----------|----------------|-------|<br/>
        /// | `seconds` | `10.5` | Returns a JSON number in seconds. |<br/>
        /// | `hh:mm:ss` | `"00:01:23"` | Rounded to the nearest second. Negative values are converted to `"00:00:00"`. |<br/>
        /// | `hh:mm:ss.fff` | `"00:01:23.500"` | Millisecond precision. |<br/>
        /// The type of the response depends on the value of the `format` field: `seconds` returns a JSON number, while `hh:mm:ss` and `hh:mm:ss.fff` return a JSON string.<br/>
        /// *Supported positions*<br/>
        /// You can declare `timestamp` fields at the top level of your schema or inside objects nested one level within an array:<br/>
        /// - Top level: `properties.&lt;field_name&gt;`<br/>
        /// - Inside an array: `properties.&lt;array_field&gt;.items.properties.&lt;field_name&gt;`<br/>
        /// Declaring `timestamp` outside these positions — deeper nesting, inside `oneOf` / `anyOf` / `allOf`, or inside `$ref` — is not supported and is rejected with HTTP 400.<br/>
        /// *Validation errors*<br/>
        /// When `format` is missing or invalid, the platform returns `400 parameter_invalid`:<br/>
        /// ```<br/>
        /// response_format.json_schema.properties.&lt;name&gt;.format: format is required for timestamp type; allowed values: seconds, hh:mm:ss, hh:mm:ss.fff<br/>
        /// ```<br/>
        /// **Reserved property names (`start_time` / `end_time`)**<br/>
        /// For Pegasus 1.5, properties named `start_time` or `end_time` in your response schema receive special type handling at any nesting depth (including inside array `items`). These are unrelated to the top-level `start_time` / `end_time` request parameters. The platform returns the value in a format determined by the declared type:<br/>
        /// *Allowed declarations:*<br/>
        /// | Declared type | Platform behavior |<br/>
        /// |---------------|-------------------|<br/>
        /// | `number` | Passes the value through without conversion. |<br/>
        /// | `integer` | Rounds the value to the nearest integer. |<br/>
        /// | `string` (no `format`) | Converts the value to the `hh:mm:ss.fff` format. |<br/>
        /// | `timestamp` with `format` | See the **Timestamp type** section above for the available formats. |<br/>
        /// *Rejected declarations (returns `400` error):*<br/>
        /// - `string` with any `format` keyword (`time`, `date-time`, `email`, `uri`, etc.)<br/>
        /// - `boolean`<br/>
        /// - `object`<br/>
        /// - `array`<br/>
        /// - `null`<br/>
        /// All other property names in your schema remain unconstrained by these rules. For other field names, use the `timestamp` type described above.<br/>
        /// **Response validation**<br/>
        /// Check the `FinishReason` field to verify your JSON response is complete:<br/>
        /// - When `FinishReason` is `stop`, the generation completed normally, and the JSON is valid and complete.<br/>
        /// - When `FinishReason` is `length`, the platform truncates the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.SyncResponseFormatJsonSchema JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncResponseFormat" /> class.
        /// </summary>
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
        /// - `timestamp` (Pegasus 1.5 only)<br/>
        /// **Supported constraints**<br/>
        /// | Type | Supported keywords | Notes |<br/>
        /// |------|-------------------|-------|<br/>
        /// | `integer` | `maximum`, `exclusiveMaximum`, `minimum`, `exclusiveMinimum`. | - `maximum`: Sets the highest allowed value (inclusive).&lt;br/&gt;- `exclusiveMaximum`: Sets the highest allowed value (exclusive).&lt;br/&gt;- `minimum`: Sets the lowest allowed value (inclusive).&lt;br/&gt;- `exclusiveMinimum`: Sets the lowest allowed value (exclusive).&lt;br/&gt;These constraints are supported only for the `integer` type. |<br/>
        /// | `string` | `pattern`, `format` | - `pattern`: A regular expression that the string must match.&lt;br/&gt;- `format`: Validates predefined formats. It accepts the following values: `uuid`, `date-time`, `date`, and `time`.&lt;br/&gt;See string limitations below. |<br/>
        /// | `object` | `properties`, `required` | - `properties`: Defines object properties and their schemas. - `required`: Specifies mandatory properties.&lt;br/&gt;See object limitations below. |<br/>
        /// | `array` | `items`, `minItems` | `minItems` accepts only `0` or `1`.&lt;br/&gt;See array limitations below. |<br/>
        /// | `timestamp` | `format` | `format` (required): Sets the output format. Accepted values: `seconds`, `hh:mm:ss`, `hh:mm:ss.fff`.&lt;br/&gt;See the **Timestamp type** section below. |<br/>
        /// **String limitations**<br/>
        /// When you use the `string` type:<br/>
        /// - The platform validates strings using only `pattern` and `format`. Including `minLength` or `maxLength` causes a 422 error: "String length constraints (minLength) are not supported." Remove these keywords from your schema.<br/>
        /// **Object limitations**<br/>
        /// When you use the `object` type:<br/>
        /// - The platform does not support the `additionalProperties` keyword. Including it causes a 422 error. Remove it from your schema.<br/>
        /// - The platform returns properties in declaration order.<br/>
        /// - Make the first property required. If the first property is optional, the platform moves the first required property to the beginning.<br/>
        /// **Array limitations**<br/>
        /// When you use the `array` type:<br/>
        /// - The platform does not support `uniqueItems` or `maxItems`. Including either keyword causes a 422 error. Remove them from your schema.<br/>
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
        /// **Timestamp type (Pegasus 1.5 only)**<br/>
        /// Declare a property as `{"type": "timestamp", "format": "&lt;format&gt;"}` to control the format of the returned value.<br/>
        /// The `format` field accepts the following values:<br/>
        /// | `format` | Example output | Notes |<br/>
        /// |----------|----------------|-------|<br/>
        /// | `seconds` | `10.5` | Returns a JSON number in seconds. |<br/>
        /// | `hh:mm:ss` | `"00:01:23"` | Rounded to the nearest second. Negative values are converted to `"00:00:00"`. |<br/>
        /// | `hh:mm:ss.fff` | `"00:01:23.500"` | Millisecond precision. |<br/>
        /// The type of the response depends on the value of the `format` field: `seconds` returns a JSON number, while `hh:mm:ss` and `hh:mm:ss.fff` return a JSON string.<br/>
        /// *Supported positions*<br/>
        /// You can declare `timestamp` fields at the top level of your schema or inside objects nested one level within an array:<br/>
        /// - Top level: `properties.&lt;field_name&gt;`<br/>
        /// - Inside an array: `properties.&lt;array_field&gt;.items.properties.&lt;field_name&gt;`<br/>
        /// Declaring `timestamp` outside these positions — deeper nesting, inside `oneOf` / `anyOf` / `allOf`, or inside `$ref` — is not supported and is rejected with HTTP 400.<br/>
        /// *Validation errors*<br/>
        /// When `format` is missing or invalid, the platform returns `400 parameter_invalid`:<br/>
        /// ```<br/>
        /// response_format.json_schema.properties.&lt;name&gt;.format: format is required for timestamp type; allowed values: seconds, hh:mm:ss, hh:mm:ss.fff<br/>
        /// ```<br/>
        /// **Reserved property names (`start_time` / `end_time`)**<br/>
        /// For Pegasus 1.5, properties named `start_time` or `end_time` in your response schema receive special type handling at any nesting depth (including inside array `items`). These are unrelated to the top-level `start_time` / `end_time` request parameters. The platform returns the value in a format determined by the declared type:<br/>
        /// *Allowed declarations:*<br/>
        /// | Declared type | Platform behavior |<br/>
        /// |---------------|-------------------|<br/>
        /// | `number` | Passes the value through without conversion. |<br/>
        /// | `integer` | Rounds the value to the nearest integer. |<br/>
        /// | `string` (no `format`) | Converts the value to the `hh:mm:ss.fff` format. |<br/>
        /// | `timestamp` with `format` | See the **Timestamp type** section above for the available formats. |<br/>
        /// *Rejected declarations (returns `400` error):*<br/>
        /// - `string` with any `format` keyword (`time`, `date-time`, `email`, `uri`, etc.)<br/>
        /// - `boolean`<br/>
        /// - `object`<br/>
        /// - `array`<br/>
        /// - `null`<br/>
        /// All other property names in your schema remain unconstrained by these rules. For other field names, use the `timestamp` type described above.<br/>
        /// **Response validation**<br/>
        /// Check the `FinishReason` field to verify your JSON response is complete:<br/>
        /// - When `FinishReason` is `stop`, the generation completed normally, and the JSON is valid and complete.<br/>
        /// - When `FinishReason` is `length`, the platform truncates the response at the token limit. This may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="type">
        /// Set this parameter to "json_schema" to receive structured JSON responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SyncResponseFormat(
            global::TwelveLabs.SyncResponseFormatJsonSchema jsonSchema,
            global::TwelveLabs.SyncResponseFormatType type)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncResponseFormat" /> class.
        /// </summary>
        public SyncResponseFormat()
        {
        }

    }
}