
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A JSON Schema (draft 2020-12) that defines the structure of metadata to<br/>
    /// extract from each video shot. The platform accepts only the JSON Schema keywords<br/>
    /// listed below; unknown keywords return a `422` error. Keep schemas<br/>
    /// focused — deeply nested or overly complex schemas may degrade extraction quality.<br/>
    /// **Supported keywords**<br/>
    /// | Category | Keywords |<br/>
    /// |---|---|<br/>
    /// | Core | `type`, `title`, `description`, `enum` |<br/>
    /// | Object | `properties`, `required`, `additionalProperties` |<br/>
    /// | Array | `items`, `prefixItems`, `minItems`, `maxItems` |<br/>
    /// | Number | `minimum`, `maximum` |<br/>
    /// | String | `format` |<br/>
    /// Notes:<br/>
    /// - The root `type` keyword must be `"object"`.<br/>
    /// - Every entry under the `properties` keyword (including nested ones) must include a<br/>
    ///   `description` field. This text guides extraction quality.<br/>
    /// - The `required` keyword behaves as in standard JSON Schema.<br/>
    /// - The `additionalProperties` keyword accepts a boolean value (`true` or `false`). Use<br/>
    ///   `false` to enforce strict shapes. The platform does not support schema-valued forms.<br/>
    /// - **Unknown keywords return `422` — they are not silently ignored.** If you<br/>
    ///   generate schemas programmatically (for example, using<br/>
    ///   `pydantic.model_json_schema()`), strip annotative keywords such as<br/>
    ///   `default`, `examples`, and `readOnly` before submitting.<br/>
    /// - **The platform does not support nullable fields.** This includes both `nullable: true` and<br/>
    ///   `type: ["string", "null"]`. To express an optional field,<br/>
    ///   omit it from the `required` array — the platform omits the field from the result<br/>
    ///   when no value is present.<br/>
    /// **Not supported (returns `422`)**<br/>
    /// - Schema composition: `anyOf`, `allOf`, `oneOf`, `not`<br/>
    /// - Conditional schemas: `if` / `then` / `else`<br/>
    /// - Property dependencies: `dependentSchemas`, `dependentRequired`<br/>
    /// - Object size constraints: `minProperties`, `maxProperties`<br/>
    /// - String constraints: `pattern`, `minLength`, `maxLength`<br/>
    /// - Number constraints: `exclusiveMinimum`, `exclusiveMaximum`, `multipleOf`<br/>
    /// - Value constraints: `const`<br/>
    /// - Null handling: `nullable`, `type` arrays (e.g., `["string", "null"]`)<br/>
    /// - Annotative keywords: `default`, `examples`, `readOnly`, `writeOnly`<br/>
    /// - References and reuse: `$ref`, `$defs`, `definitions`<br/>
    /// - Any other keyword not listed under "Supported keywords" above
    /// </summary>
    public sealed partial class EnrichmentConfigJsonSchemaJsonSchema
    {
        /// <summary>
        /// The top-level type of the schema. Must be `"object"`. Primitive and array<br/>
        /// top-level types are not supported. The platform uses this object structure<br/>
        /// to map extracted metadata to named fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.EnrichmentConfigJsonSchemaJsonSchemaTypeJsonConverter))]
        public global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType Type { get; set; }

        /// <summary>
        /// A map of property names to their JSON Schema definitions. Each property<br/>
        /// must include a field named `description`. The platform uses this field to guide extraction<br/>
        /// quality. Omitting it returns a `422` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfigJsonSchemaJsonSchema" /> class.
        /// </summary>
        /// <param name="properties">
        /// A map of property names to their JSON Schema definitions. Each property<br/>
        /// must include a field named `description`. The platform uses this field to guide extraction<br/>
        /// quality. Omitting it returns a `422` error.
        /// </param>
        /// <param name="type">
        /// The top-level type of the schema. Must be `"object"`. Primitive and array<br/>
        /// top-level types are not supported. The platform uses this object structure<br/>
        /// to map extracted metadata to named fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichmentConfigJsonSchemaJsonSchema(
            object properties,
            global::TwelveLabs.EnrichmentConfigJsonSchemaJsonSchemaType type)
        {
            this.Type = type;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentConfigJsonSchemaJsonSchema" /> class.
        /// </summary>
        public EnrichmentConfigJsonSchemaJsonSchema()
        {
        }

    }
}