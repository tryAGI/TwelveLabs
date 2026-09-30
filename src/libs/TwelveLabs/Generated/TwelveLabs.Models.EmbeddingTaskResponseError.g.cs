
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
        /// - "The embedding task failed. Please try again later."<br/>
        /// - "The embedding task could not complete processing."<br/>
        /// - "The embedding request was invalid."<br/>
        /// - "The media exceeds the maximum allowed size for embedding."<br/>
        /// - "Content exceeds the model's context window."<br/>
        /// - "The embedding result is no longer available and cannot be retrieved."<br/>
        /// - "failed to fetch or materialize source media"<br/>
        /// - "We could not process your media for embedding. Please verify the input file and try again." For the steps to fix the file, see the [How do I fix a file that could not be processed for embedding?](/v1.3/docs/resources/frequently-asked-questions#how-do-i-fix-a-file-that-could-not-be-processed-for-embedding) section on the **Frequently asked questions** page.<br/>
        /// When the platform can measure the overage in pages, bytes, or seconds, the message includes those numbers in place of the fixed sentence for that limit. For example: "Document (17 pages) exceeds maximum limit of 6 pages", "File size (33.6 MB) exceeds maximum limit of 32 MB", or "Duration (35.0 seconds) exceeds maximum limit of 30 seconds (0 minutes)".
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
        /// - "The embedding task failed. Please try again later."<br/>
        /// - "The embedding task could not complete processing."<br/>
        /// - "The embedding request was invalid."<br/>
        /// - "The media exceeds the maximum allowed size for embedding."<br/>
        /// - "Content exceeds the model's context window."<br/>
        /// - "The embedding result is no longer available and cannot be retrieved."<br/>
        /// - "failed to fetch or materialize source media"<br/>
        /// - "We could not process your media for embedding. Please verify the input file and try again." For the steps to fix the file, see the [How do I fix a file that could not be processed for embedding?](/v1.3/docs/resources/frequently-asked-questions#how-do-i-fix-a-file-that-could-not-be-processed-for-embedding) section on the **Frequently asked questions** page.<br/>
        /// When the platform can measure the overage in pages, bytes, or seconds, the message includes those numbers in place of the fixed sentence for that limit. For example: "Document (17 pages) exceeds maximum limit of 6 pages", "File size (33.6 MB) exceeds maximum limit of 32 MB", or "Duration (35.0 seconds) exceeds maximum limit of 30 seconds (0 minutes)".
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