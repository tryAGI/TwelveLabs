#nullable enable

namespace TwelveLabs
{
    public partial interface IEmbedV2TasksClient
    {
        /// <summary>
        /// List async embedding tasks<br/>
        /// This method returns a list of the async embedding tasks in your account. The platform returns tasks sorted by creation date, with the newest at the top of the list.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Embeddings are stored for seven days.<br/>
        /// - Without the `started_at` or `ended_at` query parameters, this method lists tasks created in the last seven days.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbedV2TasksListResponse200> ListAsync(
            string? startedAt = default,
            string? endedAt = default,
            string? status = default,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List async embedding tasks<br/>
        /// This method returns a list of the async embedding tasks in your account. The platform returns tasks sorted by creation date, with the newest at the top of the list.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Embeddings are stored for seven days.<br/>
        /// - Without the `started_at` or `ended_at` query parameters, this method lists tasks created in the last seven days.<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.EmbedV2TasksListResponse200>> ListAsResponseAsync(
            string? startedAt = default,
            string? endedAt = default,
            string? status = default,
            int? page = default,
            int? pageLimit = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}