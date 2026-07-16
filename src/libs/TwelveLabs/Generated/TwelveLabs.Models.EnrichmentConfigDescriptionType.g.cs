
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Must be `"description"`. Identifies this as the natural-language variant.
    /// </summary>
    public enum EnrichmentConfigDescriptionType
    {
        /// <summary>
        /// 
        /// </summary>
        Description,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnrichmentConfigDescriptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnrichmentConfigDescriptionType value)
        {
            return value switch
            {
                EnrichmentConfigDescriptionType.Description => "description",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnrichmentConfigDescriptionType? ToEnum(string value)
        {
            return value switch
            {
                "description" => EnrichmentConfigDescriptionType.Description,
                _ => null,
            };
        }
    }
}