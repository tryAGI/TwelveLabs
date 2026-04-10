#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageTasksClient
    {
        /// <summary>
        /// List video indexing tasks<br/>
        /// This method returns a list of the video indexing tasks in your account. The platform returns your video indexing tasks sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="indexId"></param>
        /// <param name="status"></param>
        /// <param name="filename"></param>
        /// <param name="duration"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.TasksListResponse200> ListAsync(
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            string? indexId = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.TasksGetParametersStatusSchemaItems>? status = default,
            string? filename = default,
            double? duration = default,
            int? width = default,
            int? height = default,
            string? createdAt = default,
            string? updatedAt = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}