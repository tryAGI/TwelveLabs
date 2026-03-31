
#nullable enable

namespace TwelveLabs
{
    public partial class SubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::TwelveLabs.CreateAsyncEmbeddingRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::TwelveLabs.CreateAsyncEmbeddingRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an async embedding task<br/>
        /// This endpoint creates embeddings for audio and video content asynchronously.<br/>
        /// **When to use this endpoint**:<br/>
        /// - Process audio or video files longer than 10 minutes<br/>
        /// - Process files up to 4 hours in duration<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Video**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 4 GB<br/>
        ///   - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        ///   **Audio**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 2 GB<br/>
        ///   - Formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        /// &lt;/Accordion&gt;<br/>
        ///   Creating embeddings asynchronously requires three steps:<br/>
        ///   1. Create a task using this endpoint. The platform returns a task ID.<br/>
        ///   2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        ///   3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        ///   &lt;Note title="Note"&gt;<br/>
        ///   This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        ///   &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.EmbedV2TasksCreateResponse202> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateAsyncEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);

            var __pathBuilder = new global::TwelveLabs.PathBuilder(
                path: "/embed-v2/tasks",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xApiKey: xApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation failure or inaccessible artifact
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::TwelveLabs.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::TwelveLabs.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::TwelveLabs.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::TwelveLabs.ApiException<global::TwelveLabs.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::TwelveLabs.ErrorResponse? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::TwelveLabs.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::TwelveLabs.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::TwelveLabs.ApiException<global::TwelveLabs.ErrorResponse>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::TwelveLabs.EmbedV2TasksCreateResponse202.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::TwelveLabs.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::TwelveLabs.EmbedV2TasksCreateResponse202.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::TwelveLabs.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create an async embedding task<br/>
        /// This endpoint creates embeddings for audio and video content asynchronously.<br/>
        /// **When to use this endpoint**:<br/>
        /// - Process audio or video files longer than 10 minutes<br/>
        /// - Process files up to 4 hours in duration<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Video**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 4 GB<br/>
        ///   - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        ///   **Audio**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 2 GB<br/>
        ///   - Formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        /// &lt;/Accordion&gt;<br/>
        ///   Creating embeddings asynchronously requires three steps:<br/>
        ///   1. Create a task using this endpoint. The platform returns a task ID.<br/>
        ///   2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        ///   3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        ///   &lt;Note title="Note"&gt;<br/>
        ///   This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        ///   &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Audio files<br/>
        /// - `video`: Video content
        /// </param>
        /// <param name="modelName">
        /// The model you wish to use. Value: `"marengo3.0"`.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.EmbedV2TasksCreateResponse202> CreateAsync(
            string xApiKey,
            global::TwelveLabs.CreateAsyncEmbeddingRequestInputType inputType,
            global::TwelveLabs.CreateAsyncEmbeddingRequestModelName modelName = global::TwelveLabs.CreateAsyncEmbeddingRequestModelName.Marengo30,
            global::TwelveLabs.AudioInputRequest? audio = default,
            global::TwelveLabs.VideoInputRequest? video = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::TwelveLabs.CreateAsyncEmbeddingRequest
            {
                InputType = inputType,
                ModelName = modelName,
                Audio = audio,
                Video = video,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}