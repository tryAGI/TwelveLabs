
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of content for the embeddings.<br/>
    /// **Values**:<br/>
    /// - `audio`: An audio file.<br/>
    /// - `video`: A video file.<br/>
    /// - `document`: A PDF file. Requires Marengo 3.5.<br/>
    /// - `image`: An image file. Requires Marengo 3.5.
    /// </summary>
    public enum CreateAsyncEmbeddingRequestInputType
    {
        /// <summary>
        /// An audio file.
        /// </summary>
        Audio,
        /// <summary>
        /// A PDF file. Requires Marengo 3.5.
        /// </summary>
        Document,
        /// <summary>
        /// An image file. Requires Marengo 3.5.
        /// </summary>
        Image,
        /// <summary>
        /// A video file.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAsyncEmbeddingRequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAsyncEmbeddingRequestInputType value)
        {
            return value switch
            {
                CreateAsyncEmbeddingRequestInputType.Audio => "audio",
                CreateAsyncEmbeddingRequestInputType.Document => "document",
                CreateAsyncEmbeddingRequestInputType.Image => "image",
                CreateAsyncEmbeddingRequestInputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAsyncEmbeddingRequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateAsyncEmbeddingRequestInputType.Audio,
                "document" => CreateAsyncEmbeddingRequestInputType.Document,
                "image" => CreateAsyncEmbeddingRequestInputType.Image,
                "video" => CreateAsyncEmbeddingRequestInputType.Video,
                _ => null,
            };
        }
    }
}