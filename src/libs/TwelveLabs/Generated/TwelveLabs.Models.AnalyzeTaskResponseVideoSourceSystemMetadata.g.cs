
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// System-extracted video metadata. Present on a best-effort basis once the video has been processed.
    /// </summary>
    public sealed partial class AnalyzeTaskResponseVideoSourceSystemMetadata
    {
        /// <summary>
        /// The video duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseVideoSourceSystemMetadata" /> class.
        /// </summary>
        /// <param name="duration">
        /// The video duration in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeTaskResponseVideoSourceSystemMetadata(
            double? duration)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeTaskResponseVideoSourceSystemMetadata" /> class.
        /// </summary>
        public AnalyzeTaskResponseVideoSourceSystemMetadata()
        {
        }
    }
}