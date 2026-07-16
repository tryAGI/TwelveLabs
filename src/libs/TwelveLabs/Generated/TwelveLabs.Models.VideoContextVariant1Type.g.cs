
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: url
    /// </summary>
    public enum VideoContextVariant1Type
    {
        /// <summary>
        /// url
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextVariant1Type value)
        {
            return value switch
            {
                VideoContextVariant1Type.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "url" => VideoContextVariant1Type.Url,
                _ => null,
            };
        }
    }
}