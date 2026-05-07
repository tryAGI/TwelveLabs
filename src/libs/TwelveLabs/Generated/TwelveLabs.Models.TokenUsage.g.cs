
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// The number of tokens used in the generation.
    /// </summary>
    public sealed partial class TokenUsage
    {
        /// <summary>
        /// The number of tokens in the generated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The number of tokens consumed by the input (prompt and video). Omitted for Pegasus 1.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUsage" /> class.
        /// </summary>
        /// <param name="outputTokens">
        /// The number of tokens in the generated text.
        /// </param>
        /// <param name="inputTokens">
        /// The number of tokens consumed by the input (prompt and video). Omitted for Pegasus 1.5.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenUsage(
            int outputTokens,
            int? inputTokens)
        {
            this.OutputTokens = outputTokens;
            this.InputTokens = inputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUsage" /> class.
        /// </summary>
        public TokenUsage()
        {
        }
    }
}