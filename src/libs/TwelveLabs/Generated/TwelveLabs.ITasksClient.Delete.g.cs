#nullable enable

namespace TwelveLabs
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Delete a video indexing task<br/>
        /// &lt;Info&gt;This method will be removed in a future version.&lt;/Info&gt;<br/>
        /// This action cannot be undone.<br/>
        /// Note the following about deleting a video indexing task:<br/>
        /// - You can only delete video indexing tasks for which the status is `ready` or `failed`.<br/>
        /// - If the status of your video indexing task is `ready`, you must first delete the video vector associated with your video indexing task by calling the [`DELETE`](/v1.3/api-reference/videos/delete) method of the `/indexes/videos` endpoint.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string taskId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a video indexing task<br/>
        /// &lt;Info&gt;This method will be removed in a future version.&lt;/Info&gt;<br/>
        /// This action cannot be undone.<br/>
        /// Note the following about deleting a video indexing task:<br/>
        /// - You can only delete video indexing tasks for which the status is `ready` or `failed`.<br/>
        /// - If the status of your video indexing task is `ready`, you must first delete the video vector associated with your video indexing task by calling the [`DELETE`](/v1.3/api-reference/videos/delete) method of the `/indexes/videos` endpoint.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string taskId,
            string xApiKey,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}