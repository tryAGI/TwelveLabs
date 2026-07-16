
#nullable enable

namespace TwelveLabs
{
    public partial class ResponsesClient
    {


        private static readonly global::TwelveLabs.EndPointSecurityRequirement s_CreateStreamSecurityRequirement0 =
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
        private static readonly global::TwelveLabs.EndPointSecurityRequirement[] s_CreateStreamSecurityRequirements =
            new global::TwelveLabs.EndPointSecurityRequirement[]
            {                s_CreateStreamSecurityRequirement0,
            };
        partial void PrepareCreateStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::TwelveLabs.CreateStreamRequest request);
        partial void PrepareCreateStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::TwelveLabs.CreateStreamRequest request);
        partial void ProcessCreateStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create a response<br/>
        /// This method uses [Jockey](/v1.3/agents/concepts/jockey) to reason over content in a knowledge store and create a response. It uses [Open Responses](https://www.openresponses.org/specification) conventions for input items and streaming events.<br/>
        /// Before you use this method, you must create an asset, create a knowledge store, and add the asset to the knowledge store as an item.<br/>
        /// **Multi-turn conversations**: Supported via a session identifier. The first request implicitly creates a session; subsequent requests pass the returned identifier to continue the conversation.<br/>
        /// **Selections**: By default, Jockey reasons over every item in the knowledge store. To narrow the scope, set the optional `selections` parameter to specific items or item collections, then reference each one with a `{{sel:N}}` token in the `content` field of an `input` item (`N` is the zero-based position in the `selections` array). The narrowing is applied at the prompt level; the knowledge store does not block access to other items.<br/>
        /// **Streaming**: Set the `stream` parameter to `true` to receive the response as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE). The reply streams in as a sequence of typed events and ends with a `data: [DONE]` message.<br/>
        /// &lt;Accordion title="Example response"&gt;<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "resp_019f4f2a-b69e-7812-b20f-6ea6d644ceff",<br/>
        ///   "type": "response",<br/>
        ///   "status": "completed",<br/>
        ///   "session_id": "sess_019f4f2a-b69b-7a01-9018-cc51681121ea",<br/>
        ///   "knowledge_store_id": "ks_019ebcf4-7e08-7201-b69c-69e0c1e6ae56",<br/>
        ///   "output": [<br/>
        ///     {<br/>
        ///       "type": "message",<br/>
        ///       "id": "msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0",<br/>
        ///       "status": "completed",<br/>
        ///       "role": "assistant",<br/>
        ///       "content": [<br/>
        ///         {<br/>
        ///           "type": "output_text",<br/>
        ///           "text": "The video captures a heated sideline moment during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid, visibly frustrated, and briefly bumps him before being restrained by a teammate [00:00-00:09]."<br/>
        ///         }<br/>
        ///       ]<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "usage": {<br/>
        ///     "input_tokens": 12625,<br/>
        ///     "output_tokens": 289<br/>
        ///   },<br/>
        ///   "created_at": "2026-07-11T03:13:57Z"<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;/Accordion&gt;<br/>
        /// &lt;Accordion title="Example streamed response (SSE)"&gt;<br/>
        /// ```<br/>
        /// event: response.created<br/>
        /// data: {"type":"response.created","sequence_number":0,"response":{"id":"resp_019f4f2a-b69e-7812-b20f-6ea6d644ceff","type":"response","status":"in_progress","output":[],"session_id":"sess_019f4f2a-b69b-7a01-9018-cc51681121ea","knowledge_store_id":"ks_019ebcf4-7e08-7201-b69c-69e0c1e6ae56","created_at":"2026-07-11T03:13:47Z"}}<br/>
        /// event: response.output_item.added<br/>
        /// data: {"type":"response.output_item.added","sequence_number":2,"output_index":0,"item":{"type":"message","id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","status":"in_progress","role":"assistant","content":[{"type":"output_text","text":""}]}}<br/>
        /// event: response.output_text.delta<br/>
        /// data: {"type":"response.output_text.delta","sequence_number":4,"item_id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","output_index":0,"content_index":0,"delta":"The video captures a heated sideline moment"}<br/>
        /// event: response.output_text.delta<br/>
        /// data: {"type":"response.output_text.delta","sequence_number":5,"item_id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","output_index":0,"content_index":0,"delta":" during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid."}<br/>
        /// event: response.output_text.done<br/>
        /// data: {"type":"response.output_text.done","sequence_number":124,"item_id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","output_index":0,"content_index":0,"text":"The video captures a heated sideline moment during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid, visibly frustrated, and briefly bumps him before being restrained by a teammate [00:00-00:09]."}<br/>
        /// event: response.completed<br/>
        /// data: {"type":"response.completed","sequence_number":127,"response":{"id":"resp_019f4f2a-b69e-7812-b20f-6ea6d644ceff","type":"response","status":"completed","output":[{"type":"message","id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The video captures a heated sideline moment during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid, visibly frustrated, and briefly bumps him before being restrained by a teammate [00:00-00:09]."}]}],"usage":{"input_tokens":12625,"output_tokens":289},"session_id":"sess_019f4f2a-b69b-7a01-9018-cc51681121ea","knowledge_store_id":"ks_019ebcf4-7e08-7201-b69c-69e0c1e6ae56","created_at":"2026-07-11T03:13:57Z"}}<br/>
        /// data: [DONE]<br/>
        /// ```<br/>
        /// &lt;/Accordion&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::TwelveLabs.ResponseStreamEvent> CreateStreamAsync(
            string xApiKey,

            global::TwelveLabs.CreateStreamRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStreamArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);


            var __authorizations = global::TwelveLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateStreamSecurityRequirements,
                operationName: "CreateStreamAsync");

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
                                path: "/responses",
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
                PrepareCreateStreamRequest(
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
                                operationId: "CreateStream",
                                methodName: "CreateStreamAsync",
                                pathTemplate: "\"/responses\"",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
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
                                operationId: "CreateStream",
                                methodName: "CreateStreamAsync",
                                pathTemplate: "\"/responses\"",
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
                                operationId: "CreateStream",
                                methodName: "CreateStreamAsync",
                                pathTemplate: "\"/responses\"",
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
                ProcessCreateStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::TwelveLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::TwelveLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateStream",
                                methodName: "CreateStreamAsync",
                                pathTemplate: "\"/responses\"",
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
                                operationId: "CreateStream",
                                methodName: "CreateStreamAsync",
                                pathTemplate: "\"/responses\"",
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

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::TwelveLabs.ResponseStreamEvent.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::TwelveLabs.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Create a response<br/>
        /// This method uses [Jockey](/v1.3/agents/concepts/jockey) to reason over content in a knowledge store and create a response. It uses [Open Responses](https://www.openresponses.org/specification) conventions for input items and streaming events.<br/>
        /// Before you use this method, you must create an asset, create a knowledge store, and add the asset to the knowledge store as an item.<br/>
        /// **Multi-turn conversations**: Supported via a session identifier. The first request implicitly creates a session; subsequent requests pass the returned identifier to continue the conversation.<br/>
        /// **Selections**: By default, Jockey reasons over every item in the knowledge store. To narrow the scope, set the optional `selections` parameter to specific items or item collections, then reference each one with a `{{sel:N}}` token in the `content` field of an `input` item (`N` is the zero-based position in the `selections` array). The narrowing is applied at the prompt level; the knowledge store does not block access to other items.<br/>
        /// **Streaming**: Set the `stream` parameter to `true` to receive the response as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE). The reply streams in as a sequence of typed events and ends with a `data: [DONE]` message.<br/>
        /// &lt;Accordion title="Example response"&gt;<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "resp_019f4f2a-b69e-7812-b20f-6ea6d644ceff",<br/>
        ///   "type": "response",<br/>
        ///   "status": "completed",<br/>
        ///   "session_id": "sess_019f4f2a-b69b-7a01-9018-cc51681121ea",<br/>
        ///   "knowledge_store_id": "ks_019ebcf4-7e08-7201-b69c-69e0c1e6ae56",<br/>
        ///   "output": [<br/>
        ///     {<br/>
        ///       "type": "message",<br/>
        ///       "id": "msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0",<br/>
        ///       "status": "completed",<br/>
        ///       "role": "assistant",<br/>
        ///       "content": [<br/>
        ///         {<br/>
        ///           "type": "output_text",<br/>
        ///           "text": "The video captures a heated sideline moment during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid, visibly frustrated, and briefly bumps him before being restrained by a teammate [00:00-00:09]."<br/>
        ///         }<br/>
        ///       ]<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "usage": {<br/>
        ///     "input_tokens": 12625,<br/>
        ///     "output_tokens": 289<br/>
        ///   },<br/>
        ///   "created_at": "2026-07-11T03:13:57Z"<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;/Accordion&gt;<br/>
        /// &lt;Accordion title="Example streamed response (SSE)"&gt;<br/>
        /// ```<br/>
        /// event: response.created<br/>
        /// data: {"type":"response.created","sequence_number":0,"response":{"id":"resp_019f4f2a-b69e-7812-b20f-6ea6d644ceff","type":"response","status":"in_progress","output":[],"session_id":"sess_019f4f2a-b69b-7a01-9018-cc51681121ea","knowledge_store_id":"ks_019ebcf4-7e08-7201-b69c-69e0c1e6ae56","created_at":"2026-07-11T03:13:47Z"}}<br/>
        /// event: response.output_item.added<br/>
        /// data: {"type":"response.output_item.added","sequence_number":2,"output_index":0,"item":{"type":"message","id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","status":"in_progress","role":"assistant","content":[{"type":"output_text","text":""}]}}<br/>
        /// event: response.output_text.delta<br/>
        /// data: {"type":"response.output_text.delta","sequence_number":4,"item_id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","output_index":0,"content_index":0,"delta":"The video captures a heated sideline moment"}<br/>
        /// event: response.output_text.delta<br/>
        /// data: {"type":"response.output_text.delta","sequence_number":5,"item_id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","output_index":0,"content_index":0,"delta":" during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid."}<br/>
        /// event: response.output_text.done<br/>
        /// data: {"type":"response.output_text.done","sequence_number":124,"item_id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","output_index":0,"content_index":0,"text":"The video captures a heated sideline moment during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid, visibly frustrated, and briefly bumps him before being restrained by a teammate [00:00-00:09]."}<br/>
        /// event: response.completed<br/>
        /// data: {"type":"response.completed","sequence_number":127,"response":{"id":"resp_019f4f2a-b69e-7812-b20f-6ea6d644ceff","type":"response","status":"completed","output":[{"type":"message","id":"msg_sess_019f4f2a-b69b-7a01-9018-cc51681121ea_0","status":"completed","role":"assistant","content":[{"type":"output_text","text":"The video captures a heated sideline moment during Super Bowl LVIII: after a fumble, Travis Kelce approaches head coach Andy Reid, visibly frustrated, and briefly bumps him before being restrained by a teammate [00:00-00:09]."}]}],"usage":{"input_tokens":12625,"output_tokens":289},"session_id":"sess_019f4f2a-b69b-7a01-9018-cc51681121ea","knowledge_store_id":"ks_019ebcf4-7e08-7201-b69c-69e0c1e6ae56","created_at":"2026-07-11T03:13:57Z"}}<br/>
        /// data: [DONE]<br/>
        /// ```<br/>
        /// &lt;/Accordion&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="knowledgeStoreId">
        /// The unique identifier of the knowledge store to reason over.
        /// </param>
        /// <param name="input">
        /// Provides context to Jockey for this request. Uses [Open Responses input item](https://www.openresponses.org/reference#input-items) conventions.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for a multi-turn conversation. Pass the session identifier<br/>
        /// returned from a previous response to continue that conversation. Omit to start<br/>
        /// a new session.<br/>
        /// When provided, the `knowledge_store_id` field must match the knowledge store the session<br/>
        /// was originally created against, or the request returns `400`.
        /// </param>
        /// <param name="instructions">
        /// Additional guidance for Jockey, acting as a per-request system prompt.
        /// </param>
        /// <param name="include">
        /// Additional items to include in the response's `output` array. By default, the `output` array contains only Jockey's final reply.<br/>
        /// **Values**:<br/>
        /// - `intermediate_outputs`: Also includes the steps Jockey took to produce the reply.
        /// </param>
        /// <param name="stream">
        /// When `true`, the response is returned as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE).
        /// </param>
        /// <param name="selections">
        /// Restricts the request to specific knowledge store items or item collections. The restriction is applied at the prompt level; the knowledge store does not block access to other items. Treat it as a strong preference, not a hard access boundary. Omit to run against every item.<br/>
        /// Selections persist in the session context, and selections sent on later turns are added to that context. You can reference selections from earlier turns in natural language without repeating their `{{sel:N}}` tokens.
        /// </param>
        /// <param name="text">
        /// Controls the output text format for the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::TwelveLabs.ResponseStreamEvent> CreateStreamAsync(
            string xApiKey,
            string knowledgeStoreId,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem> input,
            bool stream,
            string? sessionId = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponsesPostRequestBodyContentApplicationJsonSchemaIncludeItems>? include = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseSelection>? selections = default,
            global::TwelveLabs.TextParam? text = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::TwelveLabs.CreateStreamRequest
            {
                KnowledgeStoreId = knowledgeStoreId,
                Input = input,
                SessionId = sessionId,
                Instructions = instructions,
                Include = include,
                Stream = stream,
                Selections = selections,
                Text = text,
            };

            var __enumerable = CreateStreamAsync(
                xApiKey: xApiKey,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}