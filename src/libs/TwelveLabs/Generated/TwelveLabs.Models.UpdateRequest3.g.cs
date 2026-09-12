
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
        /// Custom metadata for the knowledge store, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings; values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string. The provided object replaces the existing metadata in full, so include every key you want to keep and omit the ones you want to remove. To clear all metadata, set this field to an empty object (`{}`).
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
        /// Custom metadata for the knowledge store, as user-defined key-value pairs. Up to 10 pairs, keys up to 128 characters, string values up to 2048 characters. Keys are strings; values can be a string, a number, a boolean, or an array of strings. A nested object, an array containing anything other than strings, and a null value are rejected. An integer must fit in 53 bits (-9007199254740991 to 9007199254740991). Send a wider integer, or an identifier that must be preserved verbatim, as a string. The provided object replaces the existing metadata in full, so include every key you want to keep and omit the ones you want to remove. To clear all metadata, set this field to an empty object (`{}`).
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