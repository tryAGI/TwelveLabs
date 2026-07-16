
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata for the item collection. Both keys and values must be strings. To remove all metadata, set this field to an empty object (`{}`).
    /// </summary>
    public sealed partial class UpdateRequestMetadata2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}