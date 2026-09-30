
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides each rendered page of a PDF file. Plain text and Markdown files have no rendered pages, so the platform returns a `400` error if you include this object.<br/>
    /// This object requires the `visual` value in the `embedding_option` field and the `local` value in the `embedding_scope` field.
    /// </summary>
    public sealed partial class DocumentSpatialSegmentation
    {
        /// <summary>
        /// The strategy for dividing each page.<br/>
        /// **Values**:<br/>
        /// - `standard`: Returns one embedding for each page.<br/>
        /// - `quadrants`: Divides each page into a 2×2 grid. Returns five embeddings: one for the whole page, and one for each quarter. The [`data[].quadrant`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.quadrant) field identifies which quarter each embedding represents. This field is `null` on the whole-page embedding. This strategy uses five times as many tokens as the `standard` strategy. It also counts each page five times against the page allowance of the file.<br/>
        /// **Default**: `standard`<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.DocumentSpatialSegmentationStrategyJsonConverter))]
        public global::TwelveLabs.DocumentSpatialSegmentationStrategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSpatialSegmentation" /> class.
        /// </summary>
        /// <param name="strategy">
        /// The strategy for dividing each page.<br/>
        /// **Values**:<br/>
        /// - `standard`: Returns one embedding for each page.<br/>
        /// - `quadrants`: Divides each page into a 2×2 grid. Returns five embeddings: one for the whole page, and one for each quarter. The [`data[].quadrant`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.quadrant) field identifies which quarter each embedding represents. This field is `null` on the whole-page embedding. This strategy uses five times as many tokens as the `standard` strategy. It also counts each page five times against the page allowance of the file.<br/>
        /// **Default**: `standard`<br/>
        /// Default Value: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentSpatialSegmentation(
            global::TwelveLabs.DocumentSpatialSegmentationStrategy? strategy)
        {
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSpatialSegmentation" /> class.
        /// </summary>
        public DocumentSpatialSegmentation()
        {
        }

    }
}