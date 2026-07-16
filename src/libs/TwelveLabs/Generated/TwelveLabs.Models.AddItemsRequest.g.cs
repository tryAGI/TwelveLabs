
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddItemsRequest
    {
        /// <summary>
        /// The unique identifiers of the items to add to the collection. Include up to 500 identifiers per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ItemIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemsRequest" /> class.
        /// </summary>
        /// <param name="itemIds">
        /// The unique identifiers of the items to add to the collection. Include up to 500 identifiers per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddItemsRequest(
            global::System.Collections.Generic.IList<string> itemIds)
        {
            this.ItemIds = itemIds ?? throw new global::System.ArgumentNullException(nameof(itemIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddItemsRequest" /> class.
        /// </summary>
        public AddItemsRequest()
        {
        }

    }
}