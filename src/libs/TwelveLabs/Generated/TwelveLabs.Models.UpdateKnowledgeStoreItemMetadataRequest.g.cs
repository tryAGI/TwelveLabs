
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateKnowledgeStoreItemMetadataRequest
    {
        /// <summary>
        /// The keys to change. Send at least one key. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, an array of strings, or `null` to delete the key. A nested object and an array containing anything other than strings are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ItemMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeStoreItemMetadataRequest" /> class.
        /// </summary>
        /// <param name="itemMetadata">
        /// The keys to change. Send at least one key. Keys are strings of up to 128 characters. String values can have up to 8192 characters. Values can be a string, a number, a boolean, an array of strings, or `null` to delete the key. A nested object and an array containing anything other than strings are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateKnowledgeStoreItemMetadataRequest(
            object itemMetadata)
        {
            this.ItemMetadata = itemMetadata ?? throw new global::System.ArgumentNullException(nameof(itemMetadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKnowledgeStoreItemMetadataRequest" /> class.
        /// </summary>
        public UpdateKnowledgeStoreItemMetadataRequest()
        {
        }

    }
}