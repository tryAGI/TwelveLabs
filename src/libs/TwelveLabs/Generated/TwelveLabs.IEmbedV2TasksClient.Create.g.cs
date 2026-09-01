#nullable enable

namespace TwelveLabs
{
    public partial interface IEmbedV2TasksClient
    {
        /// <summary>
        /// Create an async embedding task<br/>
        /// This method creates embeddings for audio, video, images, and documents asynchronously.<br/>
        /// Use this method to embed content at scale, such as long files or the media files you want to make searchable. For a query, or for results you need in the same request, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-embeddings) method of the `/embed-v2` endpoint instead.<br/>
        /// The content this method accepts depends on the model. Both models embed audio and video. Marengo 3.5 also embeds images and PDF files. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// Creating embeddings asynchronously requires three steps:<br/>
        /// 1. Create a task using this method. The platform returns a task identifier.<br/>
        /// 2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        /// 3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Creating a task validates only basic metadata and playability, not the full file. A file can pass this check but still fail later during embedding. When you retrieve the results, check the [`status`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.status) field. If it is `failed`, the [`error.message`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.error.message) field contains the reason.<br/>
        /// - This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A task can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// - Embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbedV2TasksCreateResponse202> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateAsyncEmbeddingRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async embedding task<br/>
        /// This method creates embeddings for audio, video, images, and documents asynchronously.<br/>
        /// Use this method to embed content at scale, such as long files or the media files you want to make searchable. For a query, or for results you need in the same request, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-embeddings) method of the `/embed-v2` endpoint instead.<br/>
        /// The content this method accepts depends on the model. Both models embed audio and video. Marengo 3.5 also embeds images and PDF files. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// Creating embeddings asynchronously requires three steps:<br/>
        /// 1. Create a task using this method. The platform returns a task identifier.<br/>
        /// 2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        /// 3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Creating a task validates only basic metadata and playability, not the full file. A file can pass this check but still fail later during embedding. When you retrieve the results, check the [`status`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.status) field. If it is `failed`, the [`error.message`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.error.message) field contains the reason.<br/>
        /// - This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A task can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// - Embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.EmbedV2TasksCreateResponse202>> CreateAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.CreateAsyncEmbeddingRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async embedding task<br/>
        /// This method creates embeddings for audio, video, images, and documents asynchronously.<br/>
        /// Use this method to embed content at scale, such as long files or the media files you want to make searchable. For a query, or for results you need in the same request, use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-embeddings) method of the `/embed-v2` endpoint instead.<br/>
        /// The content this method accepts depends on the model. Both models embed audio and video. Marengo 3.5 also embeds images and PDF files. For the formats, resolutions, file sizes, and duration limits each model accepts, see the input requirements for [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5#input-requirements) or [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0#input-requirements).<br/>
        /// Creating embeddings asynchronously requires three steps:<br/>
        /// 1. Create a task using this method. The platform returns a task identifier.<br/>
        /// 2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        /// 3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Creating a task validates only basic metadata and playability, not the full file. A file can pass this check but still fail later during embedding. When you retrieve the results, check the [`status`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.status) field. If it is `failed`, the [`error.message`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.error.message) field contains the reason.<br/>
        /// - This method is rate-limited. With Marengo 3.5, the platform counts input tokens for each type of content. A task can exceed a limit before you see an error. For details, see [Input token limits for embedding](/v1.3/docs/get-started/rate-limits#input-token-limits-for-embedding).<br/>
        /// - Embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: An audio file.<br/>
        /// - `video`: A video file.<br/>
        /// - `document`: A PDF file. Requires Marengo 3.5.<br/>
        /// - `image`: An image file. Requires Marengo 3.5.
        /// </param>
        /// <param name="modelName">
        /// The embedding model to use.<br/>
        /// **Values**:<br/>
        /// - `marengo3.5`: For details about this version, see the [Marengo 3.5](/v1.3/docs/concepts/models/marengo/marengo-3-5) page.<br/>
        /// - `marengo3.0`: For details about this version, see the [Marengo 3.0](/v1.3/docs/concepts/models/marengo/marengo-3-0) page.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="embeddingUncertainty">
        /// Set this parameter to `true` to receive a [`data[].embedding_uncertainty`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings#response.body.data.embedding-uncertainty) field in the response, representing a per-dimension uncertainty vector with the same length as the `embedding` array. A higher value shows lower confidence in that dimension. Requires Marengo 3.5.<br/>
        /// To use this parameter with audio or video input, exclude the `asset` scope from the `embedding_scope` field. For example, set `video.embedding_scope` to `["clip"]`. The field defaults to `["clip", "asset"]`, so a request that keeps the default returns a `400` error. This restriction does not apply to `document` and `image` input.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="document">
        /// This field is required if the `input_type` parameter is `document`. Requires Marengo 3.5.<br/>
        /// The platform embeds the rendered pages of your PDF file, one embedding per page.
        /// </param>
        /// <param name="image">
        /// This field is required if the `input_type` parameter is `image`. Requires Marengo 3.5. The image can be up to 32 MB before encoding, whether you provide a URL, an asset identifier, or base64-encoded data. For an image, the `embedding_option`, `embedding_type`, and `embedding_scope` fields each accept a single value; any other value returns a `400` error.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.EmbedV2TasksCreateResponse202> CreateAsync(
            string xApiKey,
            global::TwelveLabs.CreateAsyncEmbeddingRequestInputType inputType,
            global::TwelveLabs.CreateAsyncEmbeddingRequestModelName modelName = global::TwelveLabs.CreateAsyncEmbeddingRequestModelName.Marengo30,
            bool? embeddingUncertainty = default,
            global::TwelveLabs.AsyncAudioInputRequest? audio = default,
            global::TwelveLabs.AsyncVideoInputRequest? video = default,
            global::TwelveLabs.AsyncDocumentInputRequest? document = default,
            global::TwelveLabs.AsyncImageInputRequest? image = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}