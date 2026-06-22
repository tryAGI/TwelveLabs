#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient
    {
        /// <summary>
        /// Retrieve task status and results<br/>
        /// This method retrieves the status and the results of an async embedding task.<br/>
        /// Invoke this method repeatedly until the `status` field is `ready` or `failed`. When the status is `ready`, use the embeddings from the response. When the status is `failed`, the `error.message` field contains the reason.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// Embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingTaskResponse> RetrieveAsync(
            string taskId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve task status and results<br/>
        /// This method retrieves the status and the results of an async embedding task.<br/>
        /// Invoke this method repeatedly until the `status` field is `ready` or `failed`. When the status is `ready`, use the embeddings from the response. When the status is `failed`, the `error.message` field contains the reason.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// Embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.EmbeddingTaskResponse>> RetrieveAsResponseAsync(
            string taskId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}