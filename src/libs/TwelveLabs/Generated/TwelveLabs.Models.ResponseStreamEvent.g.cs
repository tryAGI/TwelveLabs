#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A Server-Sent Event emitted during a streaming response.<br/>
    /// Events use [Open Responses streaming](https://www.openresponses.org/specification#streaming) conventions.<br/>
    /// The stream consists of events with a `type` field indicating the event kind:<br/>
    /// - `response.created` — Initial event with the response object in `in_progress` state.<br/>
    /// - `response.in_progress` — The response is being generated.<br/>
    /// - `response.output_item.added` — A new output item has started.<br/>
    /// - `response.content_part.added` — A new content part has started within a message.<br/>
    /// - `response.output_text.delta` — An incremental text chunk.<br/>
    /// - `response.output_text.done` — Text streaming for a content part is complete.<br/>
    /// - `response.content_part.done` — A content part is finalized.<br/>
    /// - `response.function_call_arguments.done` — Function call arguments are complete.<br/>
    /// - `response.output_item.done` — An output item is finalized.<br/>
    /// - `response.completed` — The response is complete.<br/>
    /// - `response.failed` — The response has failed.<br/>
    /// - `keepalive` — Heartbeat sent periodically while no other events are being emitted (for example, during a long tool call). It contains no response data and can be ignored.<br/>
    /// The stream ends with a `data: [DONE]` message.<br/>
    /// Events are identified by `type` alone and have no `object` field, unlike the<br/>
    /// response object. Consumers must ignore frames whose `type` doesn't match one<br/>
    /// of the values above, to stay forward-compatible with new event types.
    /// </summary>
    public readonly partial struct ResponseStreamEvent : global::System.IEquatable<ResponseStreamEvent>
    {
        /// <summary>
        /// Wraps a response object. Emitted for `response.created`, `response.in_progress`,<br/>
        /// `response.completed`, and `response.failed` events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant1? ResponseStreamEventVariant1 { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant1? ResponseStreamEventVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseStreamEventVariant1))]
#endif
        public bool IsResponseStreamEventVariant1 => ResponseStreamEventVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseStreamEventVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant1? value)
        {
            value = ResponseStreamEventVariant1;
            return IsResponseStreamEventVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant1 PickResponseStreamEventVariant1() => ResponseStreamEventVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseStreamEventVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Wraps a response object. Emitted for `response.created`, `response.in_progress`,<br/>
        /// `response.completed`, and `response.failed` events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant2? ResponseStreamEventVariant2 { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant2? ResponseStreamEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseStreamEventVariant2))]
#endif
        public bool IsResponseStreamEventVariant2 => ResponseStreamEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseStreamEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant2? value)
        {
            value = ResponseStreamEventVariant2;
            return IsResponseStreamEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant2 PickResponseStreamEventVariant2() => ResponseStreamEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseStreamEventVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Wraps a response object. Emitted for `response.created`, `response.in_progress`,<br/>
        /// `response.completed`, and `response.failed` events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant3? ResponseStreamEventVariant3 { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant3? ResponseStreamEventVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseStreamEventVariant3))]
#endif
        public bool IsResponseStreamEventVariant3 => ResponseStreamEventVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseStreamEventVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant3? value)
        {
            value = ResponseStreamEventVariant3;
            return IsResponseStreamEventVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant3 PickResponseStreamEventVariant3() => ResponseStreamEventVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseStreamEventVariant3' but the value was {ToString()}.");

        /// <summary>
        /// Wraps a response object. Emitted for `response.created`, `response.in_progress`,<br/>
        /// `response.completed`, and `response.failed` events.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant4? ResponseStreamEventVariant4 { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant4? ResponseStreamEventVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseStreamEventVariant4))]
#endif
        public bool IsResponseStreamEventVariant4 => ResponseStreamEventVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseStreamEventVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant4? value)
        {
            value = ResponseStreamEventVariant4;
            return IsResponseStreamEventVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant4 PickResponseStreamEventVariant4() => ResponseStreamEventVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseStreamEventVariant4' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a new output item starts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant5? ResponseOutputItemAdded { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant5? ResponseOutputItemAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemAdded))]
#endif
        public bool IsResponseOutputItemAdded => ResponseOutputItemAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant5? value)
        {
            value = ResponseOutputItemAdded;
            return IsResponseOutputItemAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant5 PickResponseOutputItemAdded() => ResponseOutputItemAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a content part starts within a message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant6? ResponseContentPartAdded { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant6? ResponseContentPartAdded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartAdded))]
