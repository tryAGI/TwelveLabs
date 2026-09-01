
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The type of content for the embeddings.<br/>
    /// **Values**:<br/>
    /// - `multi_input`: Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.<br/>
    /// - `audio`: An audio file. Requires Marengo 3.0.<br/>
    /// - `video`: A video file. Requires Marengo 3.0.<br/>
    /// - `image`: An image file. Requires Marengo 3.0.<br/>
    /// - `text`: Text input. Requires Marengo 3.0.<br/>
    /// - `text_image`: Text and an image. Requires Marengo 3.0.
    /// </summary>
    public enum CreateEmbeddingsRequestInputType
    {
        /// <summary>
        /// Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.
        /// </summary>
        Audio,
        /// <summary>
        /// Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.
        /// </summary>
        Image,
        /// <summary>
        /// Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.
        /// </summary>
        MultiInput,
        /// <summary>
        /// Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.
        /// </summary>
        Text,
        /// <summary>
        /// Text and an image. Requires Marengo 3.0.
        /// </summary>
        TextImage,
        /// <summary>
        /// Text and up to 10 media sources, combined into a single embedding. To reference a specific media source from your text, use a placeholder in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source. Marengo 3.5 accepts images, video, and audio as media sources. Marengo 3.0 accepts images.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestInputType value)
        {
            return value switch
            {
                CreateEmbeddingsRequestInputType.Audio => "audio",
                CreateEmbeddingsRequestInputType.Image => "image",
                CreateEmbeddingsRequestInputType.MultiInput => "multi_input",
                CreateEmbeddingsRequestInputType.Text => "text",
                CreateEmbeddingsRequestInputType.TextImage => "text_image",
                CreateEmbeddingsRequestInputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateEmbeddingsRequestInputType.Audio,
                "image" => CreateEmbeddingsRequestInputType.Image,
                "multi_input" => CreateEmbeddingsRequestInputType.MultiInput,
                "text" => CreateEmbeddingsRequestInputType.Text,
                "text_image" => CreateEmbeddingsRequestInputType.TextImage,
                "video" => CreateEmbeddingsRequestInputType.Video,
                _ => null,
            };
        }
    }
}