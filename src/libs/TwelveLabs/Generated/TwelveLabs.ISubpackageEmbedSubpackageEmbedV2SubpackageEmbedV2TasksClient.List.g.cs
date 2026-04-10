#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient
    {
        /// <summary>
        /// List async embedding tasks<br/>
        /// This method returns a list of the async embedding tasks in your account. The platform returns your async embedding tasks sorted by creation date, with the newest at the top of the list.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Embeddings are stored for seven days.<br/>
        /// - When you invoke this method without specifying the `started_at` and `ended_at` parameters, the platform returns all the async embedding tasks created within the last seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="status"></param>
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
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbedV2TasksListResponse200> ListAsync(
            string xApiKey,
            string? startedAt = default,
            string? endedAt = default,
            string? status = default,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}