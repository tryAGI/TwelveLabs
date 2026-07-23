
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorizeConnectionRequest
    {
        /// <summary>
        /// The data connector provider to authorize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProviderJsonConverter))]
        public global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider Provider { get; set; }

        /// <summary>
        /// The URI where the user is redirected after granting or denying access. By default, any redirect URI is accepted. If you've authorized specific redirect URIs with the [Register a redirect URI](/v1.3/api-reference/data-connectors/register-a-redirect-uri) method, this URI must be one of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUri { get; set; }

        /// <summary>
        /// A label you supplied, stored on the connection and returned with it. Use a value that does not identify a person so you can match the connection to your own records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeConnectionRequest" /> class.
        /// </summary>
        /// <param name="redirectUri">
        /// The URI where the user is redirected after granting or denying access. By default, any redirect URI is accepted. If you've authorized specific redirect URIs with the [Register a redirect URI](/v1.3/api-reference/data-connectors/register-a-redirect-uri) method, this URI must be one of them.
        /// </param>
        /// <param name="provider">
        /// The data connector provider to authorize.
        /// </param>
        /// <param name="customId">
        /// A label you supplied, stored on the connection and returned with it. Use a value that does not identify a person so you can match the connection to your own records.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizeConnectionRequest(
            string redirectUri,
            global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider provider,
            string? customId)
        {
            this.Provider = provider;
            this.RedirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            this.CustomId = customId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeConnectionRequest" /> class.
        /// </summary>
        public AuthorizeConnectionRequest()
        {
        }

    }
}