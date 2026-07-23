#nullable enable

namespace TwelveLabs
{
    public partial interface IDataConnectorsClient
    {
        /// <summary>
        /// Delete a redirect URI<br/>
        /// This method removes a redirect URI from your authorized redirect URIs. After deletion, the [Authorize a connection](/v1.3/api-reference/data-connectors/authorize-a-connection) method no longer accepts it. This action cannot be undone.
        /// </summary>
        /// <param name="redirectUriId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRedirectUriAsync(
            string redirectUriId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a redirect URI<br/>
        /// This method removes a redirect URI from your authorized redirect URIs. After deletion, the [Authorize a connection](/v1.3/api-reference/data-connectors/authorize-a-connection) method no longer accepts it. This action cannot be undone.
        /// </summary>
        /// <param name="redirectUriId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> DeleteRedirectUriAsResponseAsync(
            string redirectUriId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}