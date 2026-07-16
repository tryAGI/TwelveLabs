
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata for the knowledge store. Both keys and values must be strings. The provided object replaces the existing metadata in full, so include every key you want to keep. To clear all metadata, set this field to an empty object (`{}`). A null value is stored as an empty string.
    /// </summary>
    public sealed partial class UpdateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}