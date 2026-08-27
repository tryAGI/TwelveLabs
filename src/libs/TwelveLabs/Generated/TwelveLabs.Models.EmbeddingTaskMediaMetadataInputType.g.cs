
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum EmbeddingTaskMediaMetadataInputType
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingTaskMediaMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingTaskMediaMetadataInputType value)
        {
            return value switch
            {
                EmbeddingTaskMediaMetadataInputType.Audio => "audio",
                EmbeddingTaskMediaMetadataInputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingTaskMediaMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => EmbeddingTaskMediaMetadataInputType.Audio,
                "video" => EmbeddingTaskMediaMetadataInputType.Video,
                _ => null,
            };
        }
    }
}