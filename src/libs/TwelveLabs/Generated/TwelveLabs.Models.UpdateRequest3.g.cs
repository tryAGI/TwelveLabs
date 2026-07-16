
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
        /// Custom metadata for the knowledge store. Both keys and values must be strings. The provided object replaces the existing metadata in full, so include every key you want to keep. To clear all metadata, set this field to an empty object (`{}`). A null value is stored as an empty string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

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
        /// Custom metadata for the knowledge store. Both keys and values must be strings. The provided object replaces the existing metadata in full, so include every key you want to keep. To clear all metadata, set this field to an empty object (`{}`). A null value is stored as an empty string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRequest3(
            string? name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
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