#endif
        public bool IsResponseContentPartAdded => ResponseContentPartAdded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartAdded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant6? value)
        {
            value = ResponseContentPartAdded;
            return IsResponseContentPartAdded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant6 PickResponseContentPartAdded() => ResponseContentPartAdded is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartAdded' but the value was {ToString()}.");

        /// <summary>
        /// Emitted for each incremental text chunk during streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant7? ResponseOutputTextDelta { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant7? ResponseOutputTextDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDelta))]
#endif
        public bool IsResponseOutputTextDelta => ResponseOutputTextDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant7? value)
        {
            value = ResponseOutputTextDelta;
            return IsResponseOutputTextDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant7 PickResponseOutputTextDelta() => ResponseOutputTextDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when text streaming for a content part completes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant8? ResponseOutputTextDone { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant8? ResponseOutputTextDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputTextDone))]
#endif
        public bool IsResponseOutputTextDone => ResponseOutputTextDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputTextDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant8? value)
        {
            value = ResponseOutputTextDone;
            return IsResponseOutputTextDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant8 PickResponseOutputTextDone() => ResponseOutputTextDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputTextDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when a content part is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant9? ResponseContentPartDone { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant9? ResponseContentPartDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseContentPartDone))]
#endif
        public bool IsResponseContentPartDone => ResponseContentPartDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseContentPartDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant9? value)
        {
            value = ResponseContentPartDone;
            return IsResponseContentPartDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant9 PickResponseContentPartDone() => ResponseContentPartDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseContentPartDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when an output item is finalized.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant10? ResponseOutputItemDone { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant10? ResponseOutputItemDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseOutputItemDone))]
#endif
        public bool IsResponseOutputItemDone => ResponseOutputItemDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseOutputItemDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant10? value)
        {
            value = ResponseOutputItemDone;
            return IsResponseOutputItemDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant10 PickResponseOutputItemDone() => ResponseOutputItemDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseOutputItemDone' but the value was {ToString()}.");

        /// <summary>
        /// Emitted when function call arguments are complete.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant11? ResponseFunctionCallArgumentsDone { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant11? ResponseFunctionCallArgumentsDone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseFunctionCallArgumentsDone))]
#endif
        public bool IsResponseFunctionCallArgumentsDone => ResponseFunctionCallArgumentsDone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseFunctionCallArgumentsDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant11? value)
        {
            value = ResponseFunctionCallArgumentsDone;
            return IsResponseFunctionCallArgumentsDone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant11 PickResponseFunctionCallArgumentsDone() => ResponseFunctionCallArgumentsDone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseFunctionCallArgumentsDone' but the value was {ToString()}.");

        /// <summary>
        /// A heartbeat frame the server sends about every 10 seconds when no other<br/>
        /// event has been emitted, for example while a tool call is still running.<br/>
        /// It carries no response data. Use it to keep the connection alive and to<br/>
        /// detect stalled streams; otherwise you can ignore it.<br/>
        /// `sequence_number` uses the same counter as all other event types. If you<br/>
        /// skip keepalive frames, the numbers you see will have gaps; these gaps do<br/>
        /// not mean events were dropped.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.ResponseStreamEventVariant12? Keepalive { get; init; }
#else
        public global::TwelveLabs.ResponseStreamEventVariant12? Keepalive { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Keepalive))]
