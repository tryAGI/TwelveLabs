#nullable enable

namespace TwelveLabs
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// List imports<br/>
        /// This method returns a list of the imports for the specified connection. The platform returns the imports sorted by creation date, with the newest at the top of the list. Each import in the list is a summary and does not include the per-file details. To see them, use the [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ImportsListImportsResponse200> ListImportsAsync(
            string connectionId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List imports<br/>
        /// This method returns a list of the imports for the specified connection. The platform returns the imports sorted by creation date, with the newest at the top of the list. Each import in the list is a summary and does not include the per-file details. To see them, use the [Retrieve an import](/v1.3/api-reference/data-connectors/imports/retrieve-an-import) endpoint.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.ImportsListImportsResponse200>> ListImportsAsResponseAsync(
            string connectionId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}