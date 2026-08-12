
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: dynamic
    /// </summary>
    public enum VideoSegmentationVariant1Strategy
    {
        /// <summary>
        /// dynamic
        /// </summary>
        Dynamic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSegmentationVariant1StrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSegmentationVariant1Strategy value)
        {
            return value switch
            {
                VideoSegmentationVariant1Strategy.Dynamic => "dynamic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSegmentationVariant1Strategy? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => VideoSegmentationVariant1Strategy.Dynamic,
                _ => null,
            };
        }
    }
}