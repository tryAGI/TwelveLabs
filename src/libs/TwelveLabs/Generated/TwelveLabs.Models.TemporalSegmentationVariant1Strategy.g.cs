
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: dynamic
    /// </summary>
    public enum TemporalSegmentationVariant1Strategy
    {
        /// <summary>
        /// dynamic
        /// </summary>
        Dynamic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemporalSegmentationVariant1StrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemporalSegmentationVariant1Strategy value)
        {
            return value switch
            {
                TemporalSegmentationVariant1Strategy.Dynamic => "dynamic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemporalSegmentationVariant1Strategy? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => TemporalSegmentationVariant1Strategy.Dynamic,
                _ => null,
            };
        }
    }
}