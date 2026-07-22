#nullable enable

namespace TwelveLabs
{
    public partial interface IDataConnectorsClient
    {
        /// <summary>
        /// Generate a picker token<br/>
        /// This method generates a short-lived, read-only access token that you use with the provider's file picker, such as the Google Drive Picker. The platform never returns the refresh token of the connection.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200> CreateConnectionPickerTokenAsync(
            string connectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a picker token<br/>
        /// This method generates a short-lived, read-only access token that you use with the provider's file picker, such as the Google Drive Picker. The platform never returns the refresh token of the connection.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.DataConnectorsCreateConnectionPickerTokenResponse200>> CreateConnectionPickerTokenAsResponseAsync(
            string connectionId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}