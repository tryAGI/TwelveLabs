
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamAnalyzeResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.StreamAnalyzeResponseDiscriminatorEventTypeJsonConverter))]
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? EventType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamAnalyzeResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamAnalyzeResponseDiscriminator(
            global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? eventType)
        {
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamAnalyzeResponseDiscriminator" /> class.
        /// </summary>
        public StreamAnalyzeResponseDiscriminator()
        {
        }

    }
}