
#nullable enable

namespace TwelveLabs
{
    public partial class KnowledgeStoresClient
    {


        private static readonly global::TwelveLabs.EndPointSecurityRequirement s_SearchSecurityRequirement0 =
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
        private static readonly global::TwelveLabs.EndPointSecurityRequirement[] s_SearchSecurityRequirements =
            new global::TwelveLabs.EndPointSecurityRequirement[]
            {                s_SearchSecurityRequirement0,
            };
        partial void PrepareSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string knowledgeStoreId,
            global::TwelveLabs.SearchKnowledgeStoreRequest request);
        partial void PrepareSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string knowledgeStoreId,
            global::TwelveLabs.SearchKnowledgeStoreRequest request);
        partial void ProcessSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Use the `query.text` field to specify your natural-language query. Use the `filter` parameter to choose which items to search. Use the `search_options` parameter to choose how the platform matches videos.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.SearchKnowledgeStoreResponse> SearchAsync(
            string knowledgeStoreId,

            global::TwelveLabs.SearchKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SearchAsResponseAsync(
                knowledgeStoreId: knowledgeStoreId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Use the `query.text` field to specify your natural-language query. Use the `filter` parameter to choose which items to search. Use the `search_options` parameter to choose how the platform matches videos.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.SearchKnowledgeStoreResponse>> SearchAsResponseAsync(
            string knowledgeStoreId,

            global::TwelveLabs.SearchKnowledgeStoreRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSearchArguments(
                httpClient: HttpClient,
                knowledgeStoreId: ref knowledgeStoreId,
                request: request);


            var __authorizations = global::TwelveLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SearchSecurityRequirements,
                operationName: "SearchAsync");

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
                                path: $"/knowledge-stores/{knowledgeStoreId}/search",
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
                PrepareSearchRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    knowledgeStoreId: knowledgeStoreId,
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
                                operationId: "Search",
                                methodName: "SearchAsync",
                                pathTemplate: "$\"/knowledge-stores/{knowledgeStoreId}/search\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Search",
                                methodName: "SearchAsync",
                                pathTemplate: "$\"/knowledge-stores/{knowledgeStoreId}/search\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Search",
                                methodName: "SearchAsync",
                                pathTemplate: "$\"/knowledge-stores/{knowledgeStoreId}/search\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessSearchResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Search",
                                methodName: "SearchAsync",
                                pathTemplate: "$\"/knowledge-stores/{knowledgeStoreId}/search\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Search",
                                methodName: "SearchAsync",
                                pathTemplate: "$\"/knowledge-stores/{knowledgeStoreId}/search\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<global::TwelveLabs.SearchKnowledgeStoreRequestBadRequestError>.Create(
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
                            // The knowledge store does not exist, or the `filter.item_collection_id` field specifies an item collection that is not in the knowledge store.
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<global::TwelveLabs.SearchKnowledgeStoreRequestNotFoundError>.Create(
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
                            // The page token has expired. Page tokens are valid for a limited time; make a new search request to obtain a fresh first page and a new token.
                            if ((int)__response.StatusCode == 410)
                            {
                                string? __content_410 = null;
                                global::System.Exception? __exception_410 = null;
                                global::TwelveLabs.SearchKnowledgeStoreRequestGoneError? __value_410 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_410 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_410 = global::TwelveLabs.SearchKnowledgeStoreRequestGoneError.FromJson(__content_410, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_410 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_410 = global::TwelveLabs.SearchKnowledgeStoreRequestGoneError.FromJson(__content_410, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_410 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<global::TwelveLabs.SearchKnowledgeStoreRequestGoneError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_410 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_410,
                                    responseBody: __content_410,
                                    responseObject: __value_410,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // The filter matches more than 10,000 items, or the `tags` field matches more than 100 tags. Narrow the filter and try again.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::TwelveLabs.ApiException<global::TwelveLabs.SearchKnowledgeStoreRequestUnprocessableEntityError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // If the rate limit is reached, the platform returns an `HTTP 429 - Too Many Requests` error response. The response body is empty.
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
                                ProcessSearchResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::TwelveLabs.SearchKnowledgeStoreResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.SearchKnowledgeStoreResponse>(
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

                                    var __value = await global::TwelveLabs.SearchKnowledgeStoreResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::TwelveLabs.AutoSDKHttpResponse<global::TwelveLabs.SearchKnowledgeStoreResponse>(
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
        /// Search a knowledge store<br/>
        /// This method searches a knowledge store using natural language and returns matching video clips and images ranked by relevance.<br/>
        /// Use the `query.text` field to specify your natural-language query. Use the `filter` parameter to choose which items to search. Use the `search_options` parameter to choose how the platform matches videos.<br/>
        /// By default, each result is an individual match: a video clip or an image. Set the `group_by` parameter to `item` to group clips under their parent item.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="knowledgeStoreId"></param>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="filter">
        /// Narrows results to specific items in the knowledge store. Omit the filter to search all items.<br/>
        /// You can filter with these fields:<br/>
        /// - `asset_type`: The type of item. Use `eq` to match one type. Use `in` to match any type in a list.<br/>
        /// - `item_id`: Specific items. Use `eq` to match one item or `in` to match any item in a list. Use `nin` to exclude any item in a list. You cannot use `eq` and `in` together. You can use `nin` on its own or with either `eq` or `in`. If an item is listed in `nin` and selected by `eq` or `in`, the platform excludes it.<br/>
        /// - `item_collection_id`: Specific item collections. Use `eq` to match the items in one item collection. Use `in` with a list of item collections to match the items in any of them. If an item collection is not in the knowledge store, the platform returns a `404` error with the `resource_not_exists` code. If the identifier of an item collection is not valid, the platform returns a `400` error with the `parameter_invalid` code.<br/>
        /// - `user_metadata`: Custom metadata. Map each key to `eq`, `in`, or inclusive numeric or date bounds with `gte` and `lte`.<br/>
        /// - `enrichment`: Enrichment values that the platform extracts. Map each key to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
        /// - `created_at`: Creation time. Use `gte` to set the earliest time and `lte` to set the latest time. You can use one or both.<br/>
        /// - `location`: Capture location. Provide the center and the radius of a circle.<br/>
        /// - `tags`: Item tags. Map each key under `tags.metadata` to the `eq` operator to match one value, or to the `in` operator to match any value in a list.<br/>
        /// An item must match all of the fields and metadata keys that you specify. The `tags` field also limits which clips of an item the search returns.<br/>
        /// When you use any of the `item_collection_id`, `user_metadata`, `enrichment`, `created_at`, or `location` fields, the platform counts the items that match those conditions together, including metadata ranges and the items that you include or exclude with the `item_id` field. If more than 10,000 items match, the platform returns a `422` error with the `metadata_filter_too_broad` code. To reduce the count, add conditions or use the `item_id` field. The `asset_type` field does not reduce the count. When you use the `tags` field, the platform does not count items, and this limit does not apply. It counts the matching tags instead, as the `tags` field describes.<br/>
        /// Examples:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "asset_type": {<br/>
        ///         "eq": "video"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "asset_type": {<br/>
        ///         "in": [<br/>
        ///             "video"<br/>
        ///         ]<br/>
        ///     },<br/>
        ///     "item_id": {<br/>
        ///         "in": [<br/>
        ///             "ksi_069e9870-3c4d-7abc-9012-3456789abcde"<br/>
        ///         ]<br/>
        ///     }<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "user_metadata": {<br/>
        ///         "category": {<br/>
        ///             "eq": "tutorial"<br/>
        ///         }<br/>
        ///     },<br/>
        ///     "created_at": {<br/>
        ///         "gte": "2026-09-01T00:00:00Z"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "location": {<br/>
        ///         "latitude": 37.5665,<br/>
        ///         "longitude": 126.978,<br/>
        ///         "radius_meters": 5000<br/>
        ///     }<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "tags": {<br/>
        ///         "metadata": {<br/>
        ///             "event": {<br/>
        ///                 "eq": "goal"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="searchOptions">
        /// Specifies how videos are matched. Videos are the only type of item with configurable options, set in the `search_options.video` field. Images are always matched on their visual content and have no options to configure.<br/>
        /// To choose which types of items to search, use the `filter.asset_type` field. If you provide options in the `search_options.video` field when the `filter.asset_type` field excludes videos, the platform returns a `400` error.<br/>
        /// If you omit this field, videos are matched on their visual content.
        /// </param>
        /// <param name="groupBy">
        /// Controls how the platform groups matches in the response.<br/>
        /// - `none`: Returns individual matches ordered by relevance.<br/>
        /// - `item`: Groups matches under their parent item.<br/>
        /// **Default**: `none`.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="pageSize">
        /// The maximum number of results per page. A result is one entry in the `data` array. With the `group_by` parameter set to its default of `none`, each result is an individual match: a video clip or an image. When set to `item`, each result is one item: a video with all its matching clips, or an image.<br/>
        /// **Default**: `10`. **Max**: `50`.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="pageToken">
        /// Pagination token used to retrieve the next page of results. Omit it on the first request. To fetch the next page, set it to the `next_page_token` field returned in the previous response and send the request again.<br/>
        /// If a token is malformed or unrecognized, the platform returns a `400` error. If a token has expired, the platform returns a `410` error (make a new search request to obtain a fresh page token).
        /// </param>
        /// <param name="includeMetadata">
        /// Set to `true` to include metadata in each result. Each result includes a `metadata` object with these fields:<br/>
        /// - `system`: System-generated metadata, such as duration and resolution.<br/>
        /// - `user`: The custom metadata of the source asset.<br/>
        /// - `item`: The custom metadata of the knowledge store item.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.SearchKnowledgeStoreResponse> SearchAsync(
            string knowledgeStoreId,
            global::TwelveLabs.KnowledgeStoreSearchQuery query,
            global::TwelveLabs.SearchKnowledgeStoreFilter? filter = default,
            global::TwelveLabs.SearchKnowledgeStoreOptions? searchOptions = default,
            global::TwelveLabs.SearchKnowledgeStoreRequestGroupBy? groupBy = default,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeMetadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::TwelveLabs.SearchKnowledgeStoreRequest
            {
                Query = query,
                Filter = filter,
                SearchOptions = searchOptions,
                GroupBy = groupBy,
                PageSize = pageSize,
                PageToken = pageToken,
                IncludeMetadata = includeMetadata,
            };

            return await SearchAsync(
                knowledgeStoreId: knowledgeStoreId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}