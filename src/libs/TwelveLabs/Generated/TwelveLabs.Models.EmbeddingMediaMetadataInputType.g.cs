
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingMediaMetadataInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        MultiInput,
        /// <summary>
        /// 
        /// </summary>
        TextImage,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingMediaMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingMediaMetadataInputType value)
        {
            return value switch
            {
                EmbeddingMediaMetadataInputType.Audio => "audio",
                EmbeddingMediaMetadataInputType.Image => "image",
                EmbeddingMediaMetadataInputType.MultiInput => "multi_input",
                EmbeddingMediaMetadataInputType.TextImage => "text_image",
                EmbeddingMediaMetadataInputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingMediaMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => EmbeddingMediaMetadataInputType.Audio,
                "image" => EmbeddingMediaMetadataInputType.Image,
                "multi_input" => EmbeddingMediaMetadataInputType.MultiInput,
                "text_image" => EmbeddingMediaMetadataInputType.TextImage,
                "video" => EmbeddingMediaMetadataInputType.Video,
                _ => null,
            };
        }
    }
}