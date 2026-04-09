
#nullable enable

namespace TwelveLabs
{
    public partial class SubpackageIndexesSubpackageIndexesVideosClient
    {


        private static readonly global::TwelveLabs.EndPointSecurityRequirement s_ListSecurityRequirement0 =
            new global::TwelveLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::TwelveLabs.EndPointAuthorizationRequirement[]
                {                    new global::TwelveLabs.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::TwelveLabs.EndPointSecurityRequirement[] s_ListSecurityRequirements =
            new global::TwelveLabs.EndPointSecurityRequirement[]
            {                s_ListSecurityRequirement0,
            };
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string indexId,
            ref int? page,
            ref int? pageLimit,
            ref string? sortBy,
            ref string? sortOption,
            ref string? filename,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? duration,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? fps,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? width,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? height,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? size,
            ref string? createdAt,
            ref string? updatedAt,
            object? userMetadata,
            ref string xApiKey);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string indexId,
            int? page,
            int? pageLimit,
            string? sortBy,
            string? sortOption,
            string? filename,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? duration,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? fps,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? width,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? height,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? size,
            string? createdAt,
            string? updatedAt,
            object? userMetadata,
            string xApiKey);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List videos<br/>
        /// &lt;Info&gt;This method will be deprecated in a future version. New implementations should use the [List indexed assets](/v1.3/api-reference/index-content/list) method.&lt;/Info&gt;<br/>
        /// This method returns a list of the videos in the specified index. By default, the platform returns your videos sorted by creation date, with the newest at the top of the list.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOption">
        /// Default Value: desc
        /// </param>
        /// <param name="filename"></param>
        /// <param name="duration"></param>
        /// <param name="fps"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="size"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userMetadata"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::TwelveLabs.IndexesVideosListResponse200> ListAsync(
            string indexId,
            string xApiKey,
            int? page = default,
            int? pageLimit = default,
            string? sortBy = default,
            string? sortOption = default,
            string? filename = default,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersDuration? duration = default,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersFps? fps = default,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersWidth? width = default,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersHeight? height = default,
            global::TwelveLabs.IndexesIndexIdVideosGetParametersSize? size = default,
            string? createdAt = default,
            string? updatedAt = default,
            object? userMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                indexId: ref indexId,
                page: ref page,
                pageLimit: ref pageLimit,
                sortBy: ref sortBy,
                sortOption: ref sortOption,
                filename: ref filename,
                duration: duration,
                fps: fps,
                width: width,
                height: height,
                size: size,
                createdAt: ref createdAt,
                updatedAt: ref updatedAt,
                userMetadata: userMetadata,
                xApiKey: ref xApiKey);


            var __authorizations = global::TwelveLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListSecurityRequirements,
                operationName: "ListAsync");

            var __pathBuilder = new global::TwelveLabs.PathBuilder(
                path: $"/indexes/{indexId}/videos",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_limit", pageLimit?.ToString())
                .AddOptionalParameter("sort_by", sortBy)
                .AddOptionalParameter("sort_option", sortOption)
                .AddOptionalParameter("filename", filename)
                .AddOptionalParameter("created_at", createdAt)
                .AddOptionalParameter("updated_at", updatedAt)
                .AddOptionalParameter("user_metadata", userMetadata?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                indexId: indexId,
                page: page,
                pageLimit: pageLimit,
                sortBy: sortBy,
                sortOption: sortOption,
                filename: filename,
                duration: duration,
                fps: fps,
                width: width,
                height: height,
                size: size,
                createdAt: createdAt,
                updatedAt: updatedAt,
                userMetadata: userMetadata,
                xApiKey: xApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::TwelveLabs.ListVideosRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::TwelveLabs.ListVideosRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::TwelveLabs.ListVideosRequestBadRequestError.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::TwelveLabs.ApiException<global::TwelveLabs.ListVideosRequestBadRequestError>(
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
                ProcessListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::TwelveLabs.IndexesVideosListResponse200.FromJson(__content, JsonSerializerContext) ??
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
                        await global::TwelveLabs.IndexesVideosListResponse200.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}