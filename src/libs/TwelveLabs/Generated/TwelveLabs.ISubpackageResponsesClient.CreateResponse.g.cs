#nullable enable

namespace TwelveLabs
{
    public partial interface ISubpackageResponsesClient
    {
        /// <summary>
        /// Create a response<br/>
        /// Creates a response using an AI model that can understand and reason about content<br/>
        /// within a knowledge store. This endpoint follows the [Open Responses](https://www.openresponses.org/specification) specification.<br/>
        /// **Prerequisites** — Before using this endpoint, you must:<br/>
        /// 1. [Upload an asset](/v1.3/api-reference/upload-assets/create-asset) using the `POST /assets` endpoint.<br/>
        /// 2. Create a knowledge store and add items to it.<br/>
        /// Multi-turn conversations are supported via `session_id`. The first request implicitly creates a session;<br/>
        /// subsequent requests pass the returned `session_id` to continue the conversation.<br/>
        /// Set `stream` to `true` to receive the response as Server-Sent Events (SSE).
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::TwelveLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ResponseObject> CreateResponseAsync(
            string xApiKey,

            global::TwelveLabs.ResponseCreateRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a response<br/>
        /// Creates a response using an AI model that can understand and reason about content<br/>
        /// within a knowledge store. This endpoint follows the [Open Responses](https://www.openresponses.org/specification) specification.<br/>
        /// **Prerequisites** — Before using this endpoint, you must:<br/>
        /// 1. [Upload an asset](/v1.3/api-reference/upload-assets/create-asset) using the `POST /assets` endpoint.<br/>
        /// 2. Create a knowledge store and add items to it.<br/>
        /// Multi-turn conversations are supported via `session_id`. The first request implicitly creates a session;<br/>
        /// subsequent requests pass the returned `session_id` to continue the conversation.<br/>
        /// Set `stream` to `true` to receive the response as Server-Sent Events (SSE).
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="model">
        /// The AI model to use for generating the response.
        /// </param>
        /// <param name="knowledgeStoreId">
        /// The unique identifier of the knowledge store this response reasons over.
        /// </param>
        /// <param name="input">
        /// An array of input items following the [Open Responses input items](https://www.openresponses.org/reference#input-items) specification.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier for a multi-turn conversation. Pass the `session_id`<br/>
        /// returned from a previous response to continue that conversation. Omit to start<br/>
        /// a new session.<br/>
        /// When provided, `knowledge_store_id` must match the knowledge store the session<br/>
        /// was originally created against, or the request returns `400`.
        /// </param>
        /// <param name="instructions">
        /// Additional guidance for the model, acting as a per-request system prompt.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in the response.
        /// </param>
        /// <param name="stream">
        /// When `true`, the response is returned as [Server-Sent Events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events) (SSE).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="text">
        /// Controls the output text format for the response.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs to attach to the request. Up to 16 pairs allowed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::TwelveLabs.ResponseObject> CreateResponseAsync(
            string xApiKey,
            string knowledgeStoreId,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseInputItem> input,
            global::TwelveLabs.ResponseCreateRequestModel model = default,
            string? sessionId = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::TwelveLabs.ResponseCreateRequestIncludeItems>? include = default,
            bool? stream = default,
            global::TwelveLabs.TextParam? text = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}