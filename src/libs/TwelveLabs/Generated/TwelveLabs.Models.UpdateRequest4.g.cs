
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRequest4
    {
        /// <summary>
        /// The name of the item collection. Must be unique within the knowledge store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// An optional description of the item collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom metadata for the item collection. Both keys and values must be strings. To remove all metadata, set this field to an empty object (`{}`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest4" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the item collection. Must be unique within the knowledge store.
        /// </param>
        /// <param name="description">
        /// An optional description of the item collection.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the item collection. Both keys and values must be strings. To remove all metadata, set this field to an empty object (`{}`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequest4(
            string? name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequest4" /> class.
        /// </summary>
        public UpdateRequest4()
        {
        }

    }
}