
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Discriminator value: base64_string
    /// </summary>
    public enum VideoContextVariant3Type
    {
        /// <summary>
        /// base64_string
        /// </summary>
        Base64String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextVariant3Type value)
        {
            return value switch
            {
                VideoContextVariant3Type.Base64String => "base64_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "base64_string" => VideoContextVariant3Type.Base64String,
                _ => null,
            };
        }
    }
}