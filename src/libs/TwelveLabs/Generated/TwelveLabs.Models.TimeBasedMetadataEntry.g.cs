
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// One time-aligned metadata entry. The platform folds the text of the entry into the fused embedding of every segment that overlaps the time range of the entry.
    /// </summary>
    public sealed partial class TimeBasedMetadataEntry
    {
        /// <summary>
        /// The start time of the entry in seconds, measured from the beginning of the asset. Set the same value in the `end` field for an event that happens at a single point in time, such as one entry in a stats feed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// The end time of the entry in seconds, measured from the beginning of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// The text to fold into the fused embedding of the overlapping segments.
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
        /// Initializes a new instance of the <see cref="TimeBasedMetadataEntry" /> class.
        /// </summary>
        /// <param name="start">
        /// The start time of the entry in seconds, measured from the beginning of the asset. Set the same value in the `end` field for an event that happens at a single point in time, such as one entry in a stats feed.
        /// </param>
        /// <param name="end">
        /// The end time of the entry in seconds, measured from the beginning of the asset.
        /// </param>
        /// <param name="text">
        /// The text to fold into the fused embedding of the overlapping segments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeBasedMetadataEntry(
            double start,
            double end,
            string text)
        {
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeBasedMetadataEntry" /> class.
        /// </summary>
        public TimeBasedMetadataEntry()
        {
        }

    }
}