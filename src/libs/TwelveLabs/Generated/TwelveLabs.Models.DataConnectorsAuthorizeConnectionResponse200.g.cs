
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataConnectorsAuthorizeConnectionResponse200
    {
        /// <summary>
        /// The URL to redirect the user to so they can grant access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorize_url")]
        public string? AuthorizeUrl { get; set; }

        /// <summary>
        /// A value the platform uses to secure the authorization flow. You do not need to read or send it: the platform includes it in the `authorize_url` field and checks it automatically when the user is redirected back. It is returned only so you can match or troubleshoot requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConnectorsAuthorizeConnectionResponse200" /> class.
        /// </summary>
        /// <param name="authorizeUrl">
        /// The URL to redirect the user to so they can grant access.
        /// </param>
        /// <param name="state">
        /// A value the platform uses to secure the authorization flow. You do not need to read or send it: the platform includes it in the `authorize_url` field and checks it automatically when the user is redirected back. It is returned only so you can match or troubleshoot requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataConnectorsAuthorizeConnectionResponse200(
            string? authorizeUrl,
            string? state)
        {
            this.AuthorizeUrl = authorizeUrl;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConnectorsAuthorizeConnectionResponse200" /> class.
        /// </summary>
        public DataConnectorsAuthorizeConnectionResponse200()
        {
        }

    }
}