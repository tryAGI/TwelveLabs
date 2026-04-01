
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Details about why the task failed.
    /// </summary>
    public sealed partial class AnalyzeTaskError
    {
        /// <summary>
        /// A message that describes why the task failed.
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
        /// Initializes a new instance of the <see cref="AnalyzeTaskError" /> class.
        /// </summary>
        /// <param name="message">
        /// A message that describes why the task failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskError" /> class.
        /// </summary>
        public AnalyzeTaskError()
        {
        }
    }
}