
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Custom metadata for the item collection, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings; values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string.
    /// </summary>
    public sealed partial class CreateRequestMetadata3
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}