#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageMultipartUploadClient
    {
        /// <summary>
        /// List incomplete uploads<br/>
        /// This method returns a list of all incomplete multipart upload sessions in your account.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ListIncompleteUploadsResponse> ListIncompleteUploadsAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}