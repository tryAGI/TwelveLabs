
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of media.<br/>
    /// **Values**:<br/>
    /// - `image`: An image file. Works with both Marengo 3.0 and Marengo 3.5.<br/>
    /// - `video`: A video file. Requires Marengo 3.5.<br/>
    /// - `audio`: An audio file. Requires Marengo 3.5.
    /// </summary>
    public enum MultiInputMediaSourceMediaType
    {
        /// <summary>
        /// An audio file. Requires Marengo 3.5.
        /// </summary>
        Audio,
        /// <summary>
        /// An image file. Works with both Marengo 3.0 and Marengo 3.5.
        /// </summary>
        Image,
        /// <summary>
        /// A video file. Requires Marengo 3.5.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MultiInputMediaSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MultiInputMediaSourceMediaType value)
        {
            return value switch
            {
                MultiInputMediaSourceMediaType.Audio => "audio",
                MultiInputMediaSourceMediaType.Image => "image",
                MultiInputMediaSourceMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MultiInputMediaSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => MultiInputMediaSourceMediaType.Audio,
                "image" => MultiInputMediaSourceMediaType.Image,
                "video" => MultiInputMediaSourceMediaType.Video,
                _ => null,
            };
        }
    }
}