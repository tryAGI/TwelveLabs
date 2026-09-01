
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TemporalSegmentationDiscriminatorStrategy
    {
        /// <summary>
        ///
        /// </summary>
        Dynamic,
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemporalSegmentationDiscriminatorStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemporalSegmentationDiscriminatorStrategy value)
        {
            return value switch
            {
                TemporalSegmentationDiscriminatorStrategy.Dynamic => "dynamic",
                TemporalSegmentationDiscriminatorStrategy.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemporalSegmentationDiscriminatorStrategy? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => TemporalSegmentationDiscriminatorStrategy.Dynamic,
                "fixed" => TemporalSegmentationDiscriminatorStrategy.Fixed,
                _ => null,
            };
        }
    }
}