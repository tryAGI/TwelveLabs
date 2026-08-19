#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// When the value of the `stream` parameter is set to `true`, the platform provides a streaming response in the NDJSON format.<br/>
    /// The stream contains the following types of events:<br/>
    /// - Stream start<br/>
    /// - Text generation<br/>
    /// - Stream end<br/>
    /// To integrate the response into your application, follow the guidelines below:<br/>
    /// - Parse each line of the response as a separate JSON object.<br/>
    /// - Check the `event_type` field to determine how to handle the event.<br/>
    /// - For `text_generation` events, process the `text` field as it arrives. Depending on your application's requirements, this may involve displaying the text incrementally, storing it for later use, or performing any tasks.<br/>
    /// - Use the `stream_start` and `stream_end` events to manage the lifecycle of your streaming session.
    /// </summary>
    public readonly partial struct StreamAnalyzeResponse : global::System.IEquatable<StreamAnalyzeResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? EventType { get; }

        /// <summary>
        /// Indicates the beginning of the stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? StreamStart { get; init; }
#else
        public global::TwelveLabs.StreamAnalyzeResponseVariant1? StreamStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamStart))]
#endif
        public bool IsStreamStart => StreamStart != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.StreamAnalyzeResponseVariant1? value)
        {
            value = StreamStart;
            return IsStreamStart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant1 PickStreamStart() => IsStreamStart
            ? StreamStart!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamStart' but the value was {ToString()}.");

        /// <summary>
        /// Contains a fragment of generated text. Note that text fragments may be split at arbitrary points, not necessarily at word or sentence boundaries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? TextGeneration { get; init; }
#else
        public global::TwelveLabs.StreamAnalyzeResponseVariant2? TextGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGeneration))]
#endif
        public bool IsTextGeneration => TextGeneration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.StreamAnalyzeResponseVariant2? value)
        {
            value = TextGeneration;
            return IsTextGeneration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant2 PickTextGeneration() => IsTextGeneration
            ? TextGeneration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextGeneration' but the value was {ToString()}.");

        /// <summary>
        /// Indicates the end of the stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? StreamEnd { get; init; }
#else
        public global::TwelveLabs.StreamAnalyzeResponseVariant3? StreamEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEnd))]
#endif
        public bool IsStreamEnd => StreamEnd != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStreamEnd(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::TwelveLabs.StreamAnalyzeResponseVariant3? value)
        {
            value = StreamEnd;
            return IsStreamEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::TwelveLabs.StreamAnalyzeResponseVariant3 PickStreamEnd() => IsStreamEnd
            ? StreamEnd!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEnd' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamAnalyzeResponse(global::TwelveLabs.StreamAnalyzeResponseVariant1 value) => new StreamAnalyzeResponse((global::TwelveLabs.StreamAnalyzeResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.StreamAnalyzeResponseVariant1?(StreamAnalyzeResponse @this) => @this.StreamStart;

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(global::TwelveLabs.StreamAnalyzeResponseVariant1? value)
        {
            StreamStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamAnalyzeResponse FromStreamStart(global::TwelveLabs.StreamAnalyzeResponseVariant1? value) => new StreamAnalyzeResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamAnalyzeResponse(global::TwelveLabs.StreamAnalyzeResponseVariant2 value) => new StreamAnalyzeResponse((global::TwelveLabs.StreamAnalyzeResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.StreamAnalyzeResponseVariant2?(StreamAnalyzeResponse @this) => @this.TextGeneration;

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(global::TwelveLabs.StreamAnalyzeResponseVariant2? value)
        {
            TextGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamAnalyzeResponse FromTextGeneration(global::TwelveLabs.StreamAnalyzeResponseVariant2? value) => new StreamAnalyzeResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StreamAnalyzeResponse(global::TwelveLabs.StreamAnalyzeResponseVariant3 value) => new StreamAnalyzeResponse((global::TwelveLabs.StreamAnalyzeResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::TwelveLabs.StreamAnalyzeResponseVariant3?(StreamAnalyzeResponse @this) => @this.StreamEnd;

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(global::TwelveLabs.StreamAnalyzeResponseVariant3? value)
        {
            StreamEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StreamAnalyzeResponse FromStreamEnd(global::TwelveLabs.StreamAnalyzeResponseVariant3? value) => new StreamAnalyzeResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public StreamAnalyzeResponse(
            global::TwelveLabs.StreamAnalyzeResponseDiscriminatorEventType? eventType,
            global::TwelveLabs.StreamAnalyzeResponseVariant1? streamStart,
            global::TwelveLabs.StreamAnalyzeResponseVariant2? textGeneration,
            global::TwelveLabs.StreamAnalyzeResponseVariant3? streamEnd
            )
        {
            EventType = eventType;

            StreamStart = streamStart;
            TextGeneration = textGeneration;
            StreamEnd = streamEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamEnd as object ??
            TextGeneration as object ??
            StreamStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StreamStart?.ToString() ??
            TextGeneration?.ToString() ??
            StreamEnd?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStreamStart && !IsTextGeneration && !IsStreamEnd || !IsStreamStart && IsTextGeneration && !IsStreamEnd || !IsStreamStart && !IsTextGeneration && IsStreamEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::TwelveLabs.StreamAnalyzeResponseVariant1, TResult>? streamStart = null,
            global::System.Func<global::TwelveLabs.StreamAnalyzeResponseVariant2, TResult>? textGeneration = null,
            global::System.Func<global::TwelveLabs.StreamAnalyzeResponseVariant3, TResult>? streamEnd = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStart && streamStart != null)
            {
                return streamStart(StreamStart!);
            }
            else if (IsTextGeneration && textGeneration != null)
            {
                return textGeneration(TextGeneration!);
            }
            else if (IsStreamEnd && streamEnd != null)
            {
                return streamEnd(StreamEnd!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::TwelveLabs.StreamAnalyzeResponseVariant1>? streamStart = null,

            global::System.Action<global::TwelveLabs.StreamAnalyzeResponseVariant2>? textGeneration = null,

            global::System.Action<global::TwelveLabs.StreamAnalyzeResponseVariant3>? streamEnd = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStart)
            {
                streamStart?.Invoke(StreamStart!);
            }
            else if (IsTextGeneration)
            {
                textGeneration?.Invoke(TextGeneration!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::TwelveLabs.StreamAnalyzeResponseVariant1>? streamStart = null,
            global::System.Action<global::TwelveLabs.StreamAnalyzeResponseVariant2>? textGeneration = null,
            global::System.Action<global::TwelveLabs.StreamAnalyzeResponseVariant3>? streamEnd = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStreamStart)
            {
                streamStart?.Invoke(StreamStart!);
            }
            else if (IsTextGeneration)
            {
                textGeneration?.Invoke(TextGeneration!);
            }
            else if (IsStreamEnd)
            {
                streamEnd?.Invoke(StreamEnd!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StreamStart,
                typeof(global::TwelveLabs.StreamAnalyzeResponseVariant1),
                TextGeneration,
                typeof(global::TwelveLabs.StreamAnalyzeResponseVariant2),
                StreamEnd,
                typeof(global::TwelveLabs.StreamAnalyzeResponseVariant3),
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
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.StreamAnalyzeResponseVariant1?>.Default.Equals(StreamStart, other.StreamStart) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.StreamAnalyzeResponseVariant2?>.Default.Equals(TextGeneration, other.TextGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::TwelveLabs.StreamAnalyzeResponseVariant3?>.Default.Equals(StreamEnd, other.StreamEnd) 
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
