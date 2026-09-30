
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The strategy for dividing each page.<br/>
    /// **Values**:<br/>
    /// - `standard`: Returns one embedding for each page.<br/>
    /// - `quadrants`: Divides each page into a 2×2 grid. Returns five embeddings: one for the whole page, and one for each quarter. The [`data[].quadrant`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.quadrant) field identifies which quarter each embedding represents. This field is `null` on the whole-page embedding. This strategy uses five times as many tokens as the `standard` strategy. It also counts each page five times against the page allowance of the file.<br/>
    /// **Default**: `standard`<br/>
    /// Default Value: standard
    /// </summary>
    public enum DocumentSpatialSegmentationStrategy
    {
        /// <summary>
        /// Divides each page into a 2×2 grid. Returns five embeddings: one for the whole page, and one for each quarter. The [`data[].quadrant`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.quadrant) field identifies which quarter each embedding represents. This field is `null` on the whole-page embedding. This strategy uses five times as many tokens as the `standard` strategy. It also counts each page five times against the page allowance of the file.
        /// </summary>
        Quadrants,
        /// <summary>
        /// Returns one embedding for each page.
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentSpatialSegmentationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentSpatialSegmentationStrategy value)
        {
            return value switch
            {
                DocumentSpatialSegmentationStrategy.Quadrants => "quadrants",
                DocumentSpatialSegmentationStrategy.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentSpatialSegmentationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "quadrants" => DocumentSpatialSegmentationStrategy.Quadrants,
                "standard" => DocumentSpatialSegmentationStrategy.Standard,
                _ => null,
            };
        }
    }
}