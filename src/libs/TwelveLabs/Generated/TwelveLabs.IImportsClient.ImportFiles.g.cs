#nullable enable

namespace TwelveLabs
{
    public partial interface IImportsClient
    {
        /// <summary>
        /// Import files<br/>
        /// This method imports one or more files from the connected provider account into the platform as assets. Video files can be up to 10 GB, audio files up to 4 GB, and images up to 32 MB. Each newly imported file creates an asset in the `processing` status and is downloaded asynchronously. If you import a file that was already imported through this account, the platform returns the existing asset with its current status, which may be `ready`, without downloading the file again. The response returns one entry per requested file, in request order.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ImportResult> ImportFilesAsync(
            string connectionId,
            string xApiKey,

            global::TwelveLabs.ImportFilesRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import files<br/>
        /// This method imports one or more files from the connected provider account into the platform as assets. Video files can be up to 10 GB, audio files up to 4 GB, and images up to 32 MB. Each newly imported file creates an asset in the `processing` status and is downloaded asynchronously. If you import a file that was already imported through this account, the platform returns the existing asset with its current status, which may be `ready`, without downloading the file again. The response returns one entry per requested file, in request order.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.ImportResult>> ImportFilesAsResponseAsync(
            string connectionId,
            string xApiKey,

            global::TwelveLabs.ImportFilesRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import files<br/>
        /// This method imports one or more files from the connected provider account into the platform as assets. Video files can be up to 10 GB, audio files up to 4 GB, and images up to 32 MB. Each newly imported file creates an asset in the `processing` status and is downloaded asynchronously. If you import a file that was already imported through this account, the platform returns the existing asset with its current status, which may be `ready`, without downloading the file again. The response returns one entry per requested file, in request order.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="items">
        /// The files to import. Provide an array of one item for a single import, or multiple items for a batch import. A maximum of 100 items can be imported per request. Each `source_id` must be unique within a request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ImportResult> ImportFilesAsync(
            string connectionId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::TwelveLabs.ConnectionsConnectionIdImportsPostRequestBodyContentApplicationJsonSchemaItemsItems> items,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}