
#nullable enable

namespace TwelveLabs
{
    public partial class SubpackageEmbedSubpackageEmbedV2Client
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::TwelveLabs.CreateEmbeddingsRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::TwelveLabs.CreateEmbeddingsRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create sync embeddings<br/>
        /// This endpoint synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// **When to use this endpoint**:<br/>
        /// - Create embeddings for text, images, audio, or video content<br/>
        /// - Retrieve immediate results without waiting for background processing<br/>
        /// - Process audio or video content up to 10 minutes in duration<br/>
        /// **Do not use this endpoint for**:<br/>
        /// - Audio or video content longer than 10 minutes. Use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Text**:<br/>
        ///   - Maximum length: 500 tokens<br/>
        ///   **Images**:<br/>
        ///   - Formats: JPEG, PNG<br/>
        ///   - Minimum size: 128x128 pixels<br/>
        ///   - Maximum file size: 5 MB<br/>
        ///   **Audio and video**:<br/>
        ///   - Maximum duration: 10 minutes<br/>
        ///   - Maximum file size for base64 encoded strings: 36 MB<br/>
        ///   - Audio formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        ///   - Video formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Video resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        /// &lt;/Accordion&gt;<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingSuccessResponse> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateEmbeddingsRequest request,
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
                path: "/embed-v2",
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
            // Client exceeded rate limits
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::TwelveLabs.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::TwelveLabs.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::TwelveLabs.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::TwelveLabs.ApiException<global::TwelveLabs.ErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unhandled edge or corner case
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
                        global::TwelveLabs.EmbeddingSuccessResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::TwelveLabs.EmbeddingSuccessResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create sync embeddings<br/>
        /// This endpoint synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// **When to use this endpoint**:<br/>
        /// - Create embeddings for text, images, audio, or video content<br/>
        /// - Retrieve immediate results without waiting for background processing<br/>
        /// - Process audio or video content up to 10 minutes in duration<br/>
        /// **Do not use this endpoint for**:<br/>
        /// - Audio or video content longer than 10 minutes. Use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Text**:<br/>
        ///   - Maximum length: 500 tokens<br/>
        ///   **Images**:<br/>
        ///   - Formats: JPEG, PNG<br/>
        ///   - Minimum size: 128x128 pixels<br/>
        ///   - Maximum file size: 5 MB<br/>
        ///   **Audio and video**:<br/>
        ///   - Maximum duration: 10 minutes<br/>
        ///   - Maximum file size for base64 encoded strings: 36 MB<br/>
        ///   - Audio formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        ///   - Video formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Video resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        /// &lt;/Accordion&gt;<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Creates embeddings for an audio file<br/>
        /// - `video`: Creates embeddings for a video file<br/>
        /// - `image`: Creates embeddings for an image file<br/>
        /// - `text`: Creates embeddings for text input<br/>
        /// - `text_image`: Creates embeddings for text and an image<br/>
        /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to use. Value: "marengo3.0".<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the  `input_type` parameter is `image`.
        /// </param>
        /// <param name="textImage">
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="multiInput">
        /// This field is required if the `input_type` parameter is `multi_input`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.EmbeddingSuccessResponse> CreateAsync(
            string xApiKey,
            global::TwelveLabs.CreateEmbeddingsRequestInputType inputType,
            global::TwelveLabs.CreateEmbeddingsRequestModelName modelName = global::TwelveLabs.CreateEmbeddingsRequestModelName.Marengo30,
            global::TwelveLabs.TextInputRequest? text = default,
            global::TwelveLabs.ImageInputRequest? image = default,
            global::TwelveLabs.TextImageInputRequest? textImage = default,
            global::TwelveLabs.AudioInputRequest? audio = default,
            global::TwelveLabs.VideoInputRequest? video = default,
            global::TwelveLabs.MultiInputRequest? multiInput = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::TwelveLabs.CreateEmbeddingsRequest
            {
                InputType = inputType,
                ModelName = modelName,
                Text = text,
                Image = image,
                TextImage = textImage,
                Audio = audio,
                Video = video,
                MultiInput = multiInput,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}