#endif
        public bool IsKeepalive => Keepalive != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKeepalive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.ResponseStreamEventVariant12? value)
        {
            value = Keepalive;
            return IsKeepalive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::TwelveLabs.ResponseStreamEventVariant12 PickKeepalive() => Keepalive is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Keepalive' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant1 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant1?(ResponseStreamEvent @this) => @this.ResponseStreamEventVariant1;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant1? value)
        {
            ResponseStreamEventVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseStreamEventVariant1(global::TwelveLabs.ResponseStreamEventVariant1? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant2 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant2?(ResponseStreamEvent @this) => @this.ResponseStreamEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant2? value)
        {
            ResponseStreamEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseStreamEventVariant2(global::TwelveLabs.ResponseStreamEventVariant2? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant3 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant3?(ResponseStreamEvent @this) => @this.ResponseStreamEventVariant3;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant3? value)
        {
            ResponseStreamEventVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseStreamEventVariant3(global::TwelveLabs.ResponseStreamEventVariant3? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant4 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant4?(ResponseStreamEvent @this) => @this.ResponseStreamEventVariant4;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant4? value)
        {
            ResponseStreamEventVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseStreamEventVariant4(global::TwelveLabs.ResponseStreamEventVariant4? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant5 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant5?(ResponseStreamEvent @this) => @this.ResponseOutputItemAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant5? value)
        {
            ResponseOutputItemAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputItemAdded(global::TwelveLabs.ResponseStreamEventVariant5? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant6 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant6?(ResponseStreamEvent @this) => @this.ResponseContentPartAdded;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant6? value)
        {
            ResponseContentPartAdded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseContentPartAdded(global::TwelveLabs.ResponseStreamEventVariant6? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant7 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant7?(ResponseStreamEvent @this) => @this.ResponseOutputTextDelta;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant7? value)
        {
            ResponseOutputTextDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputTextDelta(global::TwelveLabs.ResponseStreamEventVariant7? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant8 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant8?(ResponseStreamEvent @this) => @this.ResponseOutputTextDone;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant8? value)
        {
            ResponseOutputTextDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputTextDone(global::TwelveLabs.ResponseStreamEventVariant8? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant9 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant9?(ResponseStreamEvent @this) => @this.ResponseContentPartDone;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant9? value)
        {
            ResponseContentPartDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseContentPartDone(global::TwelveLabs.ResponseStreamEventVariant9? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant10 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant10?(ResponseStreamEvent @this) => @this.ResponseOutputItemDone;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant10? value)
        {
            ResponseOutputItemDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseOutputItemDone(global::TwelveLabs.ResponseStreamEventVariant10? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant11 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant11?(ResponseStreamEvent @this) => @this.ResponseFunctionCallArgumentsDone;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant11? value)
        {
            ResponseFunctionCallArgumentsDone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromResponseFunctionCallArgumentsDone(global::TwelveLabs.ResponseStreamEventVariant11? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant12 value) => new ResponseStreamEvent((global::TwelveLabs.ResponseStreamEventVariant12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::TwelveLabs.ResponseStreamEventVariant12?(ResponseStreamEvent @this) => @this.Keepalive;

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(global::TwelveLabs.ResponseStreamEventVariant12? value)
        {
            Keepalive = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseStreamEvent FromKeepalive(global::TwelveLabs.ResponseStreamEventVariant12? value) => new ResponseStreamEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseStreamEvent(
            global::TwelveLabs.ResponseStreamEventVariant1? responseStreamEventVariant1,
            global::TwelveLabs.ResponseStreamEventVariant2? responseStreamEventVariant2,
            global::TwelveLabs.ResponseStreamEventVariant3? responseStreamEventVariant3,
            global::TwelveLabs.ResponseStreamEventVariant4? responseStreamEventVariant4,
            global::TwelveLabs.ResponseStreamEventVariant5? responseOutputItemAdded,
            global::TwelveLabs.ResponseStreamEventVariant6? responseContentPartAdded,
            global::TwelveLabs.ResponseStreamEventVariant7? responseOutputTextDelta,
            global::TwelveLabs.ResponseStreamEventVariant8? responseOutputTextDone,
            global::TwelveLabs.ResponseStreamEventVariant9? responseContentPartDone,
            global::TwelveLabs.ResponseStreamEventVariant10? responseOutputItemDone,
            global::TwelveLabs.ResponseStreamEventVariant11? responseFunctionCallArgumentsDone,
            global::TwelveLabs.ResponseStreamEventVariant12? keepalive
            )
        {
            ResponseStreamEventVariant1 = responseStreamEventVariant1;
            ResponseStreamEventVariant2 = responseStreamEventVariant2;
            ResponseStreamEventVariant3 = responseStreamEventVariant3;
            ResponseStreamEventVariant4 = responseStreamEventVariant4;
            ResponseOutputItemAdded = responseOutputItemAdded;
            ResponseContentPartAdded = responseContentPartAdded;
            ResponseOutputTextDelta = responseOutputTextDelta;
            ResponseOutputTextDone = responseOutputTextDone;
            ResponseContentPartDone = responseContentPartDone;
            ResponseOutputItemDone = responseOutputItemDone;
            ResponseFunctionCallArgumentsDone = responseFunctionCallArgumentsDone;
            Keepalive = keepalive;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Keepalive as object ??
            ResponseFunctionCallArgumentsDone as object ??
            ResponseOutputItemDone as object ??
            ResponseContentPartDone as object ??
            ResponseOutputTextDone as object ??
            ResponseOutputTextDelta as object ??
            ResponseContentPartAdded as object ??
            ResponseOutputItemAdded as object ??
            ResponseStreamEventVariant4 as object ??
            ResponseStreamEventVariant3 as object ??
            ResponseStreamEventVariant2 as object ??
            ResponseStreamEventVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseStreamEventVariant1?.ToString() ??
            ResponseStreamEventVariant2?.ToString() ??
            ResponseStreamEventVariant3?.ToString() ??
            ResponseStreamEventVariant4?.ToString() ??
            ResponseOutputItemAdded?.ToString() ??
            ResponseContentPartAdded?.ToString() ??
            ResponseOutputTextDelta?.ToString() ??
            ResponseOutputTextDone?.ToString() ??
            ResponseContentPartDone?.ToString() ??
            ResponseOutputItemDone?.ToString() ??
            ResponseFunctionCallArgumentsDone?.ToString() ??
            Keepalive?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && IsResponseFunctionCallArgumentsDone && !IsKeepalive || !IsResponseStreamEventVariant1 && !IsResponseStreamEventVariant2 && !IsResponseStreamEventVariant3 && !IsResponseStreamEventVariant4 && !IsResponseOutputItemAdded && !IsResponseContentPartAdded && !IsResponseOutputTextDelta && !IsResponseOutputTextDone && !IsResponseContentPartDone && !IsResponseOutputItemDone && !IsResponseFunctionCallArgumentsDone && IsKeepalive;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant1, TResult>? responseStreamEventVariant1 = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant2, TResult>? responseStreamEventVariant2 = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant3, TResult>? responseStreamEventVariant3 = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant4, TResult>? responseStreamEventVariant4 = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant5, TResult>? responseOutputItemAdded = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant6, TResult>? responseContentPartAdded = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant7, TResult>? responseOutputTextDelta = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant8, TResult>? responseOutputTextDone = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant9, TResult>? responseContentPartDone = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant10, TResult>? responseOutputItemDone = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant11, TResult>? responseFunctionCallArgumentsDone = null,
            global::System.Func<global::TwelveLabs.ResponseStreamEventVariant12, TResult>? keepalive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseStreamEventVariant1 is { } __value0 && responseStreamEventVariant1 != null)
            {
                return responseStreamEventVariant1(__value0);
            }
            else if (ResponseStreamEventVariant2 is { } __value1 && responseStreamEventVariant2 != null)
            {
                return responseStreamEventVariant2(__value1);
            }
            else if (ResponseStreamEventVariant3 is { } __value2 && responseStreamEventVariant3 != null)
            {
                return responseStreamEventVariant3(__value2);
            }
            else if (ResponseStreamEventVariant4 is { } __value3 && responseStreamEventVariant4 != null)
            {
                return responseStreamEventVariant4(__value3);
            }
            else if (ResponseOutputItemAdded is { } __value4 && responseOutputItemAdded != null)
            {
                return responseOutputItemAdded(__value4);
            }
            else if (ResponseContentPartAdded is { } __value5 && responseContentPartAdded != null)
            {
                return responseContentPartAdded(__value5);
            }
            else if (ResponseOutputTextDelta is { } __value6 && responseOutputTextDelta != null)
            {
                return responseOutputTextDelta(__value6);
            }
            else if (ResponseOutputTextDone is { } __value7 && responseOutputTextDone != null)
            {
                return responseOutputTextDone(__value7);
            }
            else if (ResponseContentPartDone is { } __value8 && responseContentPartDone != null)
            {
                return responseContentPartDone(__value8);
            }
            else if (ResponseOutputItemDone is { } __value9 && responseOutputItemDone != null)
            {
                return responseOutputItemDone(__value9);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value10 && responseFunctionCallArgumentsDone != null)
            {
                return responseFunctionCallArgumentsDone(__value10);
            }
            else if (Keepalive is { } __value11 && keepalive != null)
            {
                return keepalive(__value11);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant1>? responseStreamEventVariant1 = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant2>? responseStreamEventVariant2 = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant3>? responseStreamEventVariant3 = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant4>? responseStreamEventVariant4 = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant5>? responseOutputItemAdded = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant6>? responseContentPartAdded = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant7>? responseOutputTextDelta = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant8>? responseOutputTextDone = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant9>? responseContentPartDone = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant10>? responseOutputItemDone = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant11>? responseFunctionCallArgumentsDone = null,

            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant12>? keepalive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseStreamEventVariant1 is { } __value0)
            {
                responseStreamEventVariant1?.Invoke(__value0);
            }
            else if (ResponseStreamEventVariant2 is { } __value1)
            {
                responseStreamEventVariant2?.Invoke(__value1);
            }
            else if (ResponseStreamEventVariant3 is { } __value2)
            {
                responseStreamEventVariant3?.Invoke(__value2);
            }
            else if (ResponseStreamEventVariant4 is { } __value3)
            {
                responseStreamEventVariant4?.Invoke(__value3);
            }
            else if (ResponseOutputItemAdded is { } __value4)
            {
                responseOutputItemAdded?.Invoke(__value4);
            }
            else if (ResponseContentPartAdded is { } __value5)
            {
                responseContentPartAdded?.Invoke(__value5);
            }
            else if (ResponseOutputTextDelta is { } __value6)
            {
                responseOutputTextDelta?.Invoke(__value6);
            }
            else if (ResponseOutputTextDone is { } __value7)
            {
                responseOutputTextDone?.Invoke(__value7);
            }
            else if (ResponseContentPartDone is { } __value8)
            {
                responseContentPartDone?.Invoke(__value8);
            }
            else if (ResponseOutputItemDone is { } __value9)
            {
                responseOutputItemDone?.Invoke(__value9);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value10)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value10);
            }
            else if (Keepalive is { } __value11)
            {
                keepalive?.Invoke(__value11);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant1>? responseStreamEventVariant1 = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant2>? responseStreamEventVariant2 = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant3>? responseStreamEventVariant3 = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant4>? responseStreamEventVariant4 = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant5>? responseOutputItemAdded = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant6>? responseContentPartAdded = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant7>? responseOutputTextDelta = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant8>? responseOutputTextDone = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant9>? responseContentPartDone = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant10>? responseOutputItemDone = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant11>? responseFunctionCallArgumentsDone = null,
            global::System.Action<global::TwelveLabs.ResponseStreamEventVariant12>? keepalive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseStreamEventVariant1 is { } __value0)
            {
                responseStreamEventVariant1?.Invoke(__value0);
            }
            else if (ResponseStreamEventVariant2 is { } __value1)
            {
                responseStreamEventVariant2?.Invoke(__value1);
            }
            else if (ResponseStreamEventVariant3 is { } __value2)
            {
                responseStreamEventVariant3?.Invoke(__value2);
            }
            else if (ResponseStreamEventVariant4 is { } __value3)
            {
                responseStreamEventVariant4?.Invoke(__value3);
            }
            else if (ResponseOutputItemAdded is { } __value4)
            {
                responseOutputItemAdded?.Invoke(__value4);
            }
            else if (ResponseContentPartAdded is { } __value5)
            {
                responseContentPartAdded?.Invoke(__value5);
            }
            else if (ResponseOutputTextDelta is { } __value6)
            {
                responseOutputTextDelta?.Invoke(__value6);
            }
            else if (ResponseOutputTextDone is { } __value7)
            {
                responseOutputTextDone?.Invoke(__value7);
            }
            else if (ResponseContentPartDone is { } __value8)
            {
                responseContentPartDone?.Invoke(__value8);
            }
            else if (ResponseOutputItemDone is { } __value9)
            {
                responseOutputItemDone?.Invoke(__value9);
            }
            else if (ResponseFunctionCallArgumentsDone is { } __value10)
            {
                responseFunctionCallArgumentsDone?.Invoke(__value10);
            }
            else if (Keepalive is { } __value11)
            {
                keepalive?.Invoke(__value11);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseStreamEventVariant1,
                typeof(global::TwelveLabs.ResponseStreamEventVariant1),
                ResponseStreamEventVariant2,
                typeof(global::TwelveLabs.ResponseStreamEventVariant2),
                ResponseStreamEventVariant3,
                typeof(global::TwelveLabs.ResponseStreamEventVariant3),
                ResponseStreamEventVariant4,
                typeof(global::TwelveLabs.ResponseStreamEventVariant4),
                ResponseOutputItemAdded,
                typeof(global::TwelveLabs.ResponseStreamEventVariant5),
                ResponseContentPartAdded,
                typeof(global::TwelveLabs.ResponseStreamEventVariant6),
                ResponseOutputTextDelta,
                typeof(global::TwelveLabs.ResponseStreamEventVariant7),
                ResponseOutputTextDone,
                typeof(global::TwelveLabs.ResponseStreamEventVariant8),
                ResponseContentPartDone,
                typeof(global::TwelveLabs.ResponseStreamEventVariant9),
                ResponseOutputItemDone,
                typeof(global::TwelveLabs.ResponseStreamEventVariant10),
                ResponseFunctionCallArgumentsDone,
                typeof(global::TwelveLabs.ResponseStreamEventVariant11),
                Keepalive,
                typeof(global::TwelveLabs.ResponseStreamEventVariant12),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponseStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant1?>.Default.Equals(ResponseStreamEventVariant1, other.ResponseStreamEventVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant2?>.Default.Equals(ResponseStreamEventVariant2, other.ResponseStreamEventVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant3?>.Default.Equals(ResponseStreamEventVariant3, other.ResponseStreamEventVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant4?>.Default.Equals(ResponseStreamEventVariant4, other.ResponseStreamEventVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant5?>.Default.Equals(ResponseOutputItemAdded, other.ResponseOutputItemAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant6?>.Default.Equals(ResponseContentPartAdded, other.ResponseContentPartAdded) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant7?>.Default.Equals(ResponseOutputTextDelta, other.ResponseOutputTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant8?>.Default.Equals(ResponseOutputTextDone, other.ResponseOutputTextDone) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant9?>.Default.Equals(ResponseContentPartDone, other.ResponseContentPartDone) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant10?>.Default.Equals(ResponseOutputItemDone, other.ResponseOutputItemDone) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant11?>.Default.Equals(ResponseFunctionCallArgumentsDone, other.ResponseFunctionCallArgumentsDone) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.ResponseStreamEventVariant12?>.Default.Equals(Keepalive, other.Keepalive)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseStreamEvent obj1, ResponseStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseStreamEvent o && Equals(o);
        }
    }
}
