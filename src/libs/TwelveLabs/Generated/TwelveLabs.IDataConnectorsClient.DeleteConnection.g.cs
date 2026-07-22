#nullable enable

namespace TwelveLabs
{
    public partial interface IDataConnectorsClient
    {
        /// <summary>
        /// Delete a connection<br/>
        /// This method disconnects the specified connection. The platform revokes access at the provider and deletes the stored tokens. Assets imported through this connection are retained.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConnectionAsync(
            string connectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a connection<br/>
        /// This method disconnects the specified connection. The platform revokes access at the provider and deletes the stored tokens. Assets imported through this connection are retained.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> DeleteConnectionAsResponseAsync(
            string connectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}