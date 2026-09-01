
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Wraps your settings in a `temporal` object. Use with Marengo 3.5.
    /// </summary>
    public sealed partial class AsyncTemporalSegmentation
    {
        /// <summary>
        /// Specifies how the platform divides the file into segments. The `strategy` field selects one variant:<br/>
        /// - `dynamic`: Creates variable-length segments that align with scene or content boundaries. Use this for content-aware segmentation.<br/>
        /// - `fixed`: Creates equal-length segments. Use this for consistent timing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temporal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.TemporalSegmentationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::TwelveLabs.TemporalSegmentation Temporal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTemporalSegmentation" /> class.
        /// </summary>
        /// <param name="temporal">
        /// Specifies how the platform divides the file into segments. The `strategy` field selects one variant:<br/>
        /// - `dynamic`: Creates variable-length segments that align with scene or content boundaries. Use this for content-aware segmentation.<br/>
        /// - `fixed`: Creates equal-length segments. Use this for consistent timing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncTemporalSegmentation(
            global::TwelveLabs.TemporalSegmentation temporal)
        {
            this.Temporal = temporal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncTemporalSegmentation" /> class.
        /// </summary>
        public AsyncTemporalSegmentation()
        {
        }

    }
}