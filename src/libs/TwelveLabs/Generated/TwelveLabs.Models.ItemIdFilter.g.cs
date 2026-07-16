
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to specific items. Provide exactly one operator: `eq` to match one item, or `in` to match any of the listed items.
    /// </summary>
    public sealed partial class ItemIdFilter
    {
        /// <summary>
        /// Match the item with this identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        public string? Eq { get; set; }

        /// <summary>
        /// Match any item whose identifier is in this list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public global::System.Collections.Generic.IList<string>? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdFilter" /> class.
        /// </summary>
        /// <param name="eq">
        /// Match the item with this identifier.
        /// </param>
        /// <param name="in">
        /// Match any item whose identifier is in this list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemIdFilter(
            string? eq,
            global::System.Collections.Generic.IList<string>? @in)
        {
            this.Eq = eq;
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdFilter" /> class.
        /// </summary>
        public ItemIdFilter()
        {
        }

    }
}