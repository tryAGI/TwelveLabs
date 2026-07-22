
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The result of an import request, returned by the Import files endpoint.
    /// </summary>
    public sealed partial class ImportResult
    {
        /// <summary>
        /// The unique identifier of the import created for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Whether any item was rejected before an asset was created. When `true`, inspect the `error` object of each item to identify the rejected ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_failures")]
        public bool? HasFailures { get; set; }

        /// <summary>
        /// One entry per requested file, in request order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResult" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the import created for this request.
        /// </param>
        /// <param name="hasFailures">
        /// Whether any item was rejected before an asset was created. When `true`, inspect the `error` object of each item to identify the rejected ones.
        /// </param>
        /// <param name="items">
        /// One entry per requested file, in request order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportResult(
            string? id,
            bool? hasFailures,
            global::System.Collections.Generic.IList<global::TwelveLabs.ImportItem>? items)
        {
            this.Id = id;
            this.HasFailures = hasFailures;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResult" /> class.
        /// </summary>
        public ImportResult()
        {
        }

    }
}