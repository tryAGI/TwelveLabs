#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are media files that you can use in downstream workflows, including indexing, analyzing video content, and creating entities.<br/>
        /// **Supported content**: Video, audio, and images.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **Upload limits**:<br/>
        /// - **Video and audio, local files**: Up to 200 MB<br/>
        /// - **Video and audio, public URLs**: Up to 4 GB<br/>
        /// - **Images**: Up to 5 MB<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#input-requirements)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.Asset> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateRequest2 request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are media files that you can use in downstream workflows, including indexing, analyzing video content, and creating entities.<br/>
        /// **Supported content**: Video, audio, and images.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **Upload limits**:<br/>
        /// - **Video and audio, local files**: Up to 200 MB<br/>
        /// - **Video and audio, public URLs**: Up to 4 GB<br/>
        /// - **Images**: Up to 5 MB<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#input-requirements)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="method">
        /// Specifies the upload method for the asset. Use `direct` to upload a local file or `url` for a publicly accessible URL.
        /// </param>
        /// <param name="file">
        /// Specify this parameter to upload a file from your local file system. This parameter is required when `method` is set to `direct`.<br/>
        /// Local video and audio files support up to 200 MB. Image files support up to 5 MB.
        /// </param>
        /// <param name="url">
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// Public video and audio URLs support up to 4 GB. Image URLs support up to 5 MB.
        /// </param>
        /// <param name="filename">
        /// The optional filename of the asset. If not provided, the platform will determine the filename from the file or URL.
        /// </param>
        /// <param name="enableHls">
        /// When set to `true`, the platform generates an HLS playlist and segments for streaming. Applicable to video and audio assets only.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableThumbnail">
        /// When set to `true`, the platform generates thumbnail images from the uploaded content.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.Asset> CreateAsync(
            string xApiKey,
            global::TwelveLabs.AssetsPostRequestBodyContentMultipartFormDataSchemaMethod method,
            byte[]? file = default,
            string? url = default,
            string? filename = default,
            bool? enableHls = default,
            bool? enableThumbnail = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}