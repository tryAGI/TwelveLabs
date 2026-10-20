
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results to specific items. Use `eq` to match one item or `in` to match any item in a list. Use `nin` to exclude any item in a list.<br/>
    /// You cannot use `eq` and `in` together. You can use `nin` on its own or with either `eq` or `in`. If an item is listed in `nin` and selected by `eq` or `in`, the platform excludes it.
    /// </summary>
    public sealed partial class ItemIdFilter
    {
        /// <summary>
        /// Match the item with this identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        public string? Eq { get; set; }

        /// <summary>
        /// Match any item with an identifier in this list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        public global::System.Collections.Generic.IList<string>? In { get; set; }

        /// <summary>
        /// Exclude every clip or image belonging to these items. You can list 1 to 20,000 item IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nin")]
        public global::System.Collections.Generic.IList<string>? Nin { get; set; }

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
        /// Match any item with an identifier in this list.
        /// </param>
        /// <param name="nin">
        /// Exclude every clip or image belonging to these items. You can list 1 to 20,000 item IDs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ItemIdFilter(
            string? eq,
            global::System.Collections.Generic.IList<string>? @in,
            global::System.Collections.Generic.IList<string>? nin)
        {
            this.Eq = eq;
            this.In = @in;
            this.Nin = nin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdFilter" /> class.
        /// </summary>
        public ItemIdFilter()
        {
        }

    }
}