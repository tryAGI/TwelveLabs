
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum VideoSegmentationDiscriminatorStrategy
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
    public static class VideoSegmentationDiscriminatorStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSegmentationDiscriminatorStrategy value)
        {
            return value switch
            {
                VideoSegmentationDiscriminatorStrategy.Dynamic => "dynamic",
                VideoSegmentationDiscriminatorStrategy.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSegmentationDiscriminatorStrategy? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => VideoSegmentationDiscriminatorStrategy.Dynamic,
                "fixed" => VideoSegmentationDiscriminatorStrategy.Fixed,
                _ => null,
            };
        }
    }
}