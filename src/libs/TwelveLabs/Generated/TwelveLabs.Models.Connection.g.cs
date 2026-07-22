
#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A connection to an external data provider. The platform never returns the refresh or access tokens of the connection.
    /// </summary>
    public sealed partial class Connection
    {
        /// <summary>
        /// The unique identifier of the connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The data connector provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ConnectionProviderJsonConverter))]
        public global::TwelveLabs.ConnectionProvider? Provider { get; set; }

        /// <summary>
        /// The status of the connection. See [The connection object](/v1.3/api-reference/data-connectors/the-connection-object#connection-statuses) for the possible values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::TwelveLabs.JsonConverters.ConnectionStatusJsonConverter))]
        public global::TwelveLabs.ConnectionStatus? Status { get; set; }

        /// <summary>
        /// The label you supplied when creating the connection. The platform does not interpret this value, and it does not need to be unique. Multiple connections can share the same `custom_id` value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// Information about the connected provider account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        public global::TwelveLabs.ConnectionAccount? Account { get; set; }

        /// <summary>
        /// The scopes granted to the connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the connection was established.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_at")]
        public global::System.DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the connection was last used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the connection.
        /// </param>
        /// <param name="provider">
        /// The data connector provider.
        /// </param>
        /// <param name="status">
        /// The status of the connection. See [The connection object](/v1.3/api-reference/data-connectors/the-connection-object#connection-statuses) for the possible values.
        /// </param>
        /// <param name="customId">
        /// The label you supplied when creating the connection. The platform does not interpret this value, and it does not need to be unique. Multiple connections can share the same `custom_id` value.
        /// </param>
        /// <param name="account">
        /// Information about the connected provider account.
        /// </param>
        /// <param name="scopes">
        /// The scopes granted to the connection.
        /// </param>
        /// <param name="connectedAt">
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the connection was established.
        /// </param>
        /// <param name="lastUsedAt">
        /// The date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the connection was last used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Connection(
            string? id,
            global::TwelveLabs.ConnectionProvider? provider,
            global::TwelveLabs.ConnectionStatus? status,
            string? customId,
            global::TwelveLabs.ConnectionAccount? account,
            global::System.Collections.Generic.IList<string>? scopes,
            global::System.DateTime? connectedAt,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id;
            this.Provider = provider;
            this.Status = status;
            this.CustomId = customId;
            this.Account = account;
            this.Scopes = scopes;
            this.ConnectedAt = connectedAt;
            this.LastUsedAt = lastUsedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        public Connection()
        {
        }

    }
}