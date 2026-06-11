
#nullable enable

namespace TwelveLabs
{
    public partial class TwelveLabsClient
    {


        private static readonly global::TwelveLabs.EndPointSecurityRequirement s_AnalyzeSecurityRequirement0 =
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
        private static readonly global::TwelveLabs.EndPointSecurityRequirement[] s_AnalyzeSecurityRequirements =
            new global::TwelveLabs.EndPointSecurityRequirement[]
            {                s_AnalyzeSecurityRequirement0,
            };
        partial void PrepareAnalyzeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::TwelveLabs.AnalyzeRequest request);
        partial void PrepareAnalyzeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::TwelveLabs.AnalyzeRequest request);
        partial void ProcessAnalyzeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAnalyzeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Sync analysis<br/>
        /// This method analyzes your videos and returns the results directly in the response. It generates text based on your prompts and supports both Pegasus 1.2 and Pegasus 1.5 for general analysis (prompt-based text generation).<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without polling for task completion<br/>
        /// - Stream text fragments in real time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// - Video segmentation with custom segment definitions. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint with the `model_name` parameter set to `pegasus1.5` instead.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeResponse200> AnalyzeAsync(
            string xApiKey,

            global::TwelveLabs.AnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AnalyzeAsResponseAsync(
                xApiKey: xApiKey,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Sync analysis<br/>
        /// This method analyzes your videos and returns the results directly in the response. It generates text based on your prompts and supports both Pegasus 1.2 and Pegasus 1.5 for general analysis (prompt-based text generation).<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without polling for task completion<br/>
        /// - Stream text fragments in real time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// - Video segmentation with custom segment definitions. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint with the `model_name` parameter set to `pegasus1.5` instead.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeResponse200>> AnalyzeAsResponseAsync(
            string xApiKey,

            global::TwelveLabs.AnalyzeRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAnalyzeArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);


            var __authorizations = global::TwelveLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AnalyzeSecurityRequirements,
                operationName: "AnalyzeAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::TwelveLabs.PathBuilder(
                                path: "/analyze",
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
                PrepareAnalyzeRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xApiKey: xApiKey!,
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
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/analyze\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::TwelveLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/analyze\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::TwelveLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::TwelveLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/analyze\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::TwelveLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessAnalyzeResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/analyze\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Analyze",
                                methodName: "AnalyzeAsync",
                                pathTemplate: "\"/analyze\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // The request has failed.
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<global::TwelveLabs.GenerateTextRepresentationRequestBadRequestError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The specified resource does not exist.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<global::TwelveLabs.GenerateTextRepresentationRequestNotFoundError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // If the rate limit is reached, the platform returns an `HTTP 429 - Too many requests` error response. The response body is empty. 
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                string? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_429, typeof(string), JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_429, typeof(string), JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<string>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessAnalyzeResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::TwelveLabs.AnalyzeResponse200.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeResponse200>(
                                        statusCode: __response.StatusCode,
                                        headers: global::TwelveLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::TwelveLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::TwelveLabs.AnalyzeResponse200.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.AnalyzeResponse200>(
                                        statusCode: __response.StatusCode,
                                        headers: global::TwelveLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::TwelveLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Sync analysis<br/>
        /// This method analyzes your videos and returns the results directly in the response. It generates text based on your prompts and supports both Pegasus 1.2 and Pegasus 1.5 for general analysis (prompt-based text generation).<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        /// - Minimum duration: 4 seconds<br/>
        /// - Maximum duration: 1 hour<br/>
        /// - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        /// - Resolution: 360x360 to 5184x2160 pixels<br/>
        /// - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1.<br/>
        /// &lt;/Accordion&gt;<br/>
        /// **When to use this method**:<br/>
        /// - Analyze videos up to 1 hour<br/>
        /// - Retrieve immediate results without polling for task completion<br/>
        /// - Stream text fragments in real time for immediate processing and feedback<br/>
        /// **Do not use this method for**:<br/>
        /// - Videos longer than 1 hour. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint instead.<br/>
        /// - Video segmentation with custom segment definitions. Use the [`POST`](/v1.3/api-reference/analyze-videos/create-async-analysis-task) method of the `/analyze/tasks` endpoint with the `model_name` parameter set to `pegasus1.5` instead.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="modelName">
        /// The video understanding model to use for analysis.<br/>
        /// - `pegasus1.2`: General analysis (prompt-based text generation).<br/>
        /// - `pegasus1.5`: General analysis (prompt-based text generation) with video clipping, structured prompts with reference images, and video segmentation (async only). See the [Pegasus](/v1.3/docs/concepts/models/pegasus#context-window) page for token limits.<br/>
        /// **Default:** `pegasus1.2`<br/>
        /// Default Value: pegasus1.2
        /// </param>
        /// <param name="videoId">
        /// The unique identifier of the video to analyze. Use this parameter when the `model_name` parameter is `pegasus1.2`. Not supported with `pegasus1.5`.<br/>
        /// &lt;Info&gt; This parameter will be deprecated and removed in a future version. Use the [`video`](/v1.3/api-reference/analyze-videos/sync-analysis#request.body.video) parameter instead.&lt;/Info&gt;
        /// </param>
        /// <param name="video">
        /// An object specifying the source of the video content. Include exactly one source.
        /// </param>
        /// <param name="prompt">
        /// A text prompt that guides the model on the desired format or content. Works with both Pegasus 1.2 and Pegasus 1.5. To include reference images in your prompt, use the `prompt_v2` parameter instead (Pegasus 1.5 only). Mutually exclusive with the `prompt_v2` parameter.<br/>
        /// Your prompts can be instructive or descriptive, or you can phrase them as questions. Pegasus 1.2 limits prompts to 2,000 tokens. For Pegasus 1.5, this text counts toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </param>
        /// <param name="promptV2">
        /// A structured prompt with `&lt;@name&gt;` placeholders for referencing images. Requires the `model_name` parameter set to `pegasus1.5`. Mutually exclusive with the `prompt` parameter.<br/>
        /// The prompt text and reference images count toward the [context window](/v1.3/docs/concepts/models/pegasus#context-window).
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the text output.<br/>
        /// **Default:** 0.2 **Min:** 0 **Max:** 1
        /// </param>
        /// <param name="stream">
        /// Set this parameter to `true` to enable streaming responses in the &lt;a href="https://github.com/ndjson/ndjson-spec" target="_blank"&gt;NDJSON&lt;/a&gt; format.<br/>
        /// **Default:** `true`<br/>
        /// Default Value: true
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format of the response. When you omit this parameter, the platform returns unstructured text. Only the `json_schema` type is supported for synchronous analysis.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum response length, in tokens. The allowed range depends on the model:<br/>
        /// | Model | Min | Max | Default |<br/>
        /// |-------|-----|-----|---------|<br/>
        /// | Pegasus 1.2 | 2 | 4,096 | 4,096 |<br/>
        /// | Pegasus 1.5 | 512 | 98,304 | 4,096 |
        /// </param>
        /// <param name="startTime">
        /// Start of the analysis window, as an absolute timestamp in seconds, based on the video's internal metadata. Use with `end_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video's internal start time.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be less than `end_time` and less than the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="endTime">
        /// End of the analysis window, as an absolute timestamp in seconds, based on the video's internal metadata. Use with `start_time` to analyze only a portion of the video. Requires `model_name` set to `pegasus1.5`.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - If omitted, defaults to the video's internal start time plus its duration.<br/>
        /// - Most videos start at 0, but some (for example, from cameras or broadcast recordings) may have a non-zero start time. To find the value, run `ffprobe -v error -show_entries format=start_time,duration -of default=noprint_wrappers=1 your_video.mp4`.<br/>
        /// - Must be greater than `start_time` and less than or equal to the video duration. The clip (`end_time - start_time`) must be at least `4` seconds.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.AnalyzeResponse200> AnalyzeAsync(
            string xApiKey,
            global::TwelveLabs.AnalyzePostRequestBodyContentApplicationJsonSchemaModelName? modelName = default,
            string? videoId = default,
            global::TwelveLabs.VideoContext? video = default,
            string? prompt = default,
            global::TwelveLabs.AnalyzePromptV2? promptV2 = default,
            double? temperature = default,
            bool? stream = default,
            global::TwelveLabs.SyncResponseFormat? responseFormat = default,
            int? maxTokens = default,
            double? startTime = default,
            double? endTime = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::TwelveLabs.AnalyzeRequest
            {
                ModelName = modelName,
                VideoId = videoId,
                Video = video,
                Prompt = prompt,
                PromptV2 = promptV2,
                Temperature = temperature,
                Stream = stream,
                ResponseFormat = responseFormat,
                MaxTokens = maxTokens,
                StartTime = startTime,
                EndTime = endTime,
            };

            return await AnalyzeAsync(
                xApiKey: xApiKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}