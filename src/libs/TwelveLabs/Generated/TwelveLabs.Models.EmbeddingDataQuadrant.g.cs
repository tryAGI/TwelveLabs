
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The quarter of the page this embedding covers. The platform returns this field only when the request sets [`document.segmentation.spatial.strategy`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task#request.body.document.segmentation.spatial.strategy) to the `quadrants` value, and only on the four quadrant embeddings of a page. This field is omitted on the whole-page embedding and whenever no quadrant applies.
    /// </summary>
    public enum EmbeddingDataQuadrant
    {
        /// <summary>
        ///
        /// </summary>
        BottomLeft,
        /// <summary>
        ///
        /// </summary>
        BottomRight,
        /// <summary>
        ///
        /// </summary>
        TopLeft,
        /// <summary>
        ///
        /// </summary>
        TopRight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDataQuadrantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDataQuadrant value)
        {
            return value switch
            {
                EmbeddingDataQuadrant.BottomLeft => "bottom_left",
                EmbeddingDataQuadrant.BottomRight => "bottom_right",
                EmbeddingDataQuadrant.TopLeft => "top_left",
                EmbeddingDataQuadrant.TopRight => "top_right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDataQuadrant? ToEnum(string value)
        {
            return value switch
            {
                "bottom_left" => EmbeddingDataQuadrant.BottomLeft,
                "bottom_right" => EmbeddingDataQuadrant.BottomRight,
                "top_left" => EmbeddingDataQuadrant.TopLeft,
                "top_right" => EmbeddingDataQuadrant.TopRight,
                _ => null,
            };
        }
    }
}