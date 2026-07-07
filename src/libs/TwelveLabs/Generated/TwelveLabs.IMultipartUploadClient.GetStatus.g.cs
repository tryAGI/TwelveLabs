#nullable enable

namespace TwelveLabs
{
    public partial interface IMultipartUploadClient
    {
        /// <summary>
        /// Retrieve the status of an upload session<br/>
        /// This method provides information about an upload session, including its current status, chunk-level progress, and completion state.<br/>
        /// Use this method to:<br/>
        /// - Verify upload completion (`status` = `completed`)<br/>
        /// - Identify any failed chunks that require a retry<br/>
        /// - Monitor the upload progress by comparing `uploaded_size` with `total_size`<br/>
        /// - Determine if the session has expired<br/>
        /// - Retrieve the status information for each chunk<br/>
        /// After you report chunk completion, call this method to confirm the upload session reached the `completed` status. This status means the platform received the file, not that the asset is ready to use. The platform then validates the asset asynchronously. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it.
        /// </summary>
        /// <param name="uploadId"></param>
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.GetUploadStatusResponse> GetStatusAsync(
            string uploadId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve the status of an upload session<br/>
        /// This method provides information about an upload session, including its current status, chunk-level progress, and completion state.<br/>
        /// Use this method to:<br/>
        /// - Verify upload completion (`status` = `completed`)<br/>
        /// - Identify any failed chunks that require a retry<br/>
        /// - Monitor the upload progress by comparing `uploaded_size` with `total_size`<br/>
        /// - Determine if the session has expired<br/>
        /// - Retrieve the status information for each chunk<br/>
        /// After you report chunk completion, call this method to confirm the upload session reached the `completed` status. This status means the platform received the file, not that the asset is ready to use. The platform then validates the asset asynchronously. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it.
        /// </summary>
        /// <param name="uploadId"></param>
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.GetUploadStatusResponse>> GetStatusAsResponseAsync(
            string uploadId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}