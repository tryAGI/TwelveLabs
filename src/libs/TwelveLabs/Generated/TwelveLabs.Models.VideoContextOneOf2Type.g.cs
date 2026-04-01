
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Set this field to `base64_string` to indicate that you're providing the video via base64-encoded data.
    /// </summary>
    public enum VideoContextOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Base64String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextOneOf2Type value)
        {
            return value switch
            {
                VideoContextOneOf2Type.Base64String => "base64_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "base64_string" => VideoContextOneOf2Type.Base64String,
                _ => null,
            };
        }
    }
}