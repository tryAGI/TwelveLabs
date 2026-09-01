#nullable enable

namespace TwelveLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are reusable files that you can use in different workflows.<br/>
        /// The platform processes uploads asynchronously. This method returns immediately with the asset in the `processing` status, which then transitions to the `ready` status on success or to the `failed` status when the file is invalid, corrupt, or unreadable. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it. This applies to every upload, including small files.<br/>
        /// **Supported content**:<br/>
        /// - Video, audio, and image files.<br/>
        /// - PDF, text, and Markdown files.<br/>
        /// Filename extension matching is case-insensitive; for example, `notes.MD` and `notes.md` are treated the same. The platform rejects unsupported formats. For documents, it also rejects files whose extensions don't match the detected content.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **Upload limits**:<br/>
        /// - **Video and audio, local files**: Up to 200 MB<br/>
        /// - **Video and audio, public URLs**: Up to 4 GB<br/>
        /// - **Images**: Up to 32 MB<br/>
        /// - **Documents, local files**: Up to 200 MB<br/>
        /// - **Documents, public URLs**: Up to 512 MB<br/>
        /// Asset creation does not enforce a maximum duration for video and audio files. Each model applies its own file size and duration limits. For details, see the requirements below.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo/marengo-3-0#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo/marengo-3-0#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements)<br/>
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

            global::TwelveLabs.CreateRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are reusable files that you can use in different workflows.<br/>
        /// The platform processes uploads asynchronously. This method returns immediately with the asset in the `processing` status, which then transitions to the `ready` status on success or to the `failed` status when the file is invalid, corrupt, or unreadable. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it. This applies to every upload, including small files.<br/>
        /// **Supported content**:<br/>
        /// - Video, audio, and image files.<br/>
        /// - PDF, text, and Markdown files.<br/>
        /// Filename extension matching is case-insensitive; for example, `notes.MD` and `notes.md` are treated the same. The platform rejects unsupported formats. For documents, it also rejects files whose extensions don't match the detected content.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **Upload limits**:<br/>
        /// - **Video and audio, local files**: Up to 200 MB<br/>
        /// - **Video and audio, public URLs**: Up to 4 GB<br/>
        /// - **Images**: Up to 32 MB<br/>
        /// - **Documents, local files**: Up to 200 MB<br/>
        /// - **Documents, public URLs**: Up to 512 MB<br/>
        /// Asset creation does not enforce a maximum duration for video and audio files. Each model applies its own file size and duration limits. For details, see the requirements below.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo/marengo-3-0#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo/marengo-3-0#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.Asset>> CreateAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an asset<br/>
        /// This method creates an asset by uploading a file to the platform. Assets are reusable files that you can use in different workflows.<br/>
        /// The platform processes uploads asynchronously. This method returns immediately with the asset in the `processing` status, which then transitions to the `ready` status on success or to the `failed` status when the file is invalid, corrupt, or unreadable. Poll the [Retrieve an asset](/v1.3/api-reference/upload-content/direct-uploads/retrieve) endpoint until the status of the asset is `ready` before you use it. This applies to every upload, including small files.<br/>
        /// **Supported content**:<br/>
        /// - Video, audio, and image files.<br/>
        /// - PDF, text, and Markdown files.<br/>
        /// Filename extension matching is case-insensitive; for example, `notes.MD` and `notes.md` are treated the same. The platform rejects unsupported formats. For documents, it also rejects files whose extensions don't match the detected content.<br/>
        /// **Upload methods**:<br/>
        /// - **Local file**: Set the `method` parameter to `direct` and use the `file` parameter to specify the file.<br/>
        /// - **Publicly accessible URL**: Set the `method` parameter to `url` and use the `url` parameter to specify the URL of your file.<br/>
        /// **Upload limits**:<br/>
        /// - **Video and audio, local files**: Up to 200 MB<br/>
        /// - **Video and audio, public URLs**: Up to 4 GB<br/>
        /// - **Images**: Up to 32 MB<br/>
        /// - **Documents, local files**: Up to 200 MB<br/>
        /// - **Documents, public URLs**: Up to 512 MB<br/>
        /// Asset creation does not enforce a maximum duration for video and audio files. Each model applies its own file size and duration limits. For details, see the requirements below.<br/>
        /// **Additional requirements** depend on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo/marengo-3-0#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements)<br/>
        /// - **Entity search**: [Marengo image requirements](/v1.3/docs/concepts/models/marengo/marengo-3-0#image-file-requirements)<br/>
        /// - **Create embeddings**: [Marengo requirements](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements)<br/>
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
        /// Local video, audio, and documents support up to 200 MB. Image files support up to 32 MB.
        /// </param>
        /// <param name="url">
        /// Specify this parameter to upload a file from a publicly accessible URL. This parameter is required when `method` is set to `url`.<br/>
        /// Public video and audio URLs support up to 4 GB. Image URLs support up to 32 MB. Document URLs support up to 512 MB.
        /// </param>
        /// <param name="filename">
        /// The filename of the asset. If you provide a filename, the platform preserves it. If you omit it, the platform determines one from the file or URL.
        /// </param>
        /// <param name="enableHls">
        /// When set to `true`, the platform generates an HLS playlist and segments for streaming. Applicable to video and audio assets only. The platform ignores this flag for other asset types.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableThumbnail">
        /// When set to `true`, the platform generates thumbnail images from the uploaded content.<br/>
        /// For PDF files, the platform generates a representative thumbnail from the first page. Text and Markdown files do not produce thumbnails; the platform ignores this flag for them.<br/>
        /// **Default**: `false`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your assets. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float`, or `boolean`. Send this value as a JSON-encoded string.
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
            string? userMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}