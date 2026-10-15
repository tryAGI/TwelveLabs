
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Narrows results by the creation time of the item. Use `gte` to set the earliest time and `lte` to set the latest time. You can use one or both. When you use both, the `gte` time must be equal to or earlier than the `lte` time.<br/>
    /// The creation time is the time when you create the item with the [`POST`](/v1.3/api-reference/knowledge-store-items/create) method of the `/knowledge-stores/{knowledge_store_id}/items` endpoint. It is not the time when the item reaches the `ready` status. To read the creation time of an item, use the [`GET`](/v1.3/api-reference/knowledge-store-items/retrieve) method of the `/knowledge-stores/{knowledge_store_id}/items/{item_id}` endpoint. The time is in the `created_at` field.
    /// </summary>
    public sealed partial class CreatedAtFilter
    {
        /// <summary>
        /// Match items created at or after this time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        public global::System.DateTime? Gte { get; set; }

        /// <summary>
        /// Match items created at or before this time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        public global::System.DateTime? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedAtFilter" /> class.
        /// </summary>
        /// <param name="gte">
        /// Match items created at or after this time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ").
        /// </param>
        /// <param name="lte">
        /// Match items created at or before this time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatedAtFilter(
            global::System.DateTime? gte,
            global::System.DateTime? lte)
        {
            this.Gte = gte;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedAtFilter" /> class.
        /// </summary>
        public CreatedAtFilter()
        {
        }

    }
}