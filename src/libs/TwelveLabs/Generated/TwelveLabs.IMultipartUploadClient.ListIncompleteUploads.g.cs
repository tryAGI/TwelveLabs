#nullable enable

namespace TwelveLabs
{
    public partial interface IMultipartUploadClient
    {
        /// <summary>
        /// List incomplete uploads<br/>
        /// This method returns a list of the incomplete multipart upload sessions in your account. The list includes sessions in the `active` and `expired` statuses and omits sessions in the `completed` and `failed` statuses. The platform periodically deletes expired sessions, after which they no longer appear in this list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ListIncompleteUploadsResponse> ListIncompleteUploadsAsync(
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List incomplete uploads<br/>
        /// This method returns a list of the incomplete multipart upload sessions in your account. The list includes sessions in the `active` and `expired` statuses and omits sessions in the `completed` and `failed` statuses. The platform periodically deletes expired sessions, after which they no longer appear in this list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.ListIncompleteUploadsResponse>> ListIncompleteUploadsAsResponseAsync(
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}