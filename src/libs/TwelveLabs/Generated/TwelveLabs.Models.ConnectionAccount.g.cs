
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// Information about the connected provider account.
    /// </summary>
    public sealed partial class ConnectionAccount
    {
        /// <summary>
        /// The identifier of the account at the provider. It does not change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// A human-readable label for the account, such as an email address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionAccount" /> class.
        /// </summary>
        /// <param name="externalId">
        /// The identifier of the account at the provider. It does not change.
        /// </param>
        /// <param name="displayName">
        /// A human-readable label for the account, such as an email address.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionAccount(
            string? externalId,
            string? displayName)
        {
            this.ExternalId = externalId;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionAccount" /> class.
        /// </summary>
        public ConnectionAccount()
        {
        }

    }
}