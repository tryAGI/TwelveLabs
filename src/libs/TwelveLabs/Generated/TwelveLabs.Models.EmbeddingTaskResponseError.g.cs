
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An object describing why the embedding task failed. Present only when `status` is `failed`. Omitted otherwise.
    /// </summary>
    public sealed partial class EmbeddingTaskResponseError
    {
        /// <summary>
        /// A human-readable message that describes why the task failed. Possible values:<br/>
        /// - "The embedding service is temporarily unstable. Please try again later."<br/>
        /// - "We could not process your media for embedding. Please verify the input file and try again."<br/>
        /// - "The embedding task failed. Please try again later."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable message that describes why the task failed. Possible values:<br/>
        /// - "The embedding service is temporarily unstable. Please try again later."<br/>
        /// - "We could not process your media for embedding. Please verify the input file and try again."<br/>
        /// - "The embedding task failed. Please try again later."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingTaskResponseError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTaskResponseError" /> class.
        /// </summary>
        public EmbeddingTaskResponseError()
        {
        }

    }
}