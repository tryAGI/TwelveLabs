
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The metadata to match against the `tag_metadata` field of each tag. Map each key to an object with exactly one of `eq` or `in`. Specify 1 to 50 keys. When you specify more than one key, every key must match on the same tag.<br/>
    /// A value is a string, a number, or a boolean. The platform matches it with the JSON type the tag stores, so `2026` does not match a tag that stores `"2026"`. A key that stores a list matches when the list contains the value.
    /// </summary>
    public sealed partial class TagFilterMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}