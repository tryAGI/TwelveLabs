#nullable enable

namespace TwelveLabs
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Create a video indexing task<br/>
        /// &lt;Info&gt;This method will be removed in a future version. New implementations should use [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) uploads followed by [separate indexing](/v1.3/api-reference/index-content/create).&lt;/Info&gt;<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Note title="Adding videos to existing indexes"&gt;<br/>
        /// You can no longer add videos to an index that has only Pegasus 1.2 enabled. When you add videos to an index that has both Marengo and Pegasus 1.2 enabled, the platform indexes them with Marengo only.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// Indexes have limits on video hours and video count. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.TasksCreateResponse200> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateRequest9 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video indexing task<br/>
        /// &lt;Info&gt;This method will be removed in a future version. New implementations should use [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) uploads followed by [separate indexing](/v1.3/api-reference/index-content/create).&lt;/Info&gt;<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Note title="Adding videos to existing indexes"&gt;<br/>
        /// You can no longer add videos to an index that has only Pegasus 1.2 enabled. When you add videos to an index that has both Marengo and Pegasus 1.2 enabled, the platform indexes them with Marengo only.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// Indexes have limits on video hours and video count. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.TasksCreateResponse200>> CreateAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateRequest9 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video indexing task<br/>
        /// &lt;Info&gt;This method will be removed in a future version. New implementations should use [direct](/v1.3/api-reference/upload-content/direct-uploads) or [multipart](/v1.3/api-reference/upload-content/multipart-uploads) uploads followed by [separate indexing](/v1.3/api-reference/index-content/create).&lt;/Info&gt;<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Note title="Adding videos to existing indexes"&gt;<br/>
        /// You can no longer add videos to an index that has only Pegasus 1.2 enabled. When you add videos to an index that has both Marengo and Pegasus 1.2 enabled, the platform indexes them with Marengo only.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// Indexes have limits on video hours and video count. For details, see the [Video hours and video count limits](/v1.3/docs/concepts/indexes#video-hours-and-video-count-limits) section.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="indexId">
        /// The unique identifier of the index to which the video is being uploaded.
        /// </param>
        /// <param name="videoFile">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoFilename">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoUrl">
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </param>
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/videos/{video-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float`, or `boolean`. Send this value as a JSON-encoded string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.TasksCreateResponse200> CreateAsync(
            string xApiKey,
            string indexId,
            byte[]? videoFile = default,
            string? videoFilename = default,
            string? videoUrl = default,
            bool? enableVideoStream = default,
            string? userMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}