
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataConnectorsCreateConnectionPickerTokenResponse200
    {
        /// <summary>
        /// A short-lived, read-only access token for use with the provider's file picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// The number of seconds until the token expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// A space-delimited list of the scopes granted to the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// The Google Cloud project number, used with the Google Picker's `setAppId`. May be absent if the provider does not require this value for its picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// A browser API key, used with the Google Picker's `setDeveloperKey`. May be absent if the provider does not require this value for its picker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developer_key")]
        public string? DeveloperKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConnectorsCreateConnectionPickerTokenResponse200" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// A short-lived, read-only access token for use with the provider's file picker.
        /// </param>
        /// <param name="expiresIn">
        /// The number of seconds until the token expires.
        /// </param>
        /// <param name="scope">
        /// A space-delimited list of the scopes granted to the token.
        /// </param>
        /// <param name="appId">
        /// The Google Cloud project number, used with the Google Picker's `setAppId`. May be absent if the provider does not require this value for its picker.
        /// </param>
        /// <param name="developerKey">
        /// A browser API key, used with the Google Picker's `setDeveloperKey`. May be absent if the provider does not require this value for its picker.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataConnectorsCreateConnectionPickerTokenResponse200(
            string? accessToken,
            int? expiresIn,
            string? scope,
            string? appId,
            string? developerKey)
        {
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
            this.Scope = scope;
            this.AppId = appId;
            this.DeveloperKey = developerKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConnectorsCreateConnectionPickerTokenResponse200" /> class.
        /// </summary>
        public DataConnectorsCreateConnectionPickerTokenResponse200()
        {
        }

    }
}