
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Token counts for the request. Only Marengo 3.5 returns this object.
    /// </summary>
    public sealed partial class EmbeddingUsage
    {
        /// <summary>
        /// The number of tokens the request used. Each key names a type of content the request processed, and each value is the token count for that content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> InputTokens { get; set; }

        /// <summary>
        /// Whether the input was truncated to fit within the token limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Truncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of tokens the request used. Each key names a type of content the request processed, and each value is the token count for that content.
        /// </param>
        /// <param name="truncated">
        /// Whether the input was truncated to fit within the token limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingUsage(
            global::System.Collections.Generic.Dictionary<string, int> inputTokens,
            bool truncated)
        {
            this.InputTokens = inputTokens ?? throw new global::System.ArgumentNullException(nameof(inputTokens));
            this.Truncated = truncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        public EmbeddingUsage()
        {
        }

    }
}