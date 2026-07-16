
#nullable enable

namespace TwelveLabs
{
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
    public sealed partial class TextParamFormatVariant2Schema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}