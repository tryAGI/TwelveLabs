
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Deprecated. Use `item_metadata` instead. The item stores the pairs in its `item_metadata` field and not in its `metadata` field. Send `item_metadata` or `metadata`, not both. A request that sets both returns a `400` error.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateRequestMetadata2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}