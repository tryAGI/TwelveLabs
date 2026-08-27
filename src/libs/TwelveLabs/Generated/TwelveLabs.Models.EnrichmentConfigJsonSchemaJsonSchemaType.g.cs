
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The top-level type of the schema. Must be `"object"`. Primitive and array<br/>
    /// top-level types are not supported. The platform uses this object structure<br/>
    /// to map extracted metadata to named fields.
    /// </summary>
    public enum EnrichmentConfigJsonSchemaJsonSchemaType
    {
        /// <summary>
        ///
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnrichmentConfigJsonSchemaJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnrichmentConfigJsonSchemaJsonSchemaType value)
        {
            return value switch
            {
                EnrichmentConfigJsonSchemaJsonSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnrichmentConfigJsonSchemaJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => EnrichmentConfigJsonSchemaJsonSchemaType.Object,
                _ => null,
            };
        }
    }
}