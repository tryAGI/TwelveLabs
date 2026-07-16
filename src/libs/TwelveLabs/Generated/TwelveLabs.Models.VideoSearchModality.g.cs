
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A modality to search within a video.<br/>
    /// - `visual`: Searches visual content.<br/>
    /// - `audio`: Searches audio content, including speech and non-speech sounds.<br/>
    /// For guidance, see the [Search options](/v1.3/docs/concepts/modalities#search-options) section.
    /// </summary>
    public enum VideoSearchModality
    {
        /// <summary>
        /// Searches audio content, including speech and non-speech sounds.
        /// </summary>
        Audio,
        /// <summary>
        /// Searches visual content.
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSearchModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSearchModality value)
        {
            return value switch
            {
                VideoSearchModality.Audio => "audio",
                VideoSearchModality.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSearchModality? ToEnum(string value)
        {
            return value switch
            {
                "audio" => VideoSearchModality.Audio,
                "visual" => VideoSearchModality.Visual,
                _ => null,
            };
        }
    }
}