
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportFilesRequest
    {
        /// <summary>
        /// The files to import. Provide an array of one item for a single import, or multiple items for a batch import. A maximum of 100 items can be imported per request. The `source_id` field of each item must be unique within a request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFilesRequest" /> class.
        /// </summary>
        /// <param name="items">
        /// The files to import. Provide an array of one item for a single import, or multiple items for a batch import. A maximum of 100 items can be imported per request. The `source_id` field of each item must be unique within a request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportFilesRequest(
            global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFilesRequest" /> class.
        /// </summary>
        public ImportFilesRequest()
        {
        }

    }
}