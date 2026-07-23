
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// An authorized redirect URI. During the authorization flow, the redirect URI you provide must match either a URI configured for you or one you registered through the [Register a redirect URI](/v1.3/api-reference/data-connectors/register-a-redirect-uri) method.
    /// </summary>
    public sealed partial class RedirectUri
    {
        /// <summary>
        /// The unique identifier of the redirect URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The registered redirect URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri1 { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the redirect URI was registered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectUri" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the redirect URI.
        /// </param>
        /// <param name="redirectUri1">
        /// The registered redirect URI.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the redirect URI was registered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedirectUri(
            string? id,
            string? redirectUri1,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.RedirectUri1 = redirectUri1;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedirectUri" /> class.
        /// </summary>
        public RedirectUri()
        {
        }

    }
}