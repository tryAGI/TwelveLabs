
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems
    {
        /// <summary>
        /// The identifier of the file at the provider. For Google Drive, this is the Drive file identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// The identifier of the file at the provider. For Google Drive, this is the Drive file identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems(
            string sourceId)
        {
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems" /> class.
        /// </summary>
        public ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems()
        {
        }

    }
}