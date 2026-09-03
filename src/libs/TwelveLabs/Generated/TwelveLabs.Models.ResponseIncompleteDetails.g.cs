
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Details about why a response is incomplete. Present when the `status` field is<br/>
    /// `incomplete`.
    /// </summary>
    public sealed partial class ResponseIncompleteDetails
    {
        /// <summary>
        /// The reason the answer is incomplete. The `max_output_tokens` value means<br/>
        /// the answer reached the output token limit. The text in the response is an<br/>
        /// incomplete answer, not the full one; treat an unrecognized value as an<br/>
        /// incomplete answer for an unknown reason, not as an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteDetails" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason the answer is incomplete. The `max_output_tokens` value means<br/>
        /// the answer reached the output token limit. The text in the response is an<br/>
        /// incomplete answer, not the full one; treat an unrecognized value as an<br/>
        /// incomplete answer for an unknown reason, not as an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseIncompleteDetails(
            string reason)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteDetails" /> class.
        /// </summary>
        public ResponseIncompleteDetails()
        {
        }

    }
}