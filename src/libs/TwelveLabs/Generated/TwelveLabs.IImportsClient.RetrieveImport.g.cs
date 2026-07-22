#nullable enable

namespace TwelveLabs
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// Retrieve an import<br/>
        /// This method retrieves a single import, including the current status of each asset in the import.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="importId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ImportDetail> RetrieveImportAsync(
            string connectionId,
            string importId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve an import<br/>
        /// This method retrieves a single import, including the current status of each asset in the import.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="importId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.ImportDetail>> RetrieveImportAsResponseAsync(
            string connectionId,
            string importId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}