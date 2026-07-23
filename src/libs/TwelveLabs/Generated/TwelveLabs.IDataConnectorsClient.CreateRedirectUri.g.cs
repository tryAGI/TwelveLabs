#nullable enable

namespace TwelveLabs
{
    public partial interface IDataConnectorsClient
    {
        /// <summary>
        /// Register a redirect URI<br/>
        /// This method registers a redirect URI so the [Authorize a connection](/v1.3/api-reference/data-connectors/authorize-a-connection) method accepts it.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.RedirectUri> CreateRedirectUriAsync(
            string xApiKey,

            global::TwelveLabs.CreateRedirectUriRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a redirect URI<br/>
        /// This method registers a redirect URI so the [Authorize a connection](/v1.3/api-reference/data-connectors/authorize-a-connection) method accepts it.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.RedirectUri>> CreateRedirectUriAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateRedirectUriRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a redirect URI<br/>
        /// This method registers a redirect URI so the [Authorize a connection](/v1.3/api-reference/data-connectors/authorize-a-connection) method accepts it.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="redirectUri">
        /// The redirect URI to register. Must use HTTPS, resolve to a public host, and contain no wildcards. Register it exactly as your application sends it, because the authorization flow requires an exact match.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.RedirectUri> CreateRedirectUriAsync(
            string xApiKey,
            string redirectUri,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}