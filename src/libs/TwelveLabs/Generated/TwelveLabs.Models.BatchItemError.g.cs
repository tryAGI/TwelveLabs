
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Failure details for a single batch item.
    /// </summary>
    public sealed partial class BatchItemError
    {
        /// <summary>
        /// A machine-readable error code identifying the failure category. Omitted until the per-item error catalog is wired through; until then, only `message` is guaranteed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable explanation of the failure.
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
        /// Initializes a new instance of the <see cref="BatchItemError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the failure.
        /// </param>
        /// <param name="code">
        /// A machine-readable error code identifying the failure category. Omitted until the per-item error catalog is wired through; until then, only `message` is guaranteed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchItemError(
            string message,
            string? code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItemError" /> class.
        /// </summary>
        public BatchItemError()
        {
        }

    }
}