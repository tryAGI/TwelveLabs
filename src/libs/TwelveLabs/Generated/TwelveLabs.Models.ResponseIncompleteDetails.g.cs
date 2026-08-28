
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Why a response is incomplete. Accompanies `status: incomplete`.
    /// </summary>
    public sealed partial class ResponseIncompleteDetails
    {
        /// <summary>
        /// What stopped the answer. `max_output_tokens` means the answer reached the<br/>
        /// output limit before it was finished; the text received is a valid prefix of<br/>
        /// the answer, not a whole one.<br/>
        /// Treat a reason you do not recognize as "not a whole answer, for a reason this<br/>
        /// client does not know" rather than as an error.
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
        /// What stopped the answer. `max_output_tokens` means the answer reached the<br/>
        /// output limit before it was finished; the text received is a valid prefix of<br/>
        /// the answer, not a whole one.<br/>
        /// Treat a reason you do not recognize as "not a whole answer, for a reason this<br/>
        /// client does not know" rather than as an error.
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