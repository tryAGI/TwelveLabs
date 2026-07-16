
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Must be `"json_schema"`. Identifies this as the structured extraction variant.
    /// </summary>
    public enum EnrichmentConfigJsonSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnrichmentConfigJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnrichmentConfigJsonSchemaType value)
        {
            return value switch
            {
                EnrichmentConfigJsonSchemaType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnrichmentConfigJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => EnrichmentConfigJsonSchemaType.JsonSchema,
                _ => null,
            };
        }
    }
}