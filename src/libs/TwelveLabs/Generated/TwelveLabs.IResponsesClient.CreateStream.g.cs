#nullable enable

namespace TwelveLabs
{
    public partial interface IResponsesClient
    {
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
        global::System.Collections.Generic.IAsyncEnumerable<global::TwelveLabs.ResponseStreamEvent> CreateStreamAsync(
            string xApiKey,

            global::TwelveLabs.CreateStreamRequest request,
            global::TwelveLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Collections.Generic.IAsyncEnumerable<global::TwelveLabs.ResponseStreamEvent> CreateStreamAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}