
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to the items in item collections. Provide exactly one operator: `eq` to match the items in one item collection, or `in` with a list of item collections to match the items in any of them. If an item collection has no items, the search returns no results. The search also returns no results when no item matches the other fields in the `filter` object.
    /// </summary>
    public sealed partial class ItemCollectionIdFilter
    {
        /// <summary>
        /// Match the items in the item collection with this identifier. You retrieve the identifier when you create an item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        public string? Eq { get; set; }

        /// <summary>
        /// Match the items in any item collection with an identifier from this list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public global::System.Collections.Generic.IList<string>? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCollectionIdFilter" /> class.
        /// </summary>
        /// <param name="eq">
        /// Match the items in the item collection with this identifier. You retrieve the identifier when you create an item collection.
        /// </param>
        /// <param name="in">
        /// Match the items in any item collection with an identifier from this list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemCollectionIdFilter(
            string? eq,
            global::System.Collections.Generic.IList<string>? @in)
        {
            this.Eq = eq;
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemCollectionIdFilter" /> class.
        /// </summary>
        public ItemCollectionIdFilter()
        {
        }

    }
}