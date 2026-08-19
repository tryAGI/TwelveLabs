
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A timestamped transcription entry.
    /// </summary>
    public sealed partial class AssetTranscriptionEntry
    {
        /// <summary>
        /// The start timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The end timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// The recognized text in this time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscriptionEntry" /> class.
        /// </summary>
        /// <param name="start">
        /// The start timestamp in seconds.
        /// </param>
        /// <param name="end">
        /// The end timestamp in seconds.
        /// </param>
        /// <param name="value">
        /// The recognized text in this time range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetTranscriptionEntry(
            double start,
            double end,
            string value)
        {
            this.Start = start;
            this.End = end;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscriptionEntry" /> class.
        /// </summary>
        public AssetTranscriptionEntry()
        {
        }

    }
}