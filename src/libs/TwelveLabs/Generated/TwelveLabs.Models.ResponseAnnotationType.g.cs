
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// What this citation refers to:<br/>
    /// - `video_citation`: a time range within a video item.<br/>
    /// - `image_citation`: a whole image item.<br/>
    /// - `collection_citation`: an item collection.
    /// </summary>
    public enum ResponseAnnotationType
    {
        /// <summary>
        /// an item collection.
        /// </summary>
        CollectionCitation,
        /// <summary>
        /// a whole image item.
        /// </summary>
        ImageCitation,
        /// <summary>
        /// a time range within a video item.
        /// </summary>
        VideoCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAnnotationType value)
        {
            return value switch
            {
                ResponseAnnotationType.CollectionCitation => "collection_citation",
                ResponseAnnotationType.ImageCitation => "image_citation",
                ResponseAnnotationType.VideoCitation => "video_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "collection_citation" => ResponseAnnotationType.CollectionCitation,
                "image_citation" => ResponseAnnotationType.ImageCitation,
                "video_citation" => ResponseAnnotationType.VideoCitation,
                _ => null,
            };
        }
    }
}