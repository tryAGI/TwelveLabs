
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Specifies how the platform divides your document before it generates embeddings. Requires Marengo 3.5.<br/>
    /// Use the `spatial` field to divide each rendered page of a PDF file. Use the `sequential` field to divide a plain text or Markdown file into chunks.<br/>
    /// Provide the field that matches your file. If you provide neither field, the platform returns a `400` error.
    /// </summary>
    public sealed partial class DocumentSegmentation
    {
        /// <summary>
        /// Specifies how the platform divides each rendered page of a PDF file. Plain text and Markdown files have no rendered pages, so the platform returns a `400` error if you include this object.<br/>
        /// This object requires the `visual` value in the `embedding_option` field and the `local` value in the `embedding_scope` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spatial")]
        public global::TwelveLabs.DocumentSpatialSegmentation? Spatial { get; set; }

        /// <summary>
        /// Specifies how the platform divides a plain text or Markdown file into chunks. For a PDF file, the platform divides by page instead and returns a `400` error if you include this object.<br/>
        /// This object requires the `text` value in the `embedding_option` field and the `local` value in the `embedding_scope` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequential")]
        public global::TwelveLabs.DocumentSequentialSegmentation? Sequential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSegmentation" /> class.
        /// </summary>
        /// <param name="spatial">
        /// Specifies how the platform divides each rendered page of a PDF file. Plain text and Markdown files have no rendered pages, so the platform returns a `400` error if you include this object.<br/>
        /// This object requires the `visual` value in the `embedding_option` field and the `local` value in the `embedding_scope` field.
        /// </param>
        /// <param name="sequential">
        /// Specifies how the platform divides a plain text or Markdown file into chunks. For a PDF file, the platform divides by page instead and returns a `400` error if you include this object.<br/>
        /// This object requires the `text` value in the `embedding_option` field and the `local` value in the `embedding_scope` field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentSegmentation(
            global::TwelveLabs.DocumentSpatialSegmentation? spatial,
            global::TwelveLabs.DocumentSequentialSegmentation? sequential)
        {
            this.Spatial = spatial;
            this.Sequential = sequential;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSegmentation" /> class.
        /// </summary>
        public DocumentSegmentation()
        {
        }

    }
}