
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: fixed
    /// </summary>
    public enum VideoSegmentationVariant2Strategy
    {
        /// <summary>
        /// fixed
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSegmentationVariant2StrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSegmentationVariant2Strategy value)
        {
            return value switch
            {
                VideoSegmentationVariant2Strategy.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSegmentationVariant2Strategy? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => VideoSegmentationVariant2Strategy.Fixed,
                _ => null,
            };
        }
    }
}