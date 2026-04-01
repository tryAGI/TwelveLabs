
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Set this field to `url` to indicate that you're providing the video via a URL.
    /// </summary>
    public enum VideoContextOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoContextOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoContextOneOf0Type value)
        {
            return value switch
            {
                VideoContextOneOf0Type.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoContextOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "url" => VideoContextOneOf0Type.Url,
                _ => null,
            };
        }
    }
}