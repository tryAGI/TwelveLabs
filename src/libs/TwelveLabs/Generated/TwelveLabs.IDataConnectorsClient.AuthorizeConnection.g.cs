#nullable enable

namespace TwelveLabs
{
    public partial interface IDataConnectorsClient
    {
        /// <summary>
        /// Authorize a connection<br/>
        /// This method starts the OAuth authorization flow for a data connector. The platform returns an authorization URL. Redirect the user to this URL so they can grant access to their account.<br/>
        /// After the user grants or denies access, the platform redirects them to the redirect URL you provided, with the outcome appended to that URL as query parameters. Read these parameters from the redirect that your application receives:<br/>
        /// - `connection_id`: The identifier of the new connection, returned on success. Store this value and pass it as the `connection_id` path parameter in later requests.<br/>
        /// - `status`: Set to `ok` on success.<br/>
        /// - `custom_id`: The label you supplied, returned on success when you provided one.<br/>
        /// - `error`: An error code, returned instead of the other parameters when the user denies access or the flow fails.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200> AuthorizeConnectionAsync(
            string xApiKey,

            global::TwelveLabs.AuthorizeConnectionRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize a connection<br/>
        /// This method starts the OAuth authorization flow for a data connector. The platform returns an authorization URL. Redirect the user to this URL so they can grant access to their account.<br/>
        /// After the user grants or denies access, the platform redirects them to the redirect URL you provided, with the outcome appended to that URL as query parameters. Read these parameters from the redirect that your application receives:<br/>
        /// - `connection_id`: The identifier of the new connection, returned on success. Store this value and pass it as the `connection_id` path parameter in later requests.<br/>
        /// - `status`: Set to `ok` on success.<br/>
        /// - `custom_id`: The label you supplied, returned on success when you provided one.<br/>
        /// - `error`: An error code, returned instead of the other parameters when the user denies access or the flow fails.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200>> AuthorizeConnectionAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.AuthorizeConnectionRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize a connection<br/>
        /// This method starts the OAuth authorization flow for a data connector. The platform returns an authorization URL. Redirect the user to this URL so they can grant access to their account.<br/>
        /// After the user grants or denies access, the platform redirects them to the redirect URL you provided, with the outcome appended to that URL as query parameters. Read these parameters from the redirect that your application receives:<br/>
        /// - `connection_id`: The identifier of the new connection, returned on success. Store this value and pass it as the `connection_id` path parameter in later requests.<br/>
        /// - `status`: Set to `ok` on success.<br/>
        /// - `custom_id`: The label you supplied, returned on success when you provided one.<br/>
        /// - `error`: An error code, returned instead of the other parameters when the user denies access or the flow fails.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="provider">
        /// The data connector provider to authorize.
        /// </param>
        /// <param name="redirectUri">
        /// The URL where the user is redirected after granting or denying access. If your account has an allow-list of redirect URLs configured, this URL must be on it.
        /// </param>
        /// <param name="customId">
        /// A label you supplied, stored on the connection and returned with it. Use a value that does not identify a person so you can match the connection to your own records.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.DataConnectorsAuthorizeConnectionResponse200> AuthorizeConnectionAsync(
            string xApiKey,
            string redirectUri,
            global::TwelveLabs.ConnectionsAuthorizePostRequestBodyContentApplicationJsonSchemaProvider provider = default,
            string? customId = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}