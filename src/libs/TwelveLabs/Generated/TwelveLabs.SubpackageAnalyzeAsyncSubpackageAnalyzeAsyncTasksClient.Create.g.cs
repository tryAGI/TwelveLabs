
#nullable enable

namespace TwelveLabs
{
    public partial class SubpackageAnalyzeAsyncSubpackageAnalyzeAsyncTasksClient
    {


        private static readonly global::TwelveLabs.EndPointSecurityRequirement s_CreateSecurityRequirement0 =
            new global::TwelveLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::TwelveLabs.EndPointAuthorizationRequirement[]
                {                    new global::TwelveLabs.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::TwelveLabs.EndPointSecurityRequirement[] s_CreateSecurityRequirements =
            new global::TwelveLabs.EndPointSecurityRequirement[]
            {                s_CreateSecurityRequirement0,
            };
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::TwelveLabs.CreateAsyncAnalyzeRequest request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::TwelveLabs.CreateAsyncAnalyzeRequest request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an async analysis task<br/>
        /// This method asynchronously analyzes your videos and generates fully customizable text based on your prompts.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 2 hours<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos longer than 1 hour<br/>
        /// - Process videos asynchronously without blocking your application<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos for which you need immediate results or real-time streaming. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// Analyzing videos asynchronously requires three steps:<br/>
        /// 1. Create an analysis task using this method. The platform returns a task ID.<br/>
        /// 2. Poll the status of the task using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        /// 3. Retrieve the results from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.CreateAnalyzeTaskResponse> CreateAsync(
            string xApiKey,

            global::TwelveLabs.CreateAsyncAnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);


            var __authorizations = global::TwelveLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSecurityRequirements,
                operationName: "CreateAsync");

            using var __timeoutCancellationTokenSource = global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::TwelveLabs.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::TwelveLabs.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::TwelveLabs.PathBuilder(
                                path: "/analyze/tasks",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::TwelveLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::TwelveLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xApiKey: xApiKey,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/analyze/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/analyze/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::TwelveLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/analyze/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/analyze/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/analyze/tasks\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation failure or inaccessible video
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::TwelveLabs.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::TwelveLabs.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::TwelveLabs.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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
                                        global::TwelveLabs.CreateAnalyzeTaskResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::TwelveLabs.CreateAnalyzeTaskResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create an async analysis task<br/>
        /// This method asynchronously analyzes your videos and generates fully customizable text based on your prompts.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 2 hours<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos longer than 1 hour<br/>
        /// - Process videos asynchronously without blocking your application<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos for which you need immediate results or real-time streaming. Use the [`POST`](/v1.3/api-reference/analyze-videos/sync-analysis) method of the `/analyze` endpoint instead.<br/>
        /// Analyzing videos asynchronously requires three steps:<br/>
        /// 1. Create an analysis task using this method. The platform returns a task ID.<br/>
        /// 2. Poll the status of the task using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        /// 3. Retrieve the results from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/analyze-videos/retrieve-analysis-task-status-results) method of the `/analyze/tasks/{task_id}` endpoint.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
        /// </param>
        /// <param name="prompt">
        /// A prompt that guides the model on the desired format or content.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Even though the model behind this endpoint is trained to a high degree of accuracy, the preciseness of the generated text may vary based on the nature and quality of the video and the clarity of the prompt.<br/>
        /// - Your prompts can be instructive or descriptive, or you can also phrase them as questions.<br/>
        /// - The maximum length of a prompt is 2,000 tokens.<br/>
        /// &lt;/Note&gt;<br/>
        /// **Examples**:<br/>
        /// - Based on this video, I want to generate five keywords for SEO (Search Engine Optimization).<br/>
        /// - I want to generate a description for my video with the following format: Title of the video, followed by a summary in 2-3 sentences, highlighting the main topic, key events, and concluding remarks.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.<br/>
        /// **Min**: 1 **Max:** 4096
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.CreateAnalyzeTaskResponse> CreateAsync(
            string xApiKey,
            global::TwelveLabs.VideoContext video,
            string prompt,
            double? temperature = default,
            int? maxTokens = default,
            global::TwelveLabs.ResponseFormat? responseFormat = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::TwelveLabs.CreateAsyncAnalyzeRequest
            {
                Video = video,
                Prompt = prompt,
                Temperature = temperature,
                MaxTokens = maxTokens,
                ResponseFormat = responseFormat,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}