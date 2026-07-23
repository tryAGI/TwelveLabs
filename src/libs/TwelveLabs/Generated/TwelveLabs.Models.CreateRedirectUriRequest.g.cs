
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRedirectUriRequest
    {
        /// <summary>
        /// The redirect URI to register. Must use HTTPS, resolve to a public host, and contain no wildcards. Register it exactly as your application sends it, because the authorization flow requires an exact match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRedirectUriRequest" /> class.
        /// </summary>
        /// <param name="redirectUri">
        /// The redirect URI to register. Must use HTTPS, resolve to a public host, and contain no wildcards. Register it exactly as your application sends it, because the authorization flow requires an exact match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRedirectUriRequest(
            string redirectUri)
        {
            this.RedirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRedirectUriRequest" /> class.
        /// </summary>
        public CreateRedirectUriRequest()
        {
        }

    }
}