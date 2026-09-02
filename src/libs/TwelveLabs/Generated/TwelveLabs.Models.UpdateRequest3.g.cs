
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRequest3
    {
        /// <summary>
        /// The name of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An optional description of the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom metadata for the knowledge store, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string. The provided object replaces the existing metadata in full, so include every key you want to keep, and drop a key by omitting it. To clear all metadata, set this field to an empty object (`{}`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest3" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the knowledge store.
        /// </param>
        /// <param name="description">
        /// An optional description of the knowledge store.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the knowledge store, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings. Each value is a string, a number, a boolean, or an array of strings; a nested object, an array holding anything but strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991); send a wider value, and any identifier you want preserved verbatim, as a string. The provided object replaces the existing metadata in full, so include every key you want to keep, and drop a key by omitting it. To clear all metadata, set this field to an empty object (`{}`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequest3(
            string? name,
            string? description,
            object? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest3" /> class.
        /// </summary>
        public UpdateRequest3()
        {
        }

    }
}