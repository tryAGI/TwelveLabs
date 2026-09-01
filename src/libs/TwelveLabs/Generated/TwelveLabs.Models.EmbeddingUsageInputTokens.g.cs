
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The number of tokens the request used. Each key names a type of content the request processed, and each value is the token count for that content.
    /// </summary>
    public sealed partial class EmbeddingUsageInputTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}