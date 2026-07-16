
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The search query.
    /// </summary>
    public sealed partial class KnowledgeStoreSearchQuery
    {
        /// <summary>
        /// Describe what you're searching for in natural language (Examples: `A person cooking pasta` or `aerial shots of a city at night`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreSearchQuery" /> class.
        /// </summary>
        /// <param name="text">
        /// Describe what you're searching for in natural language (Examples: `A person cooking pasta` or `aerial shots of a city at night`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeStoreSearchQuery(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeStoreSearchQuery" /> class.
        /// </summary>
        public KnowledgeStoreSearchQuery()
        {
        }

    }
}