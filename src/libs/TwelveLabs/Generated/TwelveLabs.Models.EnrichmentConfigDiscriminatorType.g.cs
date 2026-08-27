
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum EnrichmentConfigDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnrichmentConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnrichmentConfigDiscriminatorType value)
        {
            return value switch
            {
                EnrichmentConfigDiscriminatorType.Description => "description",
                EnrichmentConfigDiscriminatorType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnrichmentConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "description" => EnrichmentConfigDiscriminatorType.Description,
                "json_schema" => EnrichmentConfigDiscriminatorType.JsonSchema,
                _ => null,
            };
        }
    }
}