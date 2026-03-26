#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// When the value of the `stream` parameter is set to `true`, the platform provides a streaming response in the NDJSON format.<br/>
    /// The stream contains three types of events:<br/>
    /// 1. Stream start<br/>
    /// 2. Text generation<br/>
    /// 3. Stream end<br/>
    /// To integrate the response into your application, follow the guidelines below:<br/>
    /// - Parse each line of the response as a separate JSON object.<br/>
    /// - Check the `event_type` field to determine how to handle the event.<br/>
    /// - For `text_generation` events, process the `text` field as it arrives. Depending on your application's requirements, this may involve displaying the text incrementally, storing it for later use, or performing any tasks.<br/>
    /// - Use the `stream_start` and `stream_end` events to manage the lifecycle of your streaming session.
    /// </summary>
    public readonly partial struct StreamAnalyzeResponse : global::System.IEquatable<StreamAnalyzeResponse>
    {
        /// <summary>
        /// Indicates the beginning of the stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.StreamStartResponse? StreamStartResponse { get; init; }
#else
        public global::TwelveLabs.StreamStartResponse? StreamStartResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamStartResponse))]
#endif
        public bool IsStreamStartResponse => StreamStartResponse != null;

        /// <summary>
        /// Contains a fragment of generated text. Note that text fragments may be split at arbitrary points, not necessarily at word or sentence boundaries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.StreamTextResponse? StreamTextResponse { get; init; }
#else
        public global::TwelveLabs.StreamTextResponse? StreamTextResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamTextResponse))]
#endif
        public bool IsStreamTextResponse => StreamTextResponse != null;

        /// <summary>
        /// Indicates the end of the stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.StreamEndResponse? StreamEndResponse { get; init; }
#else
        public global::TwelveLabs.StreamEndResponse? StreamEndResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEndResponse))]
#endif
        public bool IsStreamEndResponse => StreamEndResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamAnalyzeResponse(global::TwelveLabs.StreamStartResponse value) => new StreamAnalyzeResponse((global::TwelveLabs.StreamStartResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.StreamStartResponse?(StreamAnalyzeResponse @this) => @this.StreamStartResponse;

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(global::TwelveLabs.StreamStartResponse? value)
        {
            StreamStartResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamAnalyzeResponse(global::TwelveLabs.StreamTextResponse value) => new StreamAnalyzeResponse((global::TwelveLabs.StreamTextResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.StreamTextResponse?(StreamAnalyzeResponse @this) => @this.StreamTextResponse;

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(global::TwelveLabs.StreamTextResponse? value)
        {
            StreamTextResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamAnalyzeResponse(global::TwelveLabs.StreamEndResponse value) => new StreamAnalyzeResponse((global::TwelveLabs.StreamEndResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.StreamEndResponse?(StreamAnalyzeResponse @this) => @this.StreamEndResponse;

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(global::TwelveLabs.StreamEndResponse? value)
        {
            StreamEndResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(
            global::TwelveLabs.StreamStartResponse? streamStartResponse,
            global::TwelveLabs.StreamTextResponse? streamTextResponse,
            global::TwelveLabs.StreamEndResponse? streamEndResponse
            )
        {
            StreamStartResponse = streamStartResponse;
            StreamTextResponse = streamTextResponse;
            StreamEndResponse = streamEndResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamEndResponse as object ??
            StreamTextResponse as object ??
            StreamStartResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamStartResponse?.ToString() ??
            StreamTextResponse?.ToString() ??
            StreamEndResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamStartResponse && !IsStreamTextResponse && !IsStreamEndResponse || !IsStreamStartResponse && IsStreamTextResponse && !IsStreamEndResponse || !IsStreamStartResponse && !IsStreamTextResponse && IsStreamEndResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.StreamStartResponse?, TResult>? streamStartResponse = null,
            global::System.Func<global::TwelveLabs.StreamTextResponse?, TResult>? streamTextResponse = null,
            global::System.Func<global::TwelveLabs.StreamEndResponse?, TResult>? streamEndResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStartResponse && streamStartResponse != null)
            {
                return streamStartResponse(StreamStartResponse!);
            }
            else if (IsStreamTextResponse && streamTextResponse != null)
            {
                return streamTextResponse(StreamTextResponse!);
            }
            else if (IsStreamEndResponse && streamEndResponse != null)
            {
                return streamEndResponse(StreamEndResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.StreamStartResponse?>? streamStartResponse = null,
            global::System.Action<global::TwelveLabs.StreamTextResponse?>? streamTextResponse = null,
            global::System.Action<global::TwelveLabs.StreamEndResponse?>? streamEndResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStartResponse)
            {
                streamStartResponse?.Invoke(StreamStartResponse!);
            }
            else if (IsStreamTextResponse)
            {
                streamTextResponse?.Invoke(StreamTextResponse!);
            }
            else if (IsStreamEndResponse)
            {
                streamEndResponse?.Invoke(StreamEndResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamStartResponse,
                typeof(global::TwelveLabs.StreamStartResponse),
                StreamTextResponse,
                typeof(global::TwelveLabs.StreamTextResponse),
                StreamEndResponse,
                typeof(global::TwelveLabs.StreamEndResponse),
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
        public bool Equals(StreamAnalyzeResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.StreamStartResponse?>.Default.Equals(StreamStartResponse, other.StreamStartResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.StreamTextResponse?>.Default.Equals(StreamTextResponse, other.StreamTextResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.StreamEndResponse?>.Default.Equals(StreamEndResponse, other.StreamEndResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StreamAnalyzeResponse obj1, StreamAnalyzeResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamAnalyzeResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StreamAnalyzeResponse obj1, StreamAnalyzeResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamAnalyzeResponse o && Equals(o);
        }
    }
}
