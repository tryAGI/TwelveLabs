
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata for the knowledge store. Both keys and values must be strings.
    /// </summary>
    public sealed partial class CreateